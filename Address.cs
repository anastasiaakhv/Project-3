using System;
using System.Collections;
using System.Collections.Generic;


//Declaring class - Address that uses IComparable Interface
public class Address : IComparable<Address>
{

    // Auto implemented property - Name
    public string Name { get; set; }
    // Auto implemented property - LastName
    public string LastName { get; set; }
    // Auto implemented property - AddressLineOne
    public string AddressLineOne { get; set; }
    // Auto implemented property - AddressLineTwo
    public string AddressLineTwo { get; set; }
    // Auto implemented property - City
    public string City { get; set; }
    // Auto implemented property - State
    public string State { get; set; }
    // Auto implemented property - Zip
    public string Zip { get; set; }
    // Auto implemented property - Birthday
    public string Birthday { get; set; }
    // Auto implemented property - PhoneNumber
    public string PhoneNumber { get; set; }

    //CompareTo method - parameter object of type Address
    public int CompareTo(Address other)
    {
        // If the objects have the same lastnames compare by their names (firstnames)
        if (this.LastName == other.LastName)
        {
            // If the objects have the same names (firstnames) compare by zipcode
            if (this.Name == other.Name)
            {
                return this.Zip.CompareTo(other.Zip);
            }
            // if the names are different, compare by their names (firstnames)
            else return this.Name.CompareTo(other.Name);
        }
        // if the lastnames are different, compare by their lastnames
        else return this.LastName.CompareTo(other.LastName);

    }

    // Overriding ToString method
    public override string ToString()
    {
        return this.Name + " " + this.LastName + "\n" + this.AddressLineOne + "\n" + this.AddressLineTwo + "\n" + this.City + "," + this.State + " " + this.Zip + "\n" + this.PhoneNumber;
    }

    // Explicit value constructor 
    public Address(string Name, string LastName, string AddressLineOne, string AddressLineTwo, string City, string State, string Zip, string Birthday, string PhoneNumber)
    {
        this.Name = Name;
        this.LastName = LastName;
        this.AddressLineOne = AddressLineOne;
        this.AddressLineTwo = AddressLineTwo;
        this.City = City;
        this.State = State;
        this.Zip = Zip;
        this.Birthday = Birthday;
        this.PhoneNumber = PhoneNumber;
    }

}

class MainClass
{
    public static void Main(string[] args)
    {

        //Driver to test the Address class

        //Declare a list of addresses
        List<Address> myList = new List<Address>();

        // Create six different objects 

        Address One = new Address("Maria", "Voigtmann", "Chavchavadze 5", "Additional info", "Tbilisi", "No state", "0179", "25.12.90", "533 12 34 56");

        Address Two = new Address("Sonya", "Schmidt", "Paliashvili 5", "Additional info", "Tbilisi", "No state", "0179", "27.08.93", "543 11 35 16");

        Address Three = new Address("Anton", "Schmidt", "Abashidze 12", "Additional info", "Tbilisi", "No state", "0179", "29.01.93", "511 01 35 16");

        Address Four = new Address("Anton", "Schmidt", "Abashidze 12", "Additional info", "Tbilisi", "No state", "1179", "29.01.93", "511 01 35 16");

        Address Five = new Address("Anton", "Schmidt", "Abashidze 12", "Additional info", "Tbilisi", "No state", "2179", "29.01.93", "511 01 35 16");

        Address Six = new Address("Anastasia", "Something", "Abashidze 12", "Additional info", "Tbilisi", "No state", "2179", "29.01.93", "511 01 35 16");

        // Add the objects to the list
        myList.Add(One);
        myList.Add(Two);
        myList.Add(Three);
        myList.Add(Four);
        myList.Add(Five);
        myList.Add(Six);

        // Dislpay the list before sorting

        Console.WriteLine("---------- BEFORE SORT ----------\n\n");
        Console.WriteLine("{0}\n\n{1}\n\n{2}\n\n{3}\n\n{4}\n\n{5}", One, Two, Three, Four, Five, Six);

        // Sort the list
        myList.Sort();

        Console.WriteLine("\n---------- AFTER SORT ----------\n\n");

        // Display the list after sorting with the enhanced for loop

        foreach (var member in myList)
        {
            Console.WriteLine(member);
            Console.WriteLine();
        }

    }

}
