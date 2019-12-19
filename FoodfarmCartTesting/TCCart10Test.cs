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
    public class TCCart10Test
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
        public void tCCart10()
        {
            driver.Navigate().GoToUrl("http://foodfarmvn.somee.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(871, 703);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,1600)");
            driver.FindElement(By.CssSelector("#ContentPlaceHolder1_dtListFreshFruits_htMua2_2 .fa")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,300)");
            driver.FindElement(By.Id("ContentPlaceHolder1_gvCart_txtInputNumber_0")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_gvCart_txtInputNumber_0")).SendKeys("7554");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnUpate")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,300)");
            driver.FindElement(By.Id("ContentPlaceHolder1_lbtnProceed")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,300)");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtFullName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtFullName")).SendKeys("Nguyễn Thanh TÙng");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtAddress")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtAddress")).SendKeys("Bình Dương");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPhone")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPhone")).SendKeys("097458275");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
        }
    }

}
