using AddressBookSystem.Models;
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

            Console.WriteLine(contact);

        }
    }
}
