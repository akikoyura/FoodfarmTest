using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodfarmRegistrationTesting
{
    [TestFixture]
    public class TCRegister03Test
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        [Test]
        public void tCRegister03()
        {
            driver.Navigate().GoToUrl("http://foodfarmvn.somee.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(811, 691);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(By.CssSelector(".fa-caret-down")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,300)");
            driver.FindElement(By.LinkText("Login / Register")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,600)");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRPhone")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRPhone")).SendKeys("0123557828");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRUser")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRUser")).SendKeys("NguyenTung");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtREmail")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtREmail")).SendKeys("Tung@gmail.com");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRPassword")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRPassword")).SendKeys("12345678");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnRegister")).Click();
            driver.FindElement(By.CssSelector("#customer_login .col-md-6:nth-child(2)")).Click();
            driver.FindElement(By.CssSelector(".register")).Click();
            driver.FindElement(By.CssSelector(".wpb_wrapper")).Click();
            Assert.That(driver.FindElement(By.Id("ContentPlaceHolder1_RequiredFieldValidator7")).Text, Is.EqualTo("Please enter your Address"));
            driver.FindElement(By.CssSelector(".wpb_wrapper")).Click();
            Assert.That(driver.FindElement(By.Id("ContentPlaceHolder1_RequiredFieldValidator6")).Text, Is.EqualTo("Please Enter your Name"));
        }
    }

}
