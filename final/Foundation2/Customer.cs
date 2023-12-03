using System;
using System.Runtime.CompilerServices;

public class Customer
{
    private string _customerName;
    private Address _address;
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public void GetCustomerName(string customerName){
        _customerName = customerName;
    }
    public bool IsInUSA(){
        return _address.IsInUSA();
    }
    public Address GetAddress()
    {
        return _address;
    }
}