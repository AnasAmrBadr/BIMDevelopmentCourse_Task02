using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_2_String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2

            // 1. Counting Vowels
            // Write a C# program that prompts the user to enter a word or phrase. The program should then count and display the number of vowels (A, E, I, O, U) in the input.
            // Prompt the user to enter a word or phrase.
            // Use string manipulation techniques to count the vowels(both uppercase and lowercase).
            // Display the count of vowels in the input.

            int numberOfVowels = 0;
            string vowelsList = "AEIOU";

            Console.WriteLine("Please, enter a word or phrase below.");

            string userInput = Console.ReadLine();
            userInput.ToUpper();

            foreach (char C in userInput)
            {
                if (vowelsList.Contains(C))
                {
                    numberOfVowels++;
                }

            }

            Console.WriteLine($"the total number of vowels is {numberOfVowels}");
            Console.ReadLine();
            Console.WriteLine("---------------------------------------------------------------------------");


            //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //2. String Splitter
            // Description: Create a C# program that asks the user to enter a comma-separated list of names. The program should split the input string and display each name on a separate line.
            // Prompt the user to enter a comma - separated list of names(e.g., "Ahmed, Ali, Sara").
            // Use string manipulation techniques to split the input and separate the names.
            // Display each name on a separate line but all should be in upper case.

            Console.WriteLine("Please, enter a list of names and seprate each witha comma below.");
            string userNamesList = Console.ReadLine();
            string[] namesList = userNamesList.Split(',');
            foreach (string name in namesList)
            {
                name.ToLower();
                Console.WriteLine(name);
            }

        }
    }
}
