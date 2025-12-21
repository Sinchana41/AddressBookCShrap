using System;

namespace AddressBookSystems
{
    class AddressBookMain
    {
        static void Main()
        {
            AddressBook addressBook = new AddressBook();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== ADDRESS BOOK MENU =====");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display All Contacts");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact(addressBook);
                        break;

                    case "2":
                        addressBook.DisplayAllContacts();
                        break;

                    case "3":
                        exit = true;
                        Console.WriteLine("Exiting Address Book...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        
        static void AddContact(AddressBook addressBook)
        {
            Contact contact = new Contact();

            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();

            Console.Write("Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("City: ");
            contact.City = Console.ReadLine();

            Console.Write("State: ");
            contact.State = Console.ReadLine();

            Console.Write("Zip: ");
            contact.Zip = Console.ReadLine();

            Console.Write("Phone: ");
            contact.Phone = Console.ReadLine();

            Console.Write("Email: ");
            contact.Email = Console.ReadLine();

            //  UC-7 duplicate check happens INSIDE AddressBook
            addressBook.AddContact(contact);
        }
    }
}