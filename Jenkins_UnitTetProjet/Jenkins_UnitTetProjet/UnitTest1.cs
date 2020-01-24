using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Jenkins_UnitTetProjet
{
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void TestMethod1()
        {
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.Name("q")).SendKeys("Selenium");
        }

        [Test]
        public void TestMethod2()
        {
            driver.Url = "https://www.google.com/";
        }
    }
}
