using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public static class ContactBuilder
    {
        public static IContact contactBuilder(IContact contacts)
        {
            var text1 = "CONTACT CREATOR";
            Menus.CenterText(text1);
            Console.WriteLine();

            Console.WriteLine("Please enter the contacts first name.");
            contacts.FirstName = UserInput.ContactInput();
            Console.WriteLine();

            Console.WriteLine("Please enter their last name.");
            contacts.LastName = UserInput.ContactInput();
            Console.WriteLine();

            Console.WriteLine("Please enter their telephone number.");
            contacts.PhoneNumber = UserInput.PhoneInput();
            Console.WriteLine();

            Console.WriteLine("Please enter their email address.");
            contacts.Email = UserInput.EmailInput();
            Console.WriteLine();

            Console.WriteLine("Please enter their address.");
            contacts.Address = UserInput.AddressInput();
            Console.WriteLine();

            Console.WriteLine("Please enter their date of birth. (dd/mm/yyyy)");
            Console.WriteLine("(If you don´t know the date of birth leave it empty)");
            Console.WriteLine("(Or if you only know their age, just write that.)");
            contacts.DateOfBirth = UserInput.DOBInput();

            Console.WriteLine();
            Console.WriteLine();
            var text2 = "Contact created!";
            Menus.CenterText(text2);
            Thread.Sleep(1000);
            Console.Clear();

            return contacts;
        }
    }
}
