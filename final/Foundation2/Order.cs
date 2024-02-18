using System.Collections.Generic;

public class Order
{
    public List<Product> Products { get; private set; }
    public Customer Customer { get; private set; }

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.TotalCost();
        }
        return totalCost + (Customer.LivesInUSA() ? 5 : 35);
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (var product in Products)
        {
            label += $"{product.Name} ({product.ProductId})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address}";
    }
}
