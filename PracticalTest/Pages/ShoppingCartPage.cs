using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PracticalTest.Configuration;
using PracticalTest.Helpers;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Xml.Linq;

namespace PracticalTest.Pages
{
    public class ShoppingCartPage:ObjectRepository
    {
        public IWebElement purchaseOrderButton => driver.FindElement(By.CssSelector("button[class*=\"btn-success\"]"));
        public IWebElement clientName => driver.FindElement(By.Id("name"));

        public IWebElement country => driver.FindElement(By.Id("country"));

        public IWebElement city => driver.FindElement(By.Id("city"));
        public IWebElement creditCard => driver.FindElement(By.Id("card"));

        public IWebElement month => driver.FindElement(By.Id("month"));

        public IWebElement year => driver.FindElement(By.Id("year"));

        public IWebElement purchaseAndBuyButton => driver.FindElement(By.XPath("//button[text()='Purchase']"));

        public IWebElement successMessage => driver.FindElement(By.CssSelector("div[class*=\"sweet-alert\"]>h2"));

        public IWebElement OKbutton => driver.FindElement(By.CssSelector("div[class*=\"sa-confirm-button-container\"]>button"));








        private IWebDriver driver;

        public ShoppingCartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void PlaceAnOrder()
        {
            Utilities.WaitForElementToBeDisplayedAndEnabled("button[class*=\"btn-success\"]",driver,20);
            purchaseOrderButton.Click();
            Utilities.WaitForElementToBeDisplayedAndEnabled("div[class*=\"modal-body\"]", driver, 20);
            FillPlaceOrderForm();
        }

        private void FillPlaceOrderForm()
        {
            clientName.SendKeys("QATest");
            country.SendKeys("Test");
            city.SendKeys("Test");
            creditCard.SendKeys("Test");    
            month.SendKeys("Test"); 
            year.SendKeys("Test");
            
            
        }

        internal bool Purchase()
        {
            try{
                //purchaseAndBuyButton.Submit();

                Actions actions = new Actions(driver);
                actions.MoveToElement(purchaseAndBuyButton);
                actions.Perform();
                purchaseAndBuyButton.Click();
               var text= successMessage.Text;
                if (text.Equals("Thank you for your purchase!"))
                {
                    OKbutton.Click();
                    return true;    
                }
                
            }
            catch {
                var ex = new Exception("Cannot Click Purchase");
                throw ex;
                
            }
            return false;

        }
    }
}
