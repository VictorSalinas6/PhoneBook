using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public static class Menus
    {
        public static void StartUp()
        {
            var text = "Welcome to your Phone Book App!";
            CenterText(text);
            Console.WriteLine();
            Console.WriteLine("What would you like to do today?");
        }
        public static int Options()
        {
            Console.WriteLine("1. Create a new contact");
            Console.WriteLine("2. Display all contacts");
            Console.WriteLine("3. Update an existing contact");
            Console.WriteLine("4. Delete a contact");
            Console.WriteLine("5. End Application");
            Console.WriteLine();

            var option = Console.ReadLine();
            Console.Clear();

            return UserInput.MenuInput(option);
        }

        public static void Continue()
        {
            Console.WriteLine("Do you wish to do something else?");
        }

        public static void CreateContact()
        {
            Console.Write($"Creating a new contact");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Clear();
        }

        public static void ReadingContacts()
        {
            Console.Write($"Reading your contact database");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Clear();
        }


        public static void FirstCreate()
        {
            Console.WriteLine("Your phone book is empty!");
            Console.WriteLine("Please first create a new user!");
            Console.WriteLine();
        }

        public static void GoodBye()
        {
            string text = "Thank you for using our services. GoodBye!";
            CenterBothText(text);
            Thread.Sleep(1000);

            Environment.Exit(0);
        }

        public static void CenterText(string text)
        {
            int consoleWidth = Console.WindowWidth;

            int padding = (consoleWidth - text.Length) / 2;

            Console.WriteLine(text.PadLeft(padding + text.Length));
        }

        public static void CenterBothText(string text)
        {
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;

            int horizontalPadding = (consoleWidth - text.Length - 6) / 2;
            int verticalPadding = (consoleHeight) / 4;

            Console.SetCursorPosition(horizontalPadding, verticalPadding);
            Console.WriteLine(text);
        }
    }
}
