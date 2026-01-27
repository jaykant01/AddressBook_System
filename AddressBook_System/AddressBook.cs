namespace AddressBook_System;

public class AddressBook
{
    private List<CreateContacts> contacts = new List<CreateContacts>();

    public void AddContact(CreateContacts person)
    {
        if (contacts.Contains(person))
        {
            Console.WriteLine("Duplicate entry found. Contact already exists.");
        }
        else
        {
            contacts.Add(person);
            Console.WriteLine("Contact added successfully.");
        }
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
            Console.WriteLine();
        }
    }

    // Edit Contact
    public void EditContact(string firstName)
    {
        CreateContacts personToEdit = null;

        // Search contact by first name
        foreach (CreateContacts person in contacts)
        {
            if (person.FirstName.Equals(firstName))
            {
                personToEdit = person;
                break;
            }
        }

        if (personToEdit != null)
        {
            Console.WriteLine("Enter new details:");

            Console.WriteLine("Enter Last Name:");
            personToEdit.LastName = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            personToEdit.Address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            personToEdit.City = Console.ReadLine();

            Console.WriteLine("Enter State:");
            personToEdit.State = Console.ReadLine();

            Console.WriteLine("Enter Zip:");
            personToEdit.Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number:");
            personToEdit.PhoneNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Email:");
            personToEdit.Email = Console.ReadLine();

            Console.WriteLine("Contact updated successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    //Delete Contact
    public void DeleteContact(string firstName)
    {
        CreateContacts personToDelete = null;

        // Search contact by first name
        foreach (CreateContacts person in contacts)
        {
            if (person.FirstName.Equals(firstName))
            {
                personToDelete = person;
                break;
            }
        }

        if (personToDelete != null)
        {
            contacts.Remove(personToDelete);
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    //Search
    public List<CreateContacts> SearchByCity(string city)
    {
        List<CreateContacts> result = new List<CreateContacts>();

        foreach (CreateContacts person in contacts)
        {
            if (person.City == city)
            {
                result.Add(person);
            }
        }

        return result;
    }

    public List<CreateContacts> SearchByState(string state)
    {
        List<CreateContacts> result = new List<CreateContacts>();

        foreach (CreateContacts person in contacts)
        {
            if (person.State == state)
            {
                result.Add(person);
            }
        }

        return result;
    }


}
