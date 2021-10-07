using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step256_ConsoleAppSixPartsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // PART ONE
            Console.WriteLine("PART ONE");
            // 1. A one-dimensional array of strings.
            string[] stringArray = { "Hello", "Hi", "Hey", "Hi-yah", "How'dy" };

            // 2. Ask the user to input some text.
            Console.WriteLine("Please input some text to be appended to our strings in the array of strings.");
            string userInput = Console.ReadLine();

            // 3. A loop that iterates through each string in the array and adds the user's text input to the end of each string.
            //      This step will not output anything to the console, but will update each array element by appending the user's text.
            // 4. Then create a loop that prints off each string in the array on a separate line.
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = string.Concat(stringArray[i], userInput);
                Console.WriteLine(stringArray[i]);
            }
            Console.ReadLine();


            // PART TWO
            Console.WriteLine("PART TWO");
            // 1. An infinite loop.
            // 2. Save your code.
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("This WAS my infinite loop, now finite.");

                // 3. Fix the infinite loop so that it will execute properly.
                loop = false;
            }
            Console.ReadLine();


            // PART THREE
            Console.WriteLine("PART THREE");
            // 1. A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine(j);
            }
            // 2. Save and execute your code.
            // 3. A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            for (int k = 0; k <= 5; k++)
            {
                Console.WriteLine(k);
            }
            Console.ReadLine();


            // PART FOUR
            Console.WriteLine("PART FOUR");
            // 1. A list of strings where each item in the list is unique.
            string[] stringArray04 = { "Goodbye", "Bye", "Later", "See-yah", "Buh'bye" };

            // 2. Ask the user to input text to search for in the list.
            Console.WriteLine("Hi, please input text to find a match in the array of strings.");
            string userInput04 = Console.ReadLine();

            // 3. A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
            for (int l = 0; l < stringArray04.Length; l++)
            {
                string indexL = Convert.ToString(l);
                if (stringArray04[l] == userInput04)
                {
                    Console.WriteLine($"\'{userInput04}\' is a match! {indexL} is the index where the match was found!");

                    // 5. Add code to the loop that stops it from executing once a match has been found.
                    l = stringArray04.Length;
                }
                else
                {
                    // 4. Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                    Console.WriteLine($"\'{userInput04}\' is not a match for the string at index {indexL} in the array of strings.");
                }
            }
            Console.ReadLine();


            // PART FIVE
            Console.WriteLine("PART FIVE");
            // 1. A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            string[] namesArray = { "Abe", "Bob", "Cal", "Dan", "Abe", "Cal" };
            Console.WriteLine($"Please select one of the following text to find its index (or indices) in the array of strings: Abe, Bob, Cal, or Dan.");
            string selection = Console.ReadLine();
            int noMatchCount05 = 0;
            
            // 2. Create a loop that iterates through the list and then displays the indices of the items matching the user - selected text.
            for (int m = 0; m < namesArray.Length; m++)
            {
                string indexM = Convert.ToString(m);
                if (selection == namesArray[m])
                {
                    Console.WriteLine($"Your selection {selection} matches the string at index {indexM}.");
                }
                else
                {
                    // 3. Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                    noMatchCount05++;
                    if (noMatchCount05 == namesArray.Length)
                    {
                        Console.WriteLine($"Your selection {selection} did not match any string in the array of strings.");
                    }
                }
            }
            Console.ReadLine();


            // PART SIX
            Console.WriteLine("PART SIX");
            // 1. Create a list of strings that has at least two identical strings in the list.
            List<string> namesList = new List<string>() { "Abe", "Bob", "Cal", "Dan", "Abe", "Cal" };
            List<string> checkList = new List<string>() { "test", };
            int indexCount = 0;

            // 2. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            foreach (string name in namesList)
            {
                int noMatchCount = 0;
                for (int i = 0; i < checkList.Count; i++)
                {
                    if (name == checkList[i])
                    {
                        Console.WriteLine($"The string at index {indexCount} in this list 'namesList' is {name}, and it has already appeared earlier on this list.");
                    }
                    else 
                    {
                        noMatchCount++;
                        if (noMatchCount == checkList.Count)
                        {
                            Console.WriteLine($"The string at index {indexCount} in this list 'namesList' is {name}, and it has not appeared earlier on this list.");
                        }
                    }
                }
                checkList.Add(name);
                indexCount++;
            }
            Console.ReadLine();

        }
    }
}
