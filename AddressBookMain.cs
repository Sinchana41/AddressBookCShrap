using System;

namespace AddressBookSystems
{
    class AddressBookMain
    {
        static void Main()
        {
            AddressBookSystem system = new AddressBookSystem();

            system.AddAddressBook("Personal");
            system.AddAddressBook("Office");

            AddressBook personalBook = system.GetAddressBook("Personal");

            personalBook.AddContact(new Contact
            {
                FirstName = "Seetha",
                LastName = "Ram",
                City = "Bangalore",
                State = "KA"
            });

            Console.WriteLine("Address Books:");
            system.DisplayAllAddressBooks();
        }
    }
}
