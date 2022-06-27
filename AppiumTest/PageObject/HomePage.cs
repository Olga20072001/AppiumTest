using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTest.PageObject
{
    internal class HomePage:BasePage
    {
        public HomePage(AppiumDriver<AndroidElement> driver) : base(driver) { }

        private readonly string AcceptSendingStatisticButton = "terms_accept";  
        private readonly string NoLogInButton = "negative_button";
        private readonly string SearchField = "search_box_text";
        private readonly string CalculatorUrl = "https://www.desmos.com/scientific";

        [AllureStep("Accept sending statistic button click")]
        public HomePage AcceptSendingStatisticButtonClick()
        {
            driver.FindElement(By.Id(AcceptSendingStatisticButton)).Click();
            return this;
        }

        [AllureStep("No LogIn button click")]
        public HomePage NoLogInButtonClick()
        {
            driver.FindElement(By.Id(NoLogInButton)).Click();
            return this;
        }

        [AllureStep("Go to calculator home page")]
        public CalculatorPage GoToCalculatorPage()
        {
            driver.FindElement(By.Id(SearchField)).SendKeys(CalculatorUrl + Keys.Enter);
            return new CalculatorPage(driver);
        }
        

    }
}
