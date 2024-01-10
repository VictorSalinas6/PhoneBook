using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public static class Delete
    {
        public static void DeleteContact(IContact choice)
        {
            var text2 = $"{choice.FirstName} {choice.LastName}";
            Menus.CenterText(text2);
            Console.WriteLine();

            Console.WriteLine("Are you sure that you want to delete this contact? ([Y]es or [N]o)");

            if (UserInput.YesOrNoChecker())
            {
                ListOfContacts.Contacts.Remove(choice);

                Console.WriteLine();
                var text1 = "Contact deleted!";
                Menus.CenterText(text1);
                Thread.Sleep(1000);
                Console.Clear();
            }
            else 
                Console.Clear();
        }
    }
}
