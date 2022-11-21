using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticalTest.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTest.Initializer
{
    [TestClass]
    public class TestInitializer : ObjectRepository
    {
        [TestInitialize]
        public virtual void Setup()
        {

            Driver.Navigate().GoToUrl(ThisURL());

            //Utilities.WaitForElementToAppear(Driver, Driver.FindElement(By.Id("Password")));

        }

        private string ThisURL()
        {
            return "https://www.demoblaze.com/";
        }

        [TestCleanup]
        public void CleanUp() => Driver.Quit();
    }
}
