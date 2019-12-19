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
    public class TCRegister01Test
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
        public void tCRegister01()
        {
            driver.Navigate().GoToUrl("http://foodfarmvn.somee.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(811, 691);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(By.CssSelector(".fa-caret-down")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,300)");
            driver.FindElement(By.LinkText("Login / Register")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,800)");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRName")).SendKeys("NguyenToan");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRAddress")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRAddress")).SendKeys("Phu Hoa Binh Duong");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRPhone")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRPhone")).SendKeys("0126374897");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRUser")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRUser")).SendKeys("NguyenToan");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtREmail")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtREmail")).SendKeys("Toan@gmail.com");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRPassword")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtRPassword")).SendKeys("12345678");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnRegister")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,800)");
            Assert.That(driver.FindElement(By.Id("ContentPlaceHolder1_hlRegister")).Text, Is.EqualTo("Account registration successful. Sign in to continue"));
        }
    }

}
