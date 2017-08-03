using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernStore.Domain.Entities;

namespace ModernStore.Domain.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        [TestCategory("Order - New Order")]
        
        public void GivenAnOutOfStockProductItShouldReturnAnError()
        {
            var user = new User("stanleyalves", "stanleyalves");
            var customer = new Customer("Stanley", "Alves", "stanleyalves@live.com", user);
            var mouse = new Product("Mouse", 299, "mouse.jpg", 0);
            
            

            var order = new Order(customer, 8, 10);
            order.AddItem(new OrderItem(mouse, 2));
            
            Assert.IsFalse(order.IsValid());
        }
    }
}
