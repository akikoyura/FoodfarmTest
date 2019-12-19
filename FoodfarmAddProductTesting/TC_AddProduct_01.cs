using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodfarmAddProductTesting
{
    [TestFixture]
    public class TCAddProduct01Test
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
        public void tCAddProduct01()
        {
            driver.Navigate().GoToUrl("http://foodfarmvn.somee.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
            driver.FindElement(By.Id("ucHeaderMain_lbtDangNhap")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUsername")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUsername")).SendKeys("MaiHoang");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPassword")).SendKeys("12345");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.Id("ContentPlaceHolder1_lbtAddProduct")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductName")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductName")).SendKeys("TaoTau");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUnit")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUnit")).SendKeys("Kg");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPrice")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPrice")).SendKeys("5000");
            js.ExecuteScript("window.scrollBy(0,1000)");
            driver.FindElement(By.Id("ContentPlaceHolder1_BtnSubmit")).Click();
            driver.FindElement(By.CssSelector(".woocommerce-message")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".woocommerce-message")).Text, Is.EqualTo("add product to database successfully."));

        }
    }

}
