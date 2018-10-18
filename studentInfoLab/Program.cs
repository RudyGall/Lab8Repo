using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentInfoLab
{
    class Program
        {

            class Info
        {
            public static void StudentInfo(string userInputString)
            {
                int userInput = int.Parse(userInputString) - 1;
                string[,] studentInfo = new string[19, 3]
                {
                {"Andrea","Lansing","Apples" },
                {"Anthony","Ann Arbor","Fries" },
                {"Brian","Kalamazoo","Cereal" },
                {"Camille","Southfield","Salmon" },
                {"Clayton","Pontiac","Chips" },
                {"Damacious","Bloomfield","Ravioli" },
                {"David","Ypsilanti","Wheat Thins" },
                {"Evan","Troy","Ham" },
                {"Heather","Grand Haven","Bread" },
                {"Jacky","Detroit, MI","Sushi" },
                {"Johnathan","Belleville","Stir-fry" },
                {"Katie","WoodHaven, MI","Lasagna" },
                {"Levi","Detroit","Steak" },
                {"Mauricio","Warren","Ice Cream" },
                {"Nicholas","Ferndale","Salad" },
                {"Rudy","Canton","Cheese" },
                {"SeanO","Oak Park","Beans" },
                {"Steve","Toledo","Pizza" },
                {"Ty","Clarkston","Pasta" },
                };
                Console.WriteLine(studentInfo[userInput, 0]);
                Console.WriteLine("Would you like to know their favorite food or their hometown?");
                for (int j = 0; j == 0;)
                {
                    string pickInfo = Console.ReadLine().ToLower();
                    if (pickInfo == "hometown")
                    {
                        Console.WriteLine(studentInfo[userInput, 1]);
                        j++;
                    }
                    else if (pickInfo == "favorite food")
                    {
                        Console.WriteLine(studentInfo[userInput, 2]);
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry, please type out hometown or favorite food");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i == 0;)
            {
                Console.WriteLine("Please enter a number between 1-19");
                string userInputString = Console.ReadLine();
                try
                {
                    Info.StudentInfo(userInputString);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is out of range exception");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect format exception");
                }
                Console.WriteLine("Would you like to learn about another student? (Y or N)");
                string another = Console.ReadLine().ToLower();
                for (int j = 0; j == 0;)
                {
                    if (another == "n")
                    {
                        i++;
                        j++;
                    }
                    else if (another == "y")
                    {
                        j++;
                    }
                    else if (another != "n" && another != "y")
                    {
                        Console.WriteLine("Invalid entry try again");
                        another = Console.ReadLine().ToLower();
                    }
                }
            }
        }
    }
}