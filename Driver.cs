using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    
    class Driver
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\blexi\\Downloads\\");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();
            IWebElement link = driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
