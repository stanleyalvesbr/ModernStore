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
            var mouse = new Product("Mouse", 299, "mouse.jpg", 20);
            var mousepad = new Product("Mouse Pad", 99, "mousepad.jpg", 20);
            var teclado = new Product("Teclado", 599, "teclado.jpg", 20);

            System.Console.WriteLine($"Mouses: {mouse.QuantityOnHand}");
            System.Console.WriteLine($"Mouses Pag: {mousepad.QuantityOnHand}");
            System.Console.WriteLine($"Teclados: {teclado.QuantityOnHand}");

 
            var order = new Order(customer, 8, 10);
            order.AddItem(new OrderItem(mouse, 2));
            order.AddItem(new OrderItem(mousepad, 2));
            order.AddItem(new OrderItem(teclado, 2));

            System.Console.WriteLine($"Número do Pedido: {order.Number}");
            System.Console.WriteLine($"Data do Pedido: {order.CreateDate :dd/MM/yyyy}");
            System.Console.WriteLine($"Desconto: {order.Discount}");
            System.Console.WriteLine($"Taxa de Entrega: {order.DeliveryFee}");
            System.Console.WriteLine($"Sub Total: {order.Subtotal()}");
            System.Console.WriteLine($"Total: {order.Total()}");
            System.Console.WriteLine($"Cliente: {order.Customer.ToString()}");

            System.Console.WriteLine($"Mouses: {mouse.QuantityOnHand}");
            System.Console.WriteLine($"Mouses Pag: {mousepad.QuantityOnHand}");
            System.Console.WriteLine($"Teclados: {teclado.QuantityOnHand}");

            System.Console.ReadKey();
        }
    }

}
