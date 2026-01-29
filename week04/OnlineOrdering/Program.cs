using System;

class Program
{
    static void Main(string[] args)
    {
        // Two Order objects are created
        Order order1 = new Order();
        Order order2 = new Order();

        double finalTotal = 0.00;

        // First Order
        string name1 = "Alvin F. Meredith";

        // 3 products for order1
        string productName1 = "18 Piece - 4 Person Travel Picnic/Outdoor Wallet";
        int productId1 = 710609134;
        double price1 = 32.49;
        int quantity1 = 2;

        string productName2 = "Solar Lighthouse with Rotating Lamp 11 inch";
        int productId2 = 887521121;
        double price2 = 14.99;
        int quantity2 = 1;

        string productName3 = "Galvanized Metal and Glass Dome Server";
        int productId3 = 830376835;
        double price3 = 34.99;
        int quantity3 = 8;

        // Address for order1
        string address1 = "525 S Center St";
        string city1 = "Rexburg";
        string stateProvince1 = "ID";
        string country1 = "USA";

        order1.SetCustomerInfo(name1, address1, city1, stateProvince1, country1);

        // A Product object that will get changed with every new product
        Product tempProduct1 = new Product();

        tempProduct1.SetProductInfo(productName1, productId1, price1, quantity1);
        // Add 1st product of order1 to the _products list
        order1.AddProduct(tempProduct1);

        tempProduct1 = new Product();
        tempProduct1.SetProductInfo(productName2, productId2, price2, quantity2);
        // Add 2nd product of order1 to the _products list
        order1.AddProduct(tempProduct1);

        tempProduct1 = new Product();
        tempProduct1.SetProductInfo(productName3, productId3, price3, quantity3);
        // Add 3rd product of order1 to the _products list
        order1.AddProduct(tempProduct1);

        // Tally up all the orders for the finalTotal amount from the Order.cs file
        finalTotal = order1.OrderTotal();

        Console.WriteLine("");
        Console.WriteLine("     Online Ordering Program");
        Console.WriteLine("");

        
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("          Order #1");
        Console.WriteLine("");

        //A packing label
        Console.WriteLine("    Packing Label:");
        Console.Write(order1.GetPackingLabel());

        // Total price of the order
        Console.WriteLine($"Total: ${finalTotal}");
        Console.WriteLine("");
        Console.WriteLine("                       --------------------");

        // A shipping label lists the name and address of the customer
        Console.WriteLine("");
        Console.WriteLine("    Shipping Label:");
        Console.WriteLine("");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("");

        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("------------------------------------------------------------------");

        // Second Order
        string name2 = "Cameron L. Olson";

        // 2 products for order2
        string productName4 = "Inflatable Floating Pool Toy, Hoop & Ball";
        int productId4 = 686499953;
        double price4 = 17.99;
        int quantity4 = 3;

        string productName5 = "Chilled Condiment Server with 5 Removable Containers";
        int productId5 =  487230452;
        double price5 = 26.99;
        int quantity5 = 6;

        // Address for order2
        string address2 = "14335 53rd Ave NW";
        string city2 = "Edmonton";
        string stateProvince2 = "Alberta";
        string country2 = "Canada";

        order2.SetCustomerInfo(name2, address2, city2, stateProvince2, country2);

        // A Product object that will get changed with every new product
        Product tempProduct2 = new Product();

        tempProduct2.SetProductInfo(productName4, productId4, price4, quantity4);
        // Add 1st product of order2 to the _products list
        order2.AddProduct(tempProduct2);

        tempProduct2 = new Product();
        tempProduct2.SetProductInfo(productName5, productId5, price5, quantity5);
        // Add 2nd product of order2 to the _products list
        order2.AddProduct(tempProduct2);

        // Tally up all the orders for the finalTotal amount from the Order.cs file
        finalTotal = order2.OrderTotal();

        Console.WriteLine("");
        Console.WriteLine("          Order #2");
        Console.WriteLine("");

        //A packing label
        Console.WriteLine("    Packing Label:");
        Console.Write(order2.GetPackingLabel());

        // Total price of the order
        Console.WriteLine($"Total: ${finalTotal}");
        Console.WriteLine("");
        Console.WriteLine("                       --------------------");

        // A shipping label lists the name and address of the customer
        Console.WriteLine("");
        Console.WriteLine("    Shipping Label:");
        Console.WriteLine("");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");       

        // For each order, the program calculates and displays the total cost. The program also calls methods to get packing and shipping labels and displays the results of these labels containing all required information.


        // Make sure that all getters, setters, and constructors are created as needed.
    }
}