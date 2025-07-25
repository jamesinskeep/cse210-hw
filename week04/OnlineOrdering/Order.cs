using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    private decimal _shippingCost
    {
        get
        {
            if (_customer.UsaAddress)
            {
                return 5.00m;
            }
            else
            {
                return 35.00m;
            }
        }
    }
    public decimal TotalPrice
    {
        get
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.TotalCost;
            }
            return total + _shippingCost;
        }
    }

    public string ShippingLabel()
    {
        string shippingString = "";
        shippingString += $"{_customer.Name}\n{_customer.Address.MailingAddress()}";
        return shippingString;
    }

    public string PackingLabel()
    {
        string packingString = "";
        foreach (Product product in _products)
        {
            packingString += $"{product.Name}: {product.ProductId}\n";
        }
        return packingString;
    }
}