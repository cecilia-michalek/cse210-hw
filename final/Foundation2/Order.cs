using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;

    }

    public float CalcualateTotalCost()
    {
        float totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost += product.CalcualateTotalPrice();
        }
        totalCost += _customer.IsInUSA()? 5: 35;
        return totalCost;
    }
    public string GetPackingLable()
    {
        string _packingLabel = "Packing Lable: \n";
        foreach (Product product in _products)
        {
            _packingLabel += $" {product.ProductName}, Product ID: {product.ProductID}\n";
        }
        return _packingLabel;

    }
    public string GetShippingLable()
    {
        string _shippingLable = "Shipping Label:\n";
        _shippingLable += $" Customer Name: {_customer.CustomerName}\n";
        _shippingLable += $" Address: {_customer.GetAddress().GetFullAddress()}";
        return _shippingLable;

    }

    public void AddProduct(Product product)
    {
        _products.Add(product);

    }
}