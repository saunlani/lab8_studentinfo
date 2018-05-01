using System;
using System.Text.RegularExpressions;

namespace lab8_studentinfo
{
    class Program
    {
        /*Program will recognize valid inputs when the user requests information
         * about students in class.
         * 
         * provides information about students in a class.
         * prompt the user to ask about a particular student.
         * give proper responses according to user submitted information.
         * ask user if they would like to learn about another student.
         * 
         * input validation with exceptions
         * incorporate IndexOutOfRangeException and FormatException. */

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class! Which student would you like to learn more about?");

            bool RunProgram = true;
            while (RunProgram == true)
            {
                Console.WriteLine("Enter a student number 1-5");

                string userchoice;
                userchoice = Console.ReadLine();
                int studentnum;
                int.TryParse(userchoice, out studentnum);
                studentnum = studentnum - 1;

                if (studentnum < 0 || studentnum >= 5 )
                {
                    Console.WriteLine("That student does not exist.  Please try again.");
                    continue;
                }
                else
                {
                    string[] Students = { "Joeseph", "Sean", "Stephen", "Drew", "Marco" };
                    string[] Hometowns = { "Detroit", "St. Clair Shores", "Los Angeles", "Roseville", "Rome" };
                    string[] FavBands = { "Hiatus Kaiyote", "Protomartyr", "Odesza", "Radiohead", "Tool" };
                    Console.WriteLine($"Student {studentnum + 1} is {Students[studentnum]}. What would you like to know about {Students[studentnum]}?");

                    bool goagain = true;
                    while (goagain == true)
                    {
                        Console.WriteLine("Enter 'hometown' or 'favorite band'.");
                        string infochoice = Console.ReadLine();

                        if (infochoice != "hometown" && infochoice != "favorite band")
                        {
                            Console.WriteLine("That data does not exist.  Please try again.");
                            continue;
                        }
                        else if (infochoice == "hometown")
                        {
                            Console.WriteLine($"{Students[studentnum]} is from {Hometowns[studentnum]}.");

                            Console.WriteLine("Would you like to know more?  Type y for yes or anything else for no.");
                            string input = Console.ReadLine();
                            if (input == "y")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Bye!");
                                goagain = false;
                                RunProgram = false;
                            }

                        }

                        else if (infochoice == "favorite band")
                        {
                            Console.WriteLine($"{Students[studentnum]}'s favorite band is {FavBands[studentnum]}.");

                            Console.WriteLine("Would you like to know more?  Type y for yes or anything else for no.");
                            string input = Console.ReadLine();
                            if (input == "y")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Bye!");
                                goagain = false;
                                RunProgram = false;
                            }
                        }
                    }
                }
            }
 
        }

        static bool GoAgainAsker()
        {
            Console.WriteLine("Would you like to know more?  Type y for yes or anything else for no.");
            string input = Console.ReadLine();
            if (input == "y")
            {
                return true;
            
            }
            else
            {
                return false;
            }
        }


    }
}

