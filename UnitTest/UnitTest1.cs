using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new ChromeDriver();
            // Go to google website
            driver.Url = "https://www.google.com";
            Thread.Sleep(2000);

            // Refresh the browser window
            driver.Navigate().Refresh();
            Thread.Sleep(4000);

            // Navigate to techexpozed
            driver.Url = "https://www.techexpozed.co.nz";
            Thread.Sleep(3000);
            // Maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            // Click on about menu 
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/div/div[2]/div[1]/nav/ul/li[4]/a/span")).Click();

            // Get the url
            Console.WriteLine(driver.Url);

            // Go back and get the title and page source
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.PageSource);

            // Set the window size(1000,500)
            driver.Manage().Window.Size = new System.Drawing.Size(1000, 500);
            Size size = driver.Manage().Window.Size;
            Console.WriteLine(size);

            // Scroll down to footer and click on the logo
            IJavaScriptExecutor executor = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            executor.ExecuteScript("window.scrollBy(0,4500)");
            Thread.Sleep(4000);
            //tech intern 
            driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div/div[5]/ul/li[2]/a/img")).Click();
            Thread.Sleep(4000);

            // Switch tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(4000);

            driver.Close();
            Thread.Sleep(4000);
            // Quit the driver
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
