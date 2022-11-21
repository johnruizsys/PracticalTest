using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PracticalTest.Configuration;
using PracticalTest.Helpers;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticalTest.Pages
{
    public class MainPage:ObjectRepository
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickAnItem()
        {
            //wait.until de fmpilot
            /*var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[id=\"tbodyid\"]>div")));*/

            Utilities.WaitForElementToBeDisplayedAndEnabled("div[id=\"tbodyid\"]>div", driver, 1);

            var itemList = driver.FindElements(By.CssSelector("div[id=\"tbodyid\"]>div")).ToList();
            Random random = new Random();
            int index = random.Next(itemList.Count);
            var item = itemList[index];
            item.Click();
        }
        
    } 
}
