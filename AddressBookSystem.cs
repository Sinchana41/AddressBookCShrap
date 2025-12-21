namespace AddressBookSystems
{
    public class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
        }

        public void AddAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book already exists.");
                return;
            }

            addressBooks.Add(name, new AddressBook());
            Console.WriteLine($"Address Book '{name}' created successfully.");
        }

        public AddressBook GetAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
                return addressBooks[name];

            Console.WriteLine("Address Book not found.");
            return null;
        }

        public void DisplayAllAddressBooks()
        {
            foreach (var book in addressBooks.Keys)
            {
                Console.WriteLine(book);
            }
        }
        //  UC-8 
        public List<Contact> SearchByCityOrState(string location)
        {
            return addressBooks.Values
                .SelectMany(book => book.GetContacts()) 
                .Where(c => c.City.Equals(location, StringComparison.OrdinalIgnoreCase)
                         || c.State.Equals(location, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
