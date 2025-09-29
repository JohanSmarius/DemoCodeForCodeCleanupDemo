using Domain;
using System.Linq;
using System;   

namespace SomeNameSpace
{
public class ShoppingCartService
{
        public ShoppingCartService(Customer customer)
    {
        if (customer == null)
            throw new ArgumentNullException(nameof(customer));
        _order = new Order(customer, DateTime.Now);
        _totalPrice = 0;
        }

        public void AddToBasket(Product product, int quantity, DateTime date)
    {
            int customerId;
            int productId;

        if (quantity<=0)
            throw new ArgumentException("Quantity must be greater than zero.");

        var existingOrderLine = _order.OrderLines.FirstOrDefault(ol => ol.Product.Id == product.Id);
        if (existingOrderLine != null)
            existingOrderLine.Quantity += quantity;
        else { 
            var orderLine = new OrderLine(_order,product,quantity);
            _order.OrderLines.Add(orderLine);
        }

        // If the total price exceeds $100, apply a 10% discount
        if (_order.TotalPrice()>100)
            _totalPrice = _order.TotalPrice() * 0.9m; // Apply 10% discount
        else { 
            _totalPrice = _order.TotalPrice();
        }


    }

  private Order _order;

    private decimal _totalPrice;

        public decimal TotalPrice { get => _totalPrice; }
    }
}
