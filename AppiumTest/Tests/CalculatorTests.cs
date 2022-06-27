
using AppiumTest.BusinessObject;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium.Appium.Android;

namespace AppiumTest.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Calculator Tests")]
    [AllureDisplayIgnored]
    [AllureOwner("Melnyk Olga")]
    public class CalculatorTests
    {
        private CalculatorBusinessObject calculatorBusinessObject;
        private AndroidDriver driver;

        [SetUp]
        public void Setup()
        {
            calculatorBusinessObject = new CalculatorBusinessObject(driver.getDriver());
        }

        [AllureSubSuite("Addition Tests")]
        [Category("Addition")]
        [TestCase(5, 6, 11)]
        [TestCase(-2,-3,-5)]
        [TestCase(0,0,0)]
        public void AddTwoNumbers(double firstNumber, double secondNumber, double expected)
        {
            calculatorBusinessObject.GoToCalculatorPage();
            calculatorBusinessObject.DoOperations(firstNumber, secondNumber);
            string result = calculatorBusinessObject.GetResult();
            Assert.That(result, Is.EqualTo(expected.ToString()));
        }

        [TearDown]
        public void TearDown()
        {
            AndroidDriver.QuitDriver();
        }
    }
}