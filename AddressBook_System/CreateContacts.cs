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

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is CreateContacts))
            return false;

        CreateContacts other = (CreateContacts)obj;

        // Duplicate check based on First Name & Last Name
        return this.FirstName.Equals(other.FirstName) &&
               this.LastName.Equals(other.LastName);
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() + LastName.GetHashCode();
    }

    public override string ToString()
    {
        return "First Name: " + FirstName +
               "\nLast Name: " + LastName +
               "\nAddress: " + Address +
               "\nCity: " + City +
               "\nState: " + State +
               "\nZip: " + Zip +
               "\nPhone Number: " + PhoneNumber +
               "\nEmail: " + Email +
               "\n ";
    }

}
