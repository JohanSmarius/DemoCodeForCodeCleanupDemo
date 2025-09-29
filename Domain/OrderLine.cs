using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class OrderLine
    {
        private int quantity;

        public Order MyProperty { get; set; }

        public Product Product { get; set; }

        public int Quantity { get => quantity; set => quantity = value; }

        public OrderLine(Order order, Product product, int quantity)
        {
            MyProperty = order;
            Product = product;
            Quantity = quantity;
        }

       

    }
}
