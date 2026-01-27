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

    // View Persons By City
    public Dictionary<string, List<CreateContacts>> ViewByCity()
    {
        Dictionary<string, List<CreateContacts>> cityDictionary = new Dictionary<string, List<CreateContacts>>();

        foreach (CreateContacts person in contacts)
        {
            if (!cityDictionary.ContainsKey(person.City))
            {
                cityDictionary.Add(person.City, new List<CreateContacts>());
            }

            cityDictionary[person.City].Add(person);
        }

        return cityDictionary;
    }

    //View Persons By State
    public Dictionary<string, List<CreateContacts>> ViewByState()
    {
        Dictionary<string, List<CreateContacts>> stateDictionary = new Dictionary<string, List<CreateContacts>>();

        foreach (CreateContacts person in contacts)
        {
            if (!stateDictionary.ContainsKey(person.State))
            {
                stateDictionary.Add(person.State, new List<CreateContacts>());
            }

            stateDictionary[person.State].Add(person);
        }

        return stateDictionary;
    }

    // Display
    public void DisplayContacts(List<CreateContacts> persons)
    {
        foreach (CreateContacts person in persons)
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

    // Count by City
    public Dictionary<string, int> CountByCity()
    {
        Dictionary<string, int> cityCount = new Dictionary<string, int>();

        foreach (CreateContacts person in contacts)
        {
            if (!cityCount.ContainsKey(person.City))
            {
                cityCount.Add(person.City, 1);
            }
            else
            {
                cityCount[person.City]++;
            }
        }

        return cityCount;
    }

    // Count by State
    public Dictionary<string, int> CountByState()
    {
        Dictionary<string, int> stateCount = new Dictionary<string, int>();

        foreach (CreateContacts person in contacts)
        {
            if (!stateCount.ContainsKey(person.State))
            {
                stateCount.Add(person.State, 1);
            }
            else
            {
                stateCount[person.State]++;
            }
        }

        return stateCount;
    }

}
