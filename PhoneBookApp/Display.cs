using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public static class Display
    {

        public static void displayContacts()
        {

            Console.WriteLine("\t\t\t\t Contact List");
            Console.WriteLine("Id\tName\t\t\tAge\tNumber\t\tEmail\t\t\t\tAddress");

            foreach (var contacts in ListOfContacts.Contacts)
            {
                Console.Write($"{contacts.Id}\t");
                Console.Write($"{contacts.FirstName.PadRight(6)} {contacts.LastName.PadRight(6)}\t\t");
                Console.Write($"{contacts.DateOfBirth.Age}\t");
                Console.Write($"{contacts.PhoneNumber}\t");
                Console.Write($"{contacts.Email.PadRight(24)}\t");
                Console.Write($"{contacts.Address}\n");
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to return to Menu");
            Console.ReadLine();
            Console.Clear();
        }

        public static IContact displayforUpdateContact()
        {

            //Console.WriteLine("\t\t\t\t Contact List");
            var text1 = "Contact List";
            Menus.CenterText(text1);
            Console.WriteLine("Id\tName\t\t\tAge\tNumber\t\tEmail\t\t\t\tAddress");

            foreach (var contacts in ListOfContacts.Contacts)
            {
                Console.Write($"{contacts.Id}\t");
                Console.Write($"{contacts.FirstName.PadRight(6)} {contacts.LastName.PadRight(6)}\t\t");
                Console.Write($"{contacts.DateOfBirth.Age}\t");
                Console.Write($"{contacts.PhoneNumber}\t");
                Console.Write($"{contacts.Email.PadRight(24)}\t");
                Console.Write($"{contacts.Address}\n");
            }

            Console.WriteLine();
            Console.WriteLine("Please select the Id of the contact you wish to change.");
            Console.WriteLine("Type \"Cancel\" if you wish to cancel this operation");
            var choice = UserInput.CheckInList();
            Console.Clear();

            return ListOfContacts.Contacts[choice];
        }

        public static IContact displayforDeleteContact()
        {

            Console.WriteLine("\t\t\t\t Contact List");
            Console.WriteLine("Id\tName\t\t\tAge\tNumber\t\tEmail\t\t\t\tAddress");

            foreach (var contacts in ListOfContacts.Contacts)
            {
                Console.Write($"{contacts.Id}\t");
                Console.Write($"{contacts.FirstName.PadRight(6)} {contacts.LastName.PadRight(6)}\t\t");
                Console.Write($"{contacts.DateOfBirth.Age}\t");
                Console.Write($"{contacts.PhoneNumber}\t");
                Console.Write($"{contacts.Email.PadRight(24)}\t");
                Console.Write($"{contacts.Address}\n");
            }

            Console.WriteLine();
            Console.WriteLine("Please select the Id of the contact you wish to delete.");
            Console.WriteLine("Type \"Cancel\" if you wish to cancel this operation");
            var choice = UserInput.CheckInList();
            Console.Clear();

            return ListOfContacts.Contacts[choice];
        }
    }
}
