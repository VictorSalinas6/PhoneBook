using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public static class UserInput
    {
        public static int MenuInput(string optionString)
        {

            switch (optionString)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                default:
                    Console.WriteLine("Please enter a correct option!");
                    Console.WriteLine();
                    return 0;
            }
        }

        public static int CheckFirst(int choice)
        {
            int answer = choice;
            if (ListOfContacts.Contacts.Count == 0 && choice != 1 && choice != 5 && choice != 0)
            {
                Menus.FirstCreate();
                answer = 1;
            }

            return answer;
        }
        public static string ContactInput()
        {
            var answer = Console.ReadLine().ToLower();

            while (string.IsNullOrEmpty(answer))
            {
                Console.WriteLine("Please check your answer");
                answer = Console.ReadLine().ToLower();
            }

            if (answer.Length > 1)
                answer = char.ToUpper(answer[0]) + answer.Substring(1);
            else
                answer = char.ToUpper(answer[0]).ToString();

            return answer;
        }

        public static string PhoneInput()
        {
            bool check = false;
            var answer = Console.ReadLine();
            do
            {
                check = PhoneChecker(answer);
                if (check)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a correct Phone number!");
                    answer = Console.ReadLine();
                }
            } while (check);

            return answer;
        }

        public static bool PhoneChecker(string phone)
        {
            bool check = false;

            if (string.IsNullOrEmpty(phone))
            {
                Console.WriteLine("You can´t leave the phone number empty");
                check = true;
            }
            else
            {
                foreach (var number in phone)
                {
                    try
                    {
                        var x = int.Parse(number.ToString());
                    }
                    catch (FormatException e)
                    {
                        check = true;
                    }
                }
                if (check == true)
                {
                    Console.WriteLine("The phone number can´t contain non numbers!");
                    return check;
                }
                if (phone.Length != 10)
                {
                    Console.WriteLine("Phone numbers must contain 10 digits!");
                    check = true;
                }
            }
            return check;
        }

        public static string EmailInput()
        {
            bool check = false;
            string answer;

            do
            {
                answer = Console.ReadLine();
                if (string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("You can´t leave the email empty!");
                    Console.WriteLine("Enter a correct email.");
                    check = true;
                }
                else if (!answer.Contains('@'))
                {
                    Console.WriteLine("An email must contain '@'.");
                    Console.WriteLine("Enter a correct email.");
                    check = true;
                }
                else
                {
                    check = false;
                }
            } while (check);

            return answer;
        }

        public static string AddressInput()
        {
            var answer = Console.ReadLine();
            bool check = false;

            do
            {
                if (string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("You can´t leave the Adress empty!");
                    Console.WriteLine("Please enter a correct Address.");
                    check = true;
                    answer = Console.ReadLine();
                }
                else
                    check = false;
            } while (check);

            return answer;
        }

        public static DOB DOBInput()
        {
            string answer;
            DOB answerDOB = new DOB();
            bool retry = false;

            do
            {
                retry = false;
                answer = Console.ReadLine();

                if (string.IsNullOrEmpty(answer))
                {
                    answerDOB.D = "00";
                    answerDOB.M = "00";
                    answerDOB.Y = 0;
                    answerDOB.Age = 0;

                    return answerDOB;
                }

                var date = answer.Split('/');

                if (date.Length == 1)
                {
                    try
                    {
                        var age = int.Parse(date[0]);

                        if (age > 0 && age < 100)
                        {
                            answerDOB.D = "00";
                            answerDOB.M = "00";
                            answerDOB.Y = 0;
                            answerDOB.Age = age;

                            return answerDOB;
                        }
                        else
                        {
                            Console.WriteLine("If you tried to just input their age, please just write a number between 1 and 99");
                            retry = true;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("If you tried to just input their age, please just write a number between 1 and 99");
                        Console.WriteLine("If not, please retry with the format (dd/mm/yyyy)");
                        Console.WriteLine("Or just leave empty if you don´t know their age");
                        retry = true;
                    }
                }
                else if (date.Length == 3)
                {
                    if (DOBChecker(date))
                    {
                        var day = int.Parse(date[0]);
                        var month = int.Parse(date[1]);
                        var year = int.Parse(date[2]);
                        DateTime birthday = new DateTime(year, month, day);
                        var age = CalculateAge(birthday);

                        if (day <= 31 && month <= 12 && year <= DateTime.Now.Year && age < 100)
                        {
                            answerDOB.D = date[0];
                            answerDOB.M = date[1];
                            answerDOB.Y = year;
                            answerDOB.Age = age;

                            return answerDOB;
                        }
                        else
                        {
                            Console.WriteLine($"Something is wrong with the date you inputed (Your input): {date[0]}/{date[1]}/{year}");

                            if (age > 100)
                                Console.WriteLine("The age cannot be over 99");

                            retry = true;
                        }
                    }
                    else
                    {
                        retry = true;
                    }
                }
                else
                {
                    retry = DOBChecker(date);
                }
            } while(retry);
            return answerDOB;
        }

        public static bool DOBChecker(string[] date)
        {
            bool check = true;
            bool letters = false;
            bool something = false;

            foreach (var num in date)
            {
                try
                {
                    var x = int.Parse(num);
                }
                catch (FormatException e)
                {
                    letters = true;
                    check = false;
                }
                catch (Exception e)
                {
                    something = true;
                    check = false;
                }
                finally
                {
                    if (something)
                    {
                        Console.WriteLine("Something went wrong, please try again!");
                        Console.WriteLine("Remember to use the correct format. (dd/mm/yyyy)");
                        Console.WriteLine("(Leave empty if you dont know their day of birth or just write their age)");
                    }
                    else if (letters)
                    {
                        Console.WriteLine("Please just input numbers between '/' in the date of birth. (dd/mm/yyyy)");
                    }

                }
            }

            return check;
        }

        public static int CalculateAge(DateTime birthdate)
        {
            DateTime currentdate = DateTime.Now;

            int age = currentdate.Year - birthdate.Year;

            if (birthdate.Date > currentdate.AddYears(-age))
                {
                age--;
                }

            return age;
        }

        public static int CheckInList()
        {
            string answer ;
            int num = 0;
            bool check = false;

            do
            {
                answer = Console.ReadLine();

                if(answer.ToLower() == "cancel")
                {
                    Console.Clear();
                    PhoneApp.Start();
                }
                try
                {
                    num = int.Parse(answer);
                    check = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter the number of the Id!");
                }

                if (check)
                {
                    if (num > ListOfContacts.Contacts.Count)
                    {
                        Console.WriteLine("Please enter a correct Id");
                        check = false;
                    }
                }
            } while (check == false);

            num--;

            return num;
        }

        public static bool YesOrNoChecker()
        {
            
            bool finalA = true;
            bool check = false;

            do
            {
                var answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "y":
                    case "yes":
                    case "ye":
                        finalA = true;
                        check = false;
                        break;
                    case "n":
                    case "no":
                        finalA = false;
                        check = false;
                        break;
                    default:
                        check = true;
                        Console.WriteLine("Please enter [Y]es or [N]o.");
                        break;
                }
            } while (check);

            return finalA;
        }
    }
}
