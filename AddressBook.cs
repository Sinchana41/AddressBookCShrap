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
    }
}
