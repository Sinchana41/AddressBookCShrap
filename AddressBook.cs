
namespace AddressBookSystems
{
    public class AddressBook
    {
        private List<Contact> contacts = new();

        public void AddContact(Contact contact)
        {
            if (contacts.Contains(contact))   
            {
                Console.WriteLine("Duplicate contact found. Entry not added.\n");
                return;
            }

            contacts.Add(contact);
            Console.WriteLine("Contact added successfully.\n");
        }

        public List<Contact> GetContacts() => contacts;
        public void DisplayAllContacts()
        {
            if (!contacts.Any())
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            Console.WriteLine("\n--- CONTACT LIST ---");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
