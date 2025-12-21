using System.Collections.Generic;
using AddressBookSystem.Models;

namespace AddressBookSystem.Services
{
    public class AddressBook
    {
        private List<Contact> contacts = new();

        public void AddContact(Contact contact)
        {
            if (!contacts.Contains(contact))
                contacts.Add(contact);
        }

        public List<Contact> GetContacts() => contacts;

        public void EditContact(string firstName, string city, string email)
        {
            var person = contacts.Find(c => c.FirstName == firstName);
            if (person != null)
            {
                person.City = city;
                person.Email = email;
            }
        }

    }
}
