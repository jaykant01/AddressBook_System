namespace AddressBook_System;

public class CreateContacts
{
    // Attributes & Fields
    public string FirstName;

    public string LastName;

    public string Email;

    public string City;

    public string State;

    public int Zip;

    public double PhoneNumber;

    public string Address;

    // Constructors
    public CreateContacts(string firstName, string lastName, string email, string city, string state, int zip, double phoneNumber, string Address)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        City = city;
        State = state;
        Zip = zip;
        PhoneNumber = phoneNumber;
        Address = Address;
    }

}
