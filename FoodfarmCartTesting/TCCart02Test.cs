using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodfarmCartTesting
{

    [TestFixture]
    public class TCCart02Test
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
        public void tCCart02()
        {
            driver.Navigate().GoToUrl("http://foodfarmvn.somee.com/Default.aspx");
            driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
            driver.FindElement(By.Id("ucHeaderMain_lbtDangNhap")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUsername")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUsername")).SendKeys("manhranger");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPassword")).SendKeys("123456");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            js.ExecuteScript("window.scrollTo(0,400)");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);


            IWebElement element =driver.FindElement(By.Id("ContentPlaceHolder1_dtListSanPham_hlMua_5"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            driver.FindElement(By.Id("ContentPlaceHolder1_dtListSanPham_hlMua_5")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,400)");
            driver.FindElement(By.Id("ContentPlaceHolder1_gvCart_txtInputNumber_0")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,500)");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            driver.FindElement(By.Id("ContentPlaceHolder1_gvCart_txtInputNumber_0")).SendKeys("123");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,600)");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnUpate")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,600)");
            driver.FindElement(By.Id("ContentPlaceHolder1_lbtnProceed")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,800)");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtAddress")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtAddress")).SendKeys("Bình Dương");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPhone")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPhone")).SendKeys("8474582675");

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,1000)");
            driver.FindElement(By.CssSelector(".wpb_wrapper")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();

        }
    }
}
