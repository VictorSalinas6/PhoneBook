using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public static class Update
    {
        public static IContact UpdateContact(IContact contact)
        {
            var update = contact;

            var text2 = $"{contact.FirstName} {contact.LastName}";
            Menus.CenterText(text2);
            Console.WriteLine();

            Console.WriteLine("Do you wish to update the first name? ([Y]es or [N]o)");
            if (UserInput.YesOrNoChecker())
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the new first name");
                update.FirstName = UserInput.ContactInput();
            }
            Console.WriteLine();

            Console.WriteLine("Do you wish to update the last name? ([Y]es or [N]o)");
            if (UserInput.YesOrNoChecker())
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the new last name");
                update.LastName = UserInput.ContactInput();
            }
            Console.WriteLine();

            Console.WriteLine("Do you wish to update their telephone number? ([Y]es or [N]o)");
            if (UserInput.YesOrNoChecker())
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the new number");
                update.PhoneNumber = UserInput.PhoneInput();
            }
            Console.WriteLine();

            Console.WriteLine("Do you wish to update their email address? ([Y]es or [N]o)");
            if (UserInput.YesOrNoChecker())
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the new email");
                update.Email = UserInput.EmailInput();
            }
            Console.WriteLine();

            Console.WriteLine("Do you wish to update their address? ([Y]es or [N]o)");
            if (UserInput.YesOrNoChecker())
            {
                Console.WriteLine();
                Console.WriteLine("Please enter their new address");
                update.Address = UserInput.AddressInput();
            }
            Console.WriteLine();

            Console.WriteLine("Do you wish to update their Date of Birth? ([Y]es or [N]o)");
            if (UserInput.YesOrNoChecker())
            {
                Console.WriteLine();
                Console.WriteLine("Please enter their new Date of Birth");
                Console.WriteLine("(If you don´t know the date of birth leave it empty)");
                Console.WriteLine("(Or if you only know their age, just write that.)");
                update.DateOfBirth = UserInput.DOBInput();
            }

            Console.WriteLine();
            var text1 = "Contact updated!";
            Menus.CenterText(text1);
            Thread.Sleep(1000);
            Console.Clear();

            return update;
        }
    }
}
