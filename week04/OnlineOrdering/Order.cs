using System;
using System.Collections.Generic;

public class Order
{
    // a list of Product objects
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();

    public void SetCustomerInfo(string name, string address, string city, string stateProvince, string country)
    {
        // Forward all the information on to Customer
        _customer.SetCustomerInfo(name, address, city, stateProvince, country);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
    // Calculates the total cost of the order, including shipping.
    public double OrderTotal()
    {
        int shippingCost;
        double subTotal = 0.00;
        double orderTotal = 0.00;
        bool isInUSA;

        // Go first through the Customer.cs file
        isInUSA = _customer.IsInUSA();

        if(!isInUSA)
        {
            shippingCost = 35;
        }

        else
        {
            shippingCost = 5;
        }

        // Getting the cost of each product from the Product.cs file
        foreach(Product product in _products)
        {
            subTotal += product.ComputeCost();
        }

        // The total price is calculated as the sum of the subTotal plus a one-time shipping cost
        orderTotal = subTotal + shippingCost;
    
        return orderTotal;
    }
    
    public string GetPackingLabel()
    {
        string label = "";

        foreach(Product product in _products)
        {
            // Method will contain a break in it to separate productName from productId, then another line break at the end
            label += (product.GetProductInfo() + "\n");
        }
        
        return label;
    }

    public string GetShippingLabel()
    {
        // Go first through the Customer.cs file
        return _customer.GetAddress();
    }
}