using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidator;
using ModernStore.Shared.Entities;

namespace ModernStore.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, int quantity, decimal price)
        {
            Product = product;
            Quantity = quantity;
            Price = Product.Price;

            new ValidationContract<OrderItem>(this)
                .IsGreaterThan(x => x.Quantity, 1);

        }

        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public decimal Total() => Price * Quantity;
    }
}
