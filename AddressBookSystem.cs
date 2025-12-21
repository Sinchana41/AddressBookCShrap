using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookSystems
{
    public class AddressBookSystem
    {
        // UC-6
        private Dictionary<string, AddressBook> addressBooks = new();

        // UC-9
        private Dictionary<string, List<Contact>> cityMap = new();
        private Dictionary<string, List<Contact>> stateMap = new();

        public void AddAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine(" Address Book already exists.");
                return;
            }

            addressBooks.Add(name, new AddressBook());
            Console.WriteLine($" Address Book '{name}' created.");
        }

        public void AddContact(string bookName, Contact contact)
        {
            if (!addressBooks.ContainsKey(bookName))
            {
                Console.WriteLine(" Address Book not found.");
                return;
            }

            bool added = addressBooks[bookName].AddContact(contact);

            if (added)
            {
                AddToCityMap(contact);
                AddToStateMap(contact);
            }
        }

        // UC-8
        public List<Contact> SearchByCityOrState(string value)
        {
            return addressBooks.Values
                .SelectMany(book => book.GetContacts())
                .Where(c =>
                    c.City.Equals(value, StringComparison.OrdinalIgnoreCase) ||
                    c.State.Equals(value, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // UC-9
        private void AddToCityMap(Contact contact)
        {
            string city = contact.City.ToLower();

            if (!cityMap.ContainsKey(city))
                cityMap[city] = new List<Contact>();

            cityMap[city].Add(contact);
        }

        private void AddToStateMap(Contact contact)
        {
            string state = contact.State.ToLower();

            if (!stateMap.ContainsKey(state))
                stateMap[state] = new List<Contact>();

            stateMap[state].Add(contact);
        }

        public void ViewPersonsByCity(string city)
        {
            city = city.ToLower();

            if (!cityMap.ContainsKey(city))
            {
                Console.WriteLine("No persons found in this city.");
                return;
            }

            Console.WriteLine($"\n--- Persons in City: {city} ---");
            foreach (var p in cityMap[city])
                Console.WriteLine(p);
        }

        public void ViewPersonsByState(string state)
        {
            state = state.ToLower();

            if (!stateMap.ContainsKey(state))
            {
                Console.WriteLine("No persons found in this state.");
                return;
            }

            Console.WriteLine($"\n--- Persons in State: {state} ---");
            foreach (var p in stateMap[state])
                Console.WriteLine(p);
        }
    }
}
