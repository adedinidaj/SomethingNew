using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TryingSomething
{
    [TestClass]
    public class SignUpTestCase
    {
        [TestMethod]
        public void SignUpTest()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");

            IWebElement SignIn = driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[2]/a"));
            SignIn.Click();

            IWebElement EmailTextBox = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
            EmailTextBox.Clear();
            EmailTextBox.SendKeys("testing098@gmail.com");

            IWebElement PasswordTextBox = driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));
            PasswordTextBox.Clear();
            PasswordTextBox.SendKeys("testing");

            IWebElement SignInButton = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));
            SignInButton.Click();
        }
    }
}
