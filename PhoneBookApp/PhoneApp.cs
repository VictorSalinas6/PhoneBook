using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public static class PhoneApp
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Menus.StartUp();
            var on = true;
            do
            {
                var option = Menus.Options();

                option = UserInput.CheckFirst(option);

                switch (option)
                {
                    case 1:
                        Menus.CreateContact();
                        IContact contacts = new PhoneContacts();
                        contacts = ContactBuilder.contactBuilder(contacts);
                        ListOfContacts.Contacts.Add(contacts);
                        break;
                    case 2:
                        Menus.ReadingContacts();
                        Display.displayContacts();
                        break;
                    case 3:
                        Menus.ReadingContacts();
                        var choiceUpdate = Display.displayforUpdateContact();
                        choiceUpdate = Update.UpdateContact(choiceUpdate);
                        break;
                    case 4:
                        Menus.ReadingContacts();
                        var choiceDelete = Display.displayforDeleteContact();
                        Delete.DeleteContact(choiceDelete);
                        break;
                    case 5:
                        on = false;
                        break;
                    case 0:
                    default:
                        break;
                }
                if (option != 5 && option != 0)
                    Menus.Continue();
            } while (on);

            Console.Clear();
            Menus.GoodBye();
        }
    }
}
