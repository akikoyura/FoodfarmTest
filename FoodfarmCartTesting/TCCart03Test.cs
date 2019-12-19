using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodfarmCartTesting
{
    [TestFixture]
    public class TCCart03Test
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
        public void tCCart03()
        {
            driver.Navigate().GoToUrl("http://foodfarmvn.somee.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,1000)");
            driver.FindElement(By.CssSelector("#ContentPlaceHolder1_dtListFreshVegetables_hlMua1_1 .fa")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,1000)");
            driver.FindElement(By.Id("ContentPlaceHolder1_gvCart_txtInputNumber_0")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,600)");
            driver.FindElement(By.Id("ContentPlaceHolder1_gvCart_txtInputNumber_0")).SendKeys("12");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,400)");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnUpate")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,400)");
            driver.FindElement(By.Id("ContentPlaceHolder1_lbtnProceed")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtFullName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtFullName")).SendKeys("Nguyễn THanh Tùng");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtAddress")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtAddress")).SendKeys("BD");
            driver.FindElement(By.CssSelector(".checkout > .row")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
        }
    }

}
