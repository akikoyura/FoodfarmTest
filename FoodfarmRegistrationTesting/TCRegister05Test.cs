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
    public class TCRegister05Test
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
        public void tCRegister05()
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
            driver.FindElement(By.Id("ContentPlaceHolder1_txtREmail")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtREmail")).SendKeys("Tung@gmail.com");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRPassword")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRPassword")).SendKeys("1234567");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnRegister")).Click();
            Assert.That(driver.FindElement(By.Id("ContentPlaceHolder1_RequiredFieldValidator3")).Text, Is.EqualTo("Please enter your Username"));
            Assert.That(driver.FindElement(By.Id("ContentPlaceHolder1_RequiredFieldValidator8")).Text, Is.EqualTo("Please enter your Phone's Number"));
            Assert.That(driver.FindElement(By.Id("ContentPlaceHolder1_RequiredFieldValidator7")).Text, Is.EqualTo("Please enter your Address"));
            Assert.That(driver.FindElement(By.Id("ContentPlaceHolder1_RequiredFieldValidator6")).Text, Is.EqualTo("Please Enter your Name"));
        }
    }

}
