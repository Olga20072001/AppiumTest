using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTest.PageObject
{
    internal class BasePage
    {
        protected AppiumDriver<AndroidElement> driver;
        public BasePage(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }
    }
}
