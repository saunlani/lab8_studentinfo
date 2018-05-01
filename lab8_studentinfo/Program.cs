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
            string[] Students = { "Joeseph", "Sean", "Stephen", "Drew", "Marco","Bruce", "Chris",
                        "Dorian","Edward","Frank","Greg","Henry","Illya","Jim","Kendall","Lou","Mary",
                        "Nancy","Othello","Paul" };
            string[] Hometowns = { "Detroit, MI", "St. Clair Shores, MI", "Los Angeles, CA",
                        "Roseville, MI", "Rome, Italy","Belleville, MI", "Chicago, IL", "Denver, CO",
                        "Edmonton, Canada", "Frankenmuth, MI", "Gary, IN", "Hamburg, Germany",
                        "Indianapolis, IN", "Jerusalem, Israel", "Kano, Nigeria", "La Trinidad, Nigeria",
                        "Madison Heights, MI", "Nunapitchuk, Alaska", "Oakland, CA", "Pa Ju, South Korea"};
            string[] FavFoods = { "Passion Fruit", "Hamburgers", "Tacos", "Pizza", "Lasagna","Soup",
                        "Pizza","Chicken Schwarma","Pad Thai","Hot Dogs","Apples","Potatoes","Drunken Noodle","Chips","Salad",
                        "Sandwiches","Bibimbap","Chicken Vindaloo","Lamb Korma","Jinga Masala"};


            Console.WriteLine("Welcome to our C# class! Which student would you like to learn more about?");

            bool RunProgram = true;
            while (RunProgram == true)
            {
                Console.WriteLine("Enter a student number 1-20");

                string userchoice;
                userchoice = Console.ReadLine();
                int studentnum;
                int.TryParse(userchoice, out studentnum);
                studentnum = studentnum - 1;

                if (studentnum < 0 || studentnum >= 20)
                {
                    Console.WriteLine("That student does not exist.  Please try again.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Student {studentnum + 1} is {Students[studentnum]}. What would you like to know about {Students[studentnum]}?");
                    Console.WriteLine("Enter 'hometown' or 'favorite food'.");
                    string infochoice = Console.ReadLine();

                    if (infochoice != "hometown" && infochoice != "favorite food")
                    {
                        Console.WriteLine("That data does not exist.  Please try again.");
                        continue;
                    }

                    else if (infochoice == "hometown")
                    {
                        Console.WriteLine($"{Students[studentnum]} is from {Hometowns[studentnum]}.");
                        RunProgram = GoAgainAsker();
                    }
                    else if (infochoice == "favorite food")

                    {
                        Console.WriteLine($"{Students[studentnum]}'s favorite food is {FavFoods[studentnum]}.");
                        RunProgram = GoAgainAsker();
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
                Console.WriteLine("Bye!");
                return false;
            }
        }


    }
}
