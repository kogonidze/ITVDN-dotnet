﻿namespace AddressExercise;

public class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index 
    {
        get { return index; }
        set 
        { 
            if (value != "Foo") index = value;
        }
    }

    public string Country 
    { 
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }

    public string ShowInfo()
        => $"Index: {index}, country: {country}, city: {city}," +
        $" street: {street}, house: {house}, apartment: {apartment}";
}
