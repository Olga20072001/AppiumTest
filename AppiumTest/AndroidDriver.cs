using OpenQA.Selenium.Appium.Android;

namespace AppiumTest
{
    internal class AndroidDriver
    {
        public static AndroidDriver<AndroidElement>? driver;
        public AndroidDriver<AndroidElement> getDriver()
        {
            if(driver==null)
            {
                driver = new AndroidDriver<AndroidElement>(Capabilities.getAppiumServerUri(), Capabilities.getCapabilities());
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
            return driver;
        }
        public static void QuitDriver()
        {
            if(driver !=null)   
                driver.Quit();
        }
    }
}
