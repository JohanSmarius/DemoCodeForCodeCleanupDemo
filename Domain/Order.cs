using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public Customer Customer { get; set; }

        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

        public DateTime OrderDate { get; set; }

        public Order(Customer customer, DateTime orderDate)
        {
            Customer = customer;
            OrderDate = orderDate;
        }

        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (var line in OrderLines)
            {
                total += line.Product.PriceWithVat * line.Quantity;
            }
            return total;
        }

    }
}
