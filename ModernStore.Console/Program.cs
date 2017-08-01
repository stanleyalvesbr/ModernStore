using System;
using FluentValidator;
using ModernStore.Domain.Entities;


namespace ModernStore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("stanleyalves", "stanleyalves");
            var customer = new Customer("Stanley", "Alves", "stanleyalves@live.com", user);
            var mouse = new Product("Mouse", 299, "mouse.jpg", 5);
            var mousepad = new Product("Mouse Pad", 99, "mousepad.jpg", 7);
            var teclado = new Product("Teclado", 599, "teclado.jpg", 2);


            var order = new Order(customer, 8, 10);
           ///// order.AddItem(new OrderItem(mouse,2));


            System.Console.WriteLine($"{customer.ToString()}");
            System.Console.ReadKey();
        }
    }

}
