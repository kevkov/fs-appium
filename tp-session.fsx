#r "nuget: Appium.WebDriver"

open OpenQA.Selenium
open OpenQA.Selenium.Appium
open OpenQA.Selenium.Appium.Android
open OpenQA.Selenium.Appium.Enums
open OpenQA.Selenium.Appium.Service

let appiumOptions = AppiumOptions()
let builder = AppiumServiceBuilder()

let createSession () =
    let localService = builder.UsingAnyFreePort().Build()
    do localService.Start()
    let options = AppiumOptions (PlatformName = "Android")
    do options.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel 3a API 28")
    //do options.AddAdditionalCapability(MobileCapabilityType.App, "net.theracode.therapypal")
    //do options.AddAdditionalCapability(AndroidMobileCapabilityType.AppWaitActivity, "crc645260f6a898cf7947.SplashActivity")
    //do options.AddAdditionalCapability(AndroidMobileCapabilityType.AppWaitActivity, "crc645260f6a898cf7947.SplashActivity")
    do options.AddAdditionalCapability(MobileCapabilityType.Udid, "emulator-5554")
    do options.AddAdditionalCapability(MobileCapabilityType.AutomationName, "UiAutomator2")
    do options.AddAdditionalCapability(MobileCapabilityType.NoReset, "true")
    do options.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, 600)
    let driver = new AndroidDriver<IWebElement>(localService.ServiceUrl, options)
    driver