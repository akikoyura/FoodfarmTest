﻿using NUnit.Framework;
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
public class TCCart06Test {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void tCCart06() {
    driver.Navigate().GoToUrl("http://foodfarmvn.somee.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
    js.ExecuteScript("window.scrollTo(0,1400)");
    driver.FindElement(By.CssSelector("#ContentPlaceHolder1_dtListFreshFruits_htMua2_1 .fa")).Click();
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
    js.ExecuteScript("window.scrollTo(0,200)");
    driver.FindElement(By.Id("ContentPlaceHolder1_gvCart_txtInputNumber_0")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,300)");
            driver.FindElement(By.Id("ContentPlaceHolder1_gvCart_txtInputNumber_0")).SendKeys("347");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,300)");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnUpate")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            js.ExecuteScript("window.scrollTo(0,300)");
            driver.FindElement(By.Id("ContentPlaceHolder1_lbtnProceed")).Click();
    driver.FindElement(By.Id("ContentPlaceHolder1_txtFullName")).Click();
    driver.FindElement(By.Id("ContentPlaceHolder1_txtFullName")).SendKeys("NTTung");
    driver.FindElement(By.Id("ContentPlaceHolder1_btnSubmit")).Click();
  }
}

}
