using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTest.PageObject
{
    internal class CalculatorPage:BasePage
    {
        public CalculatorPage(AppiumDriver<AndroidElement> driver) : base(driver) { }

        private readonly string FirstNumberField = "number1Field";
        private readonly string SecondNumberField = "number2Field";
        private readonly string ResultField = "numberAnswerField";
        private readonly string CalculateButton = "calculateButton";

        [AllureStep("Enter numbers in fields")]
        public CalculatorPage EnterNumberInTheField(double firstNumber,double secondNumber)
        {
            driver.FindElement(By.Id(FirstNumberField)).SendKeys(firstNumber.ToString());
            driver.FindElement(By.Id(SecondNumberField)).SendKeys(secondNumber.ToString());
            return this;
        }

        [AllureStep("Calculate button click")]
        public CalculatorPage CalculateButtonClick()
        {
            driver.FindElement(By.Id(CalculateButton)).Click();
            return this;
        }

        [AllureStep("Get result")]
        public string GetResult()
        {
            string result = driver.FindElement(By.Id(ResultField)).Text;
            return result;
        }



    }
}
