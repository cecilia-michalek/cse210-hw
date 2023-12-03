using System;

public class Product
{
    private string _productName;
    private int _productID;
    private float _price;
    private int _quantity;

    public Product(string productName, int productID)
    {
        _productName = productName;
        _productID = productID;
    }
    public string ProductName => _productName;
    public int ProductID => _productID;
    /*public void SetProductName()
    {
        _productName = ProductName;
    }
    public void SetProductID()
    {
        _productID = ProductID;
    }*/
    public void SetPrice(float price)
    {
        _price = price;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public float CalcualateTotalPrice(){
        return _quantity * _price;
    }

}