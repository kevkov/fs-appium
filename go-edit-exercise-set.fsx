#load "tp-session.fsx"
#load "canopy.fsx"

open ``Tp-session``
open Canopy

let d = createSession ()
init d

click "#ViewExercises"
click "#SetsTab"
let els = d.FindElementsByXPath("/*/*/*/*/*/*/*/*/*/*/*/*/*/*")
let tab = d.FindElementByXPath("//android.widget.FrameLayout[@content-desc=\"Sets\"]")
let tab2 = d.fin
click tab
let els = d.FindElementsByClassName("android.widget.TextView")
printfn "%d" (Seq.length els)
printfn "%d" (Seq.length tab)
els |> Seq.iter (fun e -> printfn "%s" (e.GetAttribute("text")))
click els.[0]
d.Url
//click "#ViewExercises"\