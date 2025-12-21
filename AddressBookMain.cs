using AddressBookSystem.Models;
using AddressBookSystem.Services;
using System;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        static void Main()
        {
            Contact contact = new Contact();
            contact.FirstName = "Sinchana";
            contact.LastName = "A N";
            contact.Address = "Anuvanahalli";
            contact.City = "Ajjampura";
            contact.State = "Karnataka";
            contact.Zip = "577549";
            contact.Email = "sin@gmail.com";
            contact.Phone = "2345678911";

            AddressBook addressBook = new AddressBook();    
            addressBook.AddContact(contact);

            addressBook.EditContact("Sinchana", "Chikkamanglore","sinchana123@gmail.com");

            List<Contact> c = addressBook.GetContacts();

            foreach (var person in c)
            {
                Console.WriteLine(person);
            }

        }
    }
}
