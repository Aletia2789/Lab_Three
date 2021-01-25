using System;

namespace Lab_Three
{
    class Program
    {
        static void Main(string[] args)
        {   var answer = "y";
            Console.Write("Welcome to Fun with Intergers! \nPlease enter your name: ");
            string name = Console.ReadLine();

            do
            {
                Console.Write("Please enter a number between 1 and 100: ");
                string userinput = Console.ReadLine();
                int usernumber = int.Parse(userinput);

                while (usernumber < 1 || usernumber > 100)
                {
                    if (usernumber < 1 || usernumber > 100)
                    {
                        Console.Write("Entry Invalid. \nPlease enter a number between 1 and 100: ");
                        string answer1 = Console.ReadLine();
                        usernumber = int.Parse(answer1);
                    }

                }

                if (usernumber % 2 != 0)
                {
                    Console.WriteLine(name + " the number " + usernumber + " is: Odd");
                }
                else if (usernumber % 2 == 0 && usernumber >= 2 && usernumber <= 25)
                {
                    Console.WriteLine(name + " your number is even and Less than 25");
                }
                else if (usernumber % 2 == 0 && usernumber >= 26 && usernumber <= 60)
                {
                    Console.WriteLine(name + " your number is even");
                }
                else if (usernumber % 2 == 0 && usernumber > 60)
                {
                    Console.WriteLine(name + " your number is even");
                }
                else if (usernumber % 2 != 0 && usernumber > 60)
                {
                    Console.WriteLine(name + usernumber + " is: Odd");
                }

                Console.WriteLine(name + " would you like to continue (y/n)?");
               answer = Console.ReadLine();

            } while (answer == "y");

            if (answer == "n")
            {
                Console.WriteLine(name + " thank you for playing! Goodbye!");    
            }

        }
    }
}
 