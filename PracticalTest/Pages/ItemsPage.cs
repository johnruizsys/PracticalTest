using OpenQA.Selenium;
using PracticalTest.Configuration;
using PracticalTest.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTest.Pages
{
    public class ItemsPage:ObjectRepository
    {
        private IWebDriver driver;

        public ItemsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddToCart()
        {
            Utilities.WaitForElementToBeDisplayedAndEnabled("a[class*=\"btn-success\"]", driver, 20);
            var button = driver.FindElement(By.CssSelector("a[class*=\"btn-success\"]"));
            button.Click();

            Utilities.AlertWindowAccept(driver);
        }
    }
}
