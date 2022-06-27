using AppiumTest.PageObject;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTest.BusinessObject
{
    internal class CalculatorBusinessObject
    {
        private readonly HomePage homePage;
        private readonly CalculatorPage calculatorPage;

        public CalculatorBusinessObject(AppiumDriver<AndroidElement> driver)
        {
            homePage = new HomePage(driver);
            calculatorPage = new CalculatorPage(driver);    
        }

        public CalculatorBusinessObject GoToCalculatorPage()
        {
            homePage.AcceptSendingStatisticButtonClick();
            homePage.NoLogInButtonClick();
            homePage.GoToCalculatorPage();
            return this;
        }

        public CalculatorBusinessObject DoOperations(double firstNumber, double secondNumber)
        {
            calculatorPage.EnterNumberInTheField(firstNumber,secondNumber);
            calculatorPage.CalculateButtonClick();
            return this;
        }
        public string GetResult()
        {
            return calculatorPage.GetResult();
        }
    }
}
