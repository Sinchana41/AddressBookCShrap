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

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== ADDRESS BOOK MENU =====");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Display All Contacts (Personal)");
                Console.WriteLine("3. Search by City/State");
                Console.WriteLine("4. View by City");
                Console.WriteLine("5. View by State");
                Console.WriteLine("6. Count by City");
                Console.WriteLine("7. Count by State");
                Console.WriteLine("8. Exit");
                Console.Write("Choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Contact c = ReadContact();
                        Console.Write("Enter AddressBook name: ");
                        system.AddContact(Console.ReadLine(), c);
                        break;

                    case "2":
                        Console.WriteLine("Personal Address Book:");
                        break;

                    case "3":
                        Console.Write("Enter City or State: ");
                        var results = system.SearchByCityOrState(Console.ReadLine());
                        results.ForEach(Console.WriteLine);
                        break;

                    case "4":
                        Console.Write("Enter City: ");
                        system.ViewPersonsByCity(Console.ReadLine());
                        break;

                    case "5":
                        Console.Write("Enter State: ");
                        system.ViewPersonsByState(Console.ReadLine());
                        break;
                    case "6":
                        Console.Write("Enter City: ");
                        Console.WriteLine("Count = " +
                            system.GetCountByCity(Console.ReadLine()));
                        break;

                    case "7":
                        Console.Write("Enter State: ");
                        Console.WriteLine("Count = " +
                            system.GetCountByState(Console.ReadLine()));
                        break;
                    case "8":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static Contact ReadContact()
        {
            Contact c = new Contact();

            Console.Write("First Name: "); 
            c.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            c.LastName  = Console.ReadLine();
            Console.Write("Address: ");
            c.Address   = Console.ReadLine();
            Console.Write("City: ");
            c.City      = Console.ReadLine();
            Console.Write("State: ");
            c.State     = Console.ReadLine();
            Console.Write("Zip: ");
            c.Zip       = Console.ReadLine();
            Console.Write("Phone: ");
            c.Phone     = Console.ReadLine();
            Console.Write("Email: ");
            c.Email     = Console.ReadLine();

            return c;
        }
    }
}