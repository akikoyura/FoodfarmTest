using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodfarmAddProductTesting
{
    [TestFixture]
    public class TCAddProduct05Test
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
        public void tCAddProduct05()
        {
            driver.Navigate().GoToUrl("http://foodfarmvn.somee.com/");
            driver.Manage().Window.Size = new System.Drawing.Size(1677, 903);
            driver.FindElement(By.Id("ucHeaderMain_lbtDangNhap")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUsername")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUsername")).SendKeys("MaiHoang");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPassword")).SendKeys("12345");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.Id("ContentPlaceHolder1_lbtAddProduct")).Click();
            js.ExecuteScript("window.scrollTo(0,1000)");
            driver.FindElement(By.Id("ContentPlaceHolder1_BtnSubmit")).Click();
            driver.FindElement(By.CssSelector("tr:nth-child(1) > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.Id("ContentPlaceHolder1_RequiredFieldValidator1")).Text, Is.EqualTo("Please Enter Product Name"));
            driver.FindElement(By.CssSelector("tr:nth-child(2) > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.Id("ContentPlaceHolder1_RequiredFieldValidator2")).Text, Is.EqualTo("Please Enter Unit"));
            driver.FindElement(By.CssSelector("tr:nth-child(3) > td:nth-child(2)")).Click();
            Assert.That(driver.FindElement(By.Id("ContentPlaceHolder1_RequiredFieldValidator3")).Text, Is.EqualTo("Please Enter Price"));
        }
    }

}
