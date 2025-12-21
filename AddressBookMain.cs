using AddressBookSystem;
using System;

class AddressBookMain
{
    static void Main()
    {
        AddressBook addressBook = new AddressBook();
        string choice;

        do
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

            addressBook.AddContact(contact);

            Console.Write("Add another contact? (Y/N): ");
            choice = Console.ReadLine();

        } while (choice.Equals("Y", StringComparison.OrdinalIgnoreCase));

        addressBook.DisplayAllContacts();
    }
}
