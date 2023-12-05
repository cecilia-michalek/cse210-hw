using System;

public class Customer
{
    private string _customerName;
    private Address _address;
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string CustomerName
    {
        get {return _customerName;}
        set {_customerName = value;}
    }
    public bool IsInUSA(){
        return _address.IsInUSA();
    }
    public Address GetAddress()
    {
        return _address;
    }
}