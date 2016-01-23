using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day___fortune_teller_program
{
    class Program
    {
        public static bool Restart (string userInput)
        {
            bool breakOut = true;

            if (userInput.ToLower() == "restart")
                {
                breakOut = false;
                }
            return breakOut;
        }

        public static bool Quit (string userInput)
        {
            bool breakOut = true;

            if (userInput.ToLower() == "quit")
            {
                breakOut = false;
            }
            return breakOut;
        }
        public static string Balance(string firstName, string lastName, string firstLetter, string secondLetter, string thirdLetter)
        {
            string balance;
            string[] values = { "$47", "$1000", "$1 billion", "$0" };

            if (firstName.Contains(firstLetter) || lastName.Contains(firstLetter))
            {
                balance = values[0];
            }
            else if (firstName.Contains(secondLetter) || lastName.Contains(secondLetter))
            {
                balance = values[1];
            }
            else if (firstName.Contains(thirdLetter) || lastName.Contains(thirdLetter))
            {
                balance = values[2];
            }
            else
            {
                balance = values[3];
            }

            return balance;
        }
        public static string Location (int siblings)
        {
            string[] possibleLocations = { "The Maldives", "Paris, France", "New York City", "Australia", "a van down by the river" };
            string location;
            if (siblings == 0)
            {
                location = possibleLocations[0];
            }
            else if (siblings == 1)
            {
                location = possibleLocations[1];
            }
            else if (siblings == 2)
            {
                location = possibleLocations[2];
            }
            else if (siblings == 3)
            {
                location = possibleLocations[3];
            }
            else
            {
                location = possibleLocations[4];
            }

            return location;
        }
        public static bool EvenOrOdd (int age)
        {
            bool evenorodd;

            if (age % 2 == 0)
            {
                evenorodd = true;
            }
            else
            {
                evenorodd = false;
            }
            return evenorodd;
        }

        public static string VehicleType (string color)
        {
            string vehicle;
            switch (color.ToLower())
            {
                case "r": //these will catch either a single letter or the color spelled out
                case "red":
                    vehicle = "Corvette";
                    break;
                case "o":
                case "orange":
                    vehicle = "semi truck";
                    break;
                case "y":
                case "yellow":
                    vehicle = "school bus";
                    break;
                case "g":
                case "green":
                    vehicle = "Jeep";
                    break;
                case "b":
                case "blue":
                    vehicle = "station wagon";
                    break;
                case "i":
                case "indigo":
                    vehicle = "4 door sedan";
                    break;
                case "v":
                case "violet":
                    vehicle = "PT Cruiser";
                    break;
                default:
                    vehicle = "minivan";
                    break;
            }

            return vehicle;
        }


        static void Main(string[] args)
        {
            while (true)
            {
                bool doubleBreak = false;
                bool continueBreak = false;
                string connectToPsychic = "wait";

                //Intro
                Console.WriteLine("Welcome to Fortune Teller 9000! \n\nPlease wait while we connect you to a psychic...\n");
                for (int i = 0; i < connectToPsychic.Length; i++)
                {
                    Console.WriteLine("... \n \n");
                    System.Threading.Thread.Sleep(750);
                }
                Console.WriteLine("\aYou are now connected! \n\nPlease answer the following questions: \n");

                //User Inputs

                //first name input
                Console.WriteLine("Enter your first name: ");
                string firstName = Console.ReadLine();
                if (Restart(firstName) == false)
                {
                    continue;
                }
                if (Quit(firstName) == false)
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }

                // last name input
                Console.WriteLine("Enter your last name: ");
                string lastName = Console.ReadLine().ToLower();
                if (Restart(lastName) == false)
                {
                    continue;
                }
                if (Quit(lastName) == false)
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }

                //age input
                Console.WriteLine("Enter your age: ");
                string ageInput = Console.ReadLine().ToLower();
                if (Restart(ageInput) == false)
                {
                    continue;
                }
                if (Quit(ageInput) == false)
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }

                int age;
                bool result = int.TryParse(ageInput, out age);

                while (result == false) //this while loop makes the program keep asking for an integer if one isn't entered
                {
                    Console.WriteLine("Please enter your age as an integer: ");
                    ageInput = Console.ReadLine();
                    result = int.TryParse(ageInput, out age); 
                    if (Restart(ageInput) == false)
                    {
                        continueBreak = true;//assigning true here makes the if statement below continue the outer while loop and restart the program
                        break;
                    }
                    if (Quit(ageInput) == false)
                    {
                        doubleBreak = true; //assigning true here makes the if statement below break the outer while loop and quit the program
                        Console.WriteLine("Nobody likes a quitter...");
                        break;
                    }
                    if (result == true)
                    {
                        break;
                    }
                }

                if (doubleBreak == true)
                {
                    break;
                }
                if (continueBreak == true)
                {
                    continue;
                }

                // birth month input
                Console.WriteLine("Enter your birth month: ");
                string month = Console.ReadLine().ToLower();
                if (Restart(month) == false)
                {
                    continue;
                }
                if (Quit(month) == false)
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                int value;
                bool success = int.TryParse(month, out value);//if the value is able to be parsed because it is an integer, it goes into the switch case so that the color assignment will still work
                if (success == true)
                {
                    switch (value)
                    {
                        case 1:
                            month = "january";
                            break;
                        case 2:
                            month = "february";
                            break;
                        case 3:
                            month = "march";
                            break;
                        case 4:
                            month = "April";
                            break;
                        case 5:
                            month = "may";
                            break;
                        case 6:
                            month = "june";
                            break;
                        case 7:
                            month = "july";
                            break;
                        case 8:
                            month = "august";
                            break;
                        case 9:
                            month = "september";
                            break;
                        case 10:
                            month = "october";
                            break;
                        case 11:
                            month = "november";
                            break;
                        case 12:
                            month = "december";
                            break;
                        default:
                            month = "august";
                            break;
                    }
                }

                //color input
                Console.WriteLine("Enters your favorite ROYGBIV color. If you don't know what ROYGBIV colors are, enter \"help\".");
                string color = Console.ReadLine().ToLower();
                if (Restart(color) == false)
                {
                    continue;
                }
                if (Quit(color) == false)
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    break;
                }
                while (true) //this while loop will keep prompting the user to enter a color after they enter help. help still works within the loop
                { 
                    if (color.Equals("help"))
                    {
                        Console.WriteLine("ROYGBIV colors are the colors of the rainbow. \n R = red\n O = orange\n Y = yellow\n G = green\n B = blue\n I = indigo\n V = violet");
                        Console.WriteLine("Enter your favorite ROYGBIV color: ");
                        color = Console.ReadLine().ToLower();
                        if (Restart(color) == false)
                        {
                            continueBreak = true; //like above, these will go into the later if statement to break/continue the outer loop
                            break;
                        }
                        if (Quit(color) == false)
                        {
                            doubleBreak = true;
                            Console.WriteLine("Nobody likes a quitter...");
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (doubleBreak == true)
                {
                    break;
                }

                if (continueBreak == true)
                {
                    continue;
                }

                //sibling input
                Console.WriteLine("Enter the number of siblings you have: ");
                    string siblingInput = Console.ReadLine(); 
                    if (Restart(siblingInput) == false)
                    {
                        continue;
                    }

                    if (Quit(siblingInput) == false)
                    {
                        Console.WriteLine("Nobody likes a quitter...");
                        break;
                    }

                    int siblings;
                    bool result2 = int.TryParse(siblingInput, out siblings);

                    while (result2 == false) //like the age while loop, this one keeps prompting the user to enter an integer value for the number of sibligns
                    {
                        Console.WriteLine("Please enter an integer for the number of siblings: ");
                        siblingInput = Console.ReadLine();
                        result2 = Int32.TryParse(siblingInput, out siblings);
                        if (Restart(siblingInput) == false)
                        {
                            continueBreak = true;
                            break;
                        }

                        if (Quit(siblingInput) == false)
                        {
                        doubleBreak = true;
                        Console.WriteLine("Nobody likes a quitter...");
                        break;
                        }

                    if (result2 == true)
                        {
                            break;
                        }
                    }
                if (doubleBreak == true)
                {
                    break;
                }
                if (continueBreak == true)
                {
                    continue;
                }

                    //Number of years to Retirement
                    string retirement;
                string[] years = { "1 million years", "100 years", "5 years" };

                if (age == 0)
                {
                    retirement = years[0];
                }
                else
                {
                    if (EvenOrOdd(age) == true)
                    {
                        retirement = years[1];
                    }
                    else
                    {
                        retirement = years[2];
                    }
                }

                    //Siblings
                    string location = Location(siblings);

                    //Determine vehicle based on favorite color
                    string vehicle = VehicleType(color);

                    //Determine bank account balance based on first letter of birth month
                    string firstLetter = month[0].ToString().ToLower();
                    string secondLetter = month[1].ToString().ToLower();
                    string thirdLetter = month[2].ToString().ToLower();

                    string balance = Balance(firstName, lastName, firstLetter, secondLetter, thirdLetter);

                    //Print results
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine("\aProcessing...\n \n \n");
                        System.Threading.Thread.Sleep(1000); //makes the loop pause for 1 second between loops
                    }

                    Console.WriteLine("\aThe future has spoken! \n \n \n"); //beeps when printed

                    Console.WriteLine(String.Concat(firstName, " ", lastName, " will retire in ", retirement, " with ", balance, " in the bank, a vacation home in ", location, " and a ", vehicle, "."));
                    Console.WriteLine();
                    Console.WriteLine("Would you like to try again? Enter \"yes\" to continue or \"quit\" to exit.");
                    string tryAgain = Console.ReadLine().ToLower();

                    if (tryAgain.Equals("restart"))
                    {
                        continue;
                    }

                    if (tryAgain.Equals("yes"))
                    {
                        continue;
                    }

                    if (tryAgain.Equals("quit"))
                    {
                        Console.WriteLine("Nobody likes a quitter...");
                        break;
                    }
                
            }

            



            

                
           


            
        }
    }
}
