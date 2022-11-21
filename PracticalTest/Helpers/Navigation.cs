using OpenQA.Selenium;
using PracticalTest.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTest.Helpers
{
    public class Navigation:ObjectRepository
    {
        private IWebDriver driver;

        public Navigation(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateToCart()
        {
            driver.FindElement(By.Id("cartur")).Click();
            Utilities.WaitForElementToBeDisplayedAndEnabled("div[id=\"page - wrapper\"]", driver, 20);
        }
    }
}
