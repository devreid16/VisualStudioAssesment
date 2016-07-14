using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

/////////////////////////////////////////Part One: The Basics

//1.Declare and initialize 5 different types. Int, Boolean, String, Double, Decimal

int years = 5;
T = true;
name = "Angie";
double price = 10.87;
decimal d = 8.9m;

//2.Write a function that takes two of your variables from #1 and 
//combines two or more of them into a string. For instance: I have been happily 
//married to Esther for 14 years.

void SaySomething(string name, int years)
{
    //3. print to console
    Console.WriteLine($"{name} lived there, { years} months.");
}

var name = "Angie";
int years = 5;
SaySomething(name, years);

//4. Create an array of strings, a simple array of 3-5 names of your closest friends 
//or family will suffice.

var family =
new List<string>
{
        "Tony",
        "Justin",
        "Sydney",
        "Tandy"
};
//5. Loop over array and print to console
for (var x = 0; x < family.Count; x++)
{
    var name = family[x];
    Console.WriteLine($"Family member: {name}");
};

///////////////////////////////////////////Part Two: OOP
//
//1. Create a class called Customer. The class should have three properties: 
//Name, Gender, and Purchase. You should also create an Enum called Gender. 
//The 0 spot should be Unknown, the 1 spot should be Male, and the 2 spot should be Female.

public enum Gender
{
    Unknown,
    Male,
    Female
};
/// <summary>
/// 
/// Problems start here*************
/// </summary>

public class Customer
{
    private string _name;
    private string _purchase;
    private Gender _gender;

    //2.Create a constructor for the Customer class that allows you to more easily create Customer objects. 
    //The constructor should have parameters for name, gender, and purchase. 

    public Customer(string name, string purchase, Gender gender)
    {
        Name = name;
        Purchase = purchase;
        Gender = gender;
        Product = product;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Purchase
    {
        get { return _purchase; }
        set { _purchase = value; }
    }

    public string Product
    {
        get { return _product; }
        set { _product = value; }
    }

    public Gender Gender
    {
        get { return _gender; }
        set { _gender = value; }
    }
        
    public void SayThanks()
    {
        Console.WriteLine($"Hello, {Name} Thank you for purchasing the {Product}. We hope you enjoy!");
    }
    //4.
    public void SendSaleNotice(DateTime SaleDate)
    {
        Console.WriteLine($"Hello, {Name} we have a sale coming up on {SaleDate}!");
    }
    public void SendSaleNotice(string SaleProduct, DateTime SaleDate)
    {
        Console.WriteLine($"Hello, {Name} we have a sale on {SaleProduct} coming up on {SaleDate}!");
    }

    //.5

    //9
    public virtual string PrintCustomerInfo()
    {
        return $"{Name}, {Purchase}, {Gender}";

    }       
}

//10.
public enum Inactive
{
    Moved,
    Unhappy,
    Prices
}

sealed public class InactiveCustomer : Customer
{
    private int _monthsInactive = 3;
    private string _inactive = Inactive ; //11.

 //6.
    public InactiveCustomer(string name, string purchase, string product, Gender gender, Inactive inactive)
    : base(name, product, purchase, gender)
 //7.
    {
        if (_monthsInactive <=4)
        {
            Console.WriteLine($"Hello, {Name} You purchased {Product}, { _monthsInactive} ago.  Would you like to take a look at some current deals?");
        }

    }
    //12.
    public virtual string PrintCustomerInfo()
    {
        return $"{Name}, {Product} {Purchase}, {Gender}, { _monthsInactive}, {_inactive} ";

    }


}








