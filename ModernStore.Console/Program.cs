using System;
using ModernStore.Domain.Entities;

namespace ModernStore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Stanley",
                "Alves",
                new DateTime(1971, 8, 8),
                "stanley",
                "stanley.alv3s@gmail.com");
            
            customer.Activate();

            System.Console.WriteLine($"{customer.ToString()}");
            System.Console.ReadKey();
        }
    }

}
