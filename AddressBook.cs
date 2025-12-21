using System;
using System.Collections.Generic;
using System.Linq;


namespace AddressBookSystems
{
    public class AddressBook
    {
        private List<Contact> contacts = new();

        // UC-5 + UC-7
        public bool AddContact(Contact contact)
        {
            if (contacts.Contains(contact))
            {
                Console.WriteLine("Duplicate contact. Not added.");
                return false;
            }

            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.");
            return true;
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }

        public void DisplayAllContacts()
        {
            if (!contacts.Any())
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            Console.WriteLine("\n--- CONTACT LIST ---");
            foreach (var c in contacts)
            {
                Console.WriteLine(c);
            }
        }
    }
}
