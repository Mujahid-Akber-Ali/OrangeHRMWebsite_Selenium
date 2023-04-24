using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace OrangeHRMWebsite_Selenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Complete_Automation()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");

            Thread.Sleep(5000);
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//*[@id='app']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("oxd-main-menu-item")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='app']/div[1]/div[2]/div[2]/div/div[2]/div[1]/button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[1]/div/div[2]/div/div/div[1]")).SendKeys("e");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[1]/div/div[2]/div/div/div[1]")).SendKeys(Keys.Enter);


            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input")).SendKeys("a");
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input")).SendKeys(Keys.Enter);

            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div/div[1]")).SendKeys("e");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div/div[1]")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div/div[1]")).SendKeys(Keys.Enter);

            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input")).SendKeys("Mujahid");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[1]/div/div[2]/input")).SendKeys("Mujahidakberali@#@#121");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/div/div[2]/input")).SendKeys("Mujahidakberali@#@#121");

            Thread.Sleep(3000);

            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[3]/button[2]")).Click();


            //Update data
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input")).SendKeys("Mujahid");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div[2]/div/div/div[6]/div/button[2]")).Click();
            Thread.Sleep(3000);
            var element = driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input"));
            Actions action = new Actions(driver);
            action.DoubleClick(element).Perform();
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input")).SendKeys("Osama");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[2]/button[2]")).Click();

            //delete data
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input")).SendKeys("Osama");
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]")).Click();

            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div[1]/div/div[1]/div/label/span")).Click();
            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div[2]/div[2]/div/div/button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div[3]/div/div/div/div[3]/button[2]")).Click();


        }
    }
}
