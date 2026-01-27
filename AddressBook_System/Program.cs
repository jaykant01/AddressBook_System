namespace AddressBook_System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program");
        //Add new Person
        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter Address:");
        string address = Console.ReadLine();

        Console.WriteLine("Enter City:");
        string city = Console.ReadLine();

        Console.WriteLine("Enter State:");
        string state = Console.ReadLine();

        Console.WriteLine("Enter Zip:");
        int zip = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Phone Number:");
        double phoneNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Email:");
        string email = Console.ReadLine();

        CreateContacts person = new CreateContacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
        AddressBook addressBook = new AddressBook();
        addressBook.AddContact(person);
        addressBook.DisplayContact();

        // Edit Contact
        Console.WriteLine("Enter First Name of the contact to edit:");
        string nameToEdit = Console.ReadLine();

        addressBook.EditContact(nameToEdit);
        Console.ReadKey();
    }
}
