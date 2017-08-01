using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernStore.Domain.Entities;

namespace ModernStore.Domain.Tests
{
    [TestClass]
    public class CustomerTests
    {
        private User user = new User("stanley", "stanley");
        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void Dado_um_primeironome_invalido_deve_retornar_uma_notificacao() //GivenAnInvalidFirstNameShouldReturnANotification
        { 
            var customer = new Customer("","Alves", "stanleyalves@live.com",user);
            Assert.IsFalse(customer.IsValid());
        }

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void Dado_um_ultimonome_invalido_deve_retornar_uma_notificacao() //GivenAnInvalidLastNameShouldReturnANotification
        {
            var customer = new Customer("Stanley", "", "stanleyalves@live.com", user);
            Assert.IsFalse(customer.IsValid());
        }

        [TestMethod]
        [TestCategory("Customer - New Customer")]
        public void Dado_um_email_invalido_deve_retornar_uma_notificacao() //GivenAnInvalidEmailShouldReturnANotification
        {
            var customer = new Customer("Stanley", "stanleyalves@live.com","a", user);
            Assert.IsFalse(customer.IsValid());
        }
    }
}
