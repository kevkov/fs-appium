#r "nuget: Appium.WebDriver"

open OpenQA.Selenium
open OpenQA.Selenium.Appium.Android

let mutable d = null

let init (driver: AndroidDriver<IWebElement>) =
    d <- driver

let find name =
    d.FindElementByAccessibilityId name
    
let click item =
    match box item with
    | :? IWebElement as element -> element.Click()
    | :? string as id -> (find id).Click()
    | _ -> failwith "itme not string or element"
    
//    let waitFor marked =
//        app.WaitForElement(fun c -> c.Marked(marked)) |> ignore
//        
//    let snap name =
//        do app.Screenshot name |> ignore
//
//    let tap name =
//        app.Tap(fun b -> b.Marked(name))
//        
//    let enter (name:string) text =
//        app.EnterText(name, text)
//        
//    let (<<) name text =
//        enter name text
//        
//    let repl () =
//        app.Repl()