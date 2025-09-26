using System.Net.Security;
using System.Text;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void RemoveProduct(int productId)
    {
        // Start at the end and move toward zero
        for (int i = _products.Count - 1; i >= 0; i--)
        {
            if (_products[i].GetProdcutId() == productId)
            {
                _products.RemoveAt(i);
            }
        }
    }

    public List<Product> GetProdcuts()
    {
        return new List<Product>(_products);
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public decimal GetShippingCost()
    {
        if (_customer.LivesInUSA() == true)
        {
            return 5m;
        }
        return 35m;
    }

    public decimal GetProductsTotal()
    {
        decimal total = 0m;
        foreach (var product in _products)
        {
            total += product.GetPricePerUnity();
        }
        return total;
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = GetProductsTotal() + GetShippingCost();
        return totalCost;
    }

    public string GetPackingLabel()
    {
        var label = new StringBuilder();
        foreach (var p in _products)
        {
            label.AppendLine($"{p.GetName()} (ID: {p.GetProdcutId()})");
        }
        return label.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        var addr = _customer.GetAddress();
        var label = new StringBuilder();
        label.AppendLine(_customer.GetName());
        label.AppendLine(addr.GetStreet());
        label.AppendLine($"{addr.GetCity()}, {addr.GetStateOrProvince()}");
        label.AppendLine(addr.GetCountry());
        return label.ToString().TrimEnd();
    }
}
