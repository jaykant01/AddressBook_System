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

                Console.WriteLine("Contact added successfully.");

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

        Console.ReadKey();
    }
}
