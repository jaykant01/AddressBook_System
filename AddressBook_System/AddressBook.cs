namespace AddressBook_System;

public class AddressBook
{
    private List<CreateContacts> contacts = new List<CreateContacts>();

    public void AddContact(CreateContacts person)
    {
        contacts.Add(person);
    }

    public void DisplayContact()
    {
        foreach (CreateContacts person in contacts)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Address: " + person.Address);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("Zip: " + person.Zip);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email: " + person.Email);
            Console.WriteLine("-----------------------------");
        }
    }
}
