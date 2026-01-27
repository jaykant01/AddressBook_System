namespace AddressBook_System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program");

        // Dictionary to store multiple Address Books
        Dictionary<string, AddressBook> addressBookDictionary = new Dictionary<string, AddressBook>();

        char choice;

        //Add Multiple Address Books
        do
        {
            Console.WriteLine("Enter Address Book Name:");
            string addressBookName = Console.ReadLine();

            if (!addressBookDictionary.ContainsKey(addressBookName))
            {
                AddressBook addressBook = new AddressBook();
                addressBookDictionary.Add(addressBookName, addressBook);

                Console.WriteLine("Address Book added successfully.");
            }
            else
            {
                Console.WriteLine("Address Book with this name already exists.");
            }

            Console.WriteLine("Do you want to add another Address Book? (y/n)");
            choice = Console.ReadLine()[0];

        } while (choice == 'y' || choice == 'Y');

        // Select Address book To Add Contacts
        Console.WriteLine("Enter Address Book Name to add contacts:");
        string selectedBookName = Console.ReadLine();
        if (addressBookDictionary.ContainsKey(selectedBookName))
        {
            AddressBook addressBook = addressBookDictionary[selectedBookName];

            //Add Multiple Contacts
            do
            {
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

                addressBook.AddContact(person);


                Console.WriteLine("Do you want to add another contact? (y/n)");
                choice = Console.ReadLine()[0];

            } while (choice == 'y' || choice == 'Y');

            //Display Contacts
            addressBook.DisplayContact();

            //Edit Contact
            Console.WriteLine("Enter First Name of the contact to edit:");
            string nameToEdit = Console.ReadLine();

            addressBook.EditContact(nameToEdit);

            //Delete Contact
            Console.WriteLine("Enter First Name of the contact to delete:");
            string nameToDelete = Console.ReadLine();

            addressBook.DeleteContact(nameToDelete);

            // Final Display
            Console.WriteLine("Final Contact List:");
            addressBook.DisplayContact();
        }
        else
        {
            Console.WriteLine("Address Book not found.");
        }


        // SEARCH BY CITY ACROSS ALL ADDRESS BOOKS 
        Console.WriteLine("Enter City to search persons:");
        string searchCity = Console.ReadLine();

        foreach (var entry in addressBookDictionary)
        {
            List<CreateContacts> result = entry.Value.SearchByCity(searchCity);

            foreach (CreateContacts person in result)
            {
                Console.WriteLine("Address Book: " + entry.Key);
                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("City: " + person.City);
                Console.WriteLine("State: " + person.State);
                Console.WriteLine();
            }
        }

        //  SEARCH BY STATE ACROSS ALL ADDRESS BOOKS 
        Console.WriteLine("Enter State to search persons:");
        string searchState = Console.ReadLine();

        foreach (var entry in addressBookDictionary)
        {
            List<CreateContacts> result = entry.Value.SearchByState(searchState);

            foreach (CreateContacts person in result)
            {
                Console.WriteLine("Address Book: " + entry.Key);
                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("City: " + person.City);
                Console.WriteLine("State: " + person.State);
                Console.WriteLine("Zip: " + person.Zip);
                Console.WriteLine("Phone Number: " + person.PhoneNumber);
                Console.WriteLine("Email: " + person.Email);
                Console.WriteLine();
            }
        }

        // VIEW PERSONS BY CITY
        Console.WriteLine("VIEW PERSONS BY CITY");

        foreach (var entry in addressBookDictionary)
        {
            Console.WriteLine("Address Book: " + entry.Key);

            Dictionary<string, List<CreateContacts>> cityMap = entry.Value.ViewByCity();

            foreach (var cityEntry in cityMap)
            {
                Console.WriteLine("City: " + cityEntry.Key);

                entry.Value.DisplayContacts(cityEntry.Value);
            }
        }

        //VIEW PERSONS BY STATE
        Console.WriteLine("VIEW PERSONS BY STATE");

        foreach (var entry in addressBookDictionary)
        {
            Console.WriteLine("Address Book: " + entry.Key);

            Dictionary<string, List<CreateContacts>> stateMap = entry.Value.ViewByState();

            foreach (var stateEntry in stateMap)
            {
                Console.WriteLine("State: " + stateEntry.Key);

                entry.Value.DisplayContacts(stateEntry.Value);
            }
        }

        // Count by city
        Console.WriteLine("COUNT PERSONS BY CITY");

        foreach (var entry in addressBookDictionary)
        {
            Console.WriteLine("Address Book: " + entry.Key);

            Dictionary<string, int> cityCountMap = entry.Value.CountByCity();

            foreach (var cityEntry in cityCountMap)
            {
                Console.WriteLine("City: " + cityEntry.Key + " | Count: " + cityEntry.Value);
            }

            Console.WriteLine();
        }

        // Count by State
        Console.WriteLine("COUNT PERSONS BY STATE");

        foreach (var entry in addressBookDictionary)
        {
            Console.WriteLine("Address Book: " + entry.Key);

            Dictionary<string, int> stateCountMap = entry.Value.CountByState();

            foreach (var stateEntry in stateCountMap)
            {
                Console.WriteLine("State: " + stateEntry.Key + " | Count: " + stateEntry.Value);
            }

            Console.WriteLine();
        }



        Console.ReadKey();
    }
}
