using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTest.Helpers
{
    public class Utilities
    {

        internal bool WaitForElementToBeDisplayedAndEnabled(string Element, IWebDriver Driver, double seconds)
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
                wait.Until(x =>
                {
                    try
                    {
                        var element = Driver.FindElement(By.CssSelector(Element));
                        if (element.Displayed && element.Enabled)
                        { return true; }
                        else return false;

                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                });
            }
            catch
            {
                return false;

            }
            return true;
        }

        internal void AlertWindowAccept(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
            var simpleAlertWindow = driver.SwitchTo().Alert();
            simpleAlertWindow.Accept();
        }

    }
}
