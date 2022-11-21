using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools.V105.Page;
using PracticalTest.Initializer;
using PracticalTest.Pages;

namespace PracticalTest.Tests
{
    [TestClass]
    public class ShoppingCartTests:TestInitializer
    {
        [TestMethod]
        public void PlaceAnOrder()
        {
            MainPage.ClickAnItem();
            ItemsPage.AddToCart();
            Navigation.NavigateToCart();
            ShoppingCartPage.PlaceAnOrder();
            Assert.IsTrue(ShoppingCartPage.Purchase(), "Purchase not verified");
                
        }
    }
}
