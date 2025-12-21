using System.Collections.Generic;

namespace AddressBookSystem
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

        public void DisplayAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
