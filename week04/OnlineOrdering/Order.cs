using System;

public class Order
{
     private List<Product> _products;
     private Customer _customer;

     public Order(Customer customer)
     {
          _customer = customer;
          _products = new List<Product>();
     }

     public void AddProduct(Product product)
     {
          _products.Add(product);
     }

     public double CalculateTotalCost()
     {
          double totalCost = 0;
          foreach (var product in _products)
          {
               totalCost += product.GetTotalCost();
          }

          double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
          totalCost += shippingCost;

          return totalCost;
     }

     public string GetPackingLabel()
     {
          string label = "Packing Label:\n";
          foreach (var product in _products)
          {
               label += product.GetProductInfo() + "\n";
          }
          return label;
     }

     public string GetShippingLabel()
     {
          return "Shipping Label:\n" + _customer.GetCustomerInfo();
     }
}