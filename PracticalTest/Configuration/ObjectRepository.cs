using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PracticalTest.Helpers;
using PracticalTest.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalTest.Configuration
{
    public class ObjectRepository
    {
        protected string Username = "jason.alfaro";
        protected string Password = "Welcome11!";
        private IWebDriver _driver { get; set; }
        public IWebDriver Driver
        {
            get
            {
                try
                {
                    if (_driver == null)
                    {
                        _driver = new ChromeDriver();


                        _driver.Manage().Window.Maximize();

                    }
                    return _driver;


                }
                catch (Exception exception)
                {
                    System.ArgumentException ex = new System.ArgumentException("Cannot start driver", exception);
                    throw ex;
                }


            }
            set { _driver = value; }
        }

        private MainPage _mainPage { get; set; }
        public MainPage MainPage
        {
            get
            {
                if (_mainPage == null)
                {

                    _mainPage = new MainPage(_driver);
                }
                return _mainPage;
            }
        }

        private ItemsPage _itemsPage { get; set; }
        public ItemsPage ItemsPage
        {
            get
            {
                if (_itemsPage == null)
                {

                    _itemsPage = new ItemsPage(_driver);
                }
                return _itemsPage;
            }
        }

        private ShoppingCartPage _shoppingCartPage { get; set; }
        public ShoppingCartPage ShoppingCartPage
        {
            get
            {
                if (_shoppingCartPage == null)
                {

                    _shoppingCartPage = new ShoppingCartPage(_driver);
                }
                return _shoppingCartPage;
            }
        }

        private Navigation _navigation { get; set; }
        public Navigation Navigation
        {
            get
            {
                if (_navigation == null)
                {

                    _navigation = new Navigation(_driver);
                }
                return _navigation;
            }
        }

        private Utilities _utilities { get; set; }

        public Utilities Utilities
        {
            get
            {
                if (_utilities == null)
                {
                    _utilities = new Utilities();

                }
                return _utilities;
            }
            set { _utilities = value; }
        }
    }
}
