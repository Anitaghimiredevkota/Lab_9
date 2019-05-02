using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int studentNum = 4;
            List<string>studentInfo = new List<string> { "Anita", "Richard", "Sam", "Robin", "Ema", "Sean" };
            List<string> home = new List<string> { "Novi", "Deerborn", "Canton", "Langsing", "New Hudson", "Detroit" };
            List<string> fabFood = new List<string> { "Noodles", "Pizza", "Burger", "Pizza", "Hot Dog", "chickencurry" };
            List<string> fabColor = new List<string> { "Green", "blue", "orange", "yellow", "pink", "red" };
            string repeat;
            bool doAgain = true;

            while (doAgain)
            {
                int userValue = GetStudentNumber();
                try
                {
                    Console.WriteLine($"Student {userValue} is {studentInfo[userValue - 1]}. What would you like to know about {studentInfo[userValue - 1]}?(enter hometown or favorite food or favorite color)");
                    string userChoice = GetFoodHomeTown();
                    
                    switch (userChoice)
                    {
                        case "hometown":
                            Console.WriteLine($"{studentInfo[userValue - 1]}'s hometown is {home[userValue - 1]}, MI. Would you like to know more?(y/n).");
                            break;
                        case "favorite food":
                            Console.WriteLine($"{studentInfo[userValue - 1]}'s favourit food is {fabFood[userValue - 1]}. Would you like to know more?(y/n)");
                            break;
                        case "favorite color":
                            Console.WriteLine($"{studentInfo[userValue -1]}'s favourit color is {fabColor[userValue-1]}. Would you like to know more?(y/n)");
                            break;
                        default:
                            break;
                    }

                    repeat = Console.ReadLine();
                    if (repeat == "n")
                    {
                        Console.WriteLine("Bye see you again!");
                        doAgain = false;
                    }
                    else { }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(@"That student does not exist. Please try again.(enter a number {0} - {1}) :", 1, studentInfo.Count);
                }
            }
        }

        public static int GetStudentNumber()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to our C# class. Which student would you like to hear more about?(enter a number 1-20) :");
                    int.TryParse(Console.ReadLine(), out int userValue);
                    if (userValue >= 1 && userValue <= 20)
                    {
                        return userValue;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That student does not exist. Please try again.(enter a number 1-20) :");
                    return GetStudentNumber();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Source);
                }
            }
        }
        public static string GetFoodHomeTown()
        {
            //Console.WriteLine("hometown or favorite food favorite color");
            string userChoice = Console.ReadLine();

            if (userChoice == "hometown" || userChoice == "favorite food" || userChoice=="favorite color")
            {
                return userChoice;
            }
            else

            {
                Console.WriteLine("That data does not exist.Please try again.(enter hometown or favorite food or favorite color):");
                return GetFoodHomeTown();
            }
        }
    }
}
        
            
        
    


