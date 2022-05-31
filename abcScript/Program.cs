using System;
using System.Collections.Generic;

namespace abcScript
{
    class Program
    {
        static void Main(string[] args)
        {
            bool invalidInp = true;
            string userInp;

// Prompt user to input a string, and continue prompting until the user input is valid
            while (invalidInp)
            {
                Console.WriteLine("Please enter your input as an alphabetical string of no greater than 256 characters");
                userInp = Console.ReadLine();
                if (userInp.Length <= 256)
                {
                    invalidInp = false;
                    userInp = userInp.ToLower();

// Using HashSet class to create an alphabet list
                    HashSet<char> abcOutputs = new HashSet<char>();
                    for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
                    {
                        abcOutputs.Add(alphabet);
                    }

// Iterate through user input and remove any characters from alphabet list
                    foreach (char c in userInp)
                    {
                        if (abcOutputs.Contains(c))
                        {
                            abcOutputs.Remove(c);
                        }
                        else
                        {
                            continue;
                        }
                    }

// Output final list and list size
                    Console.WriteLine(String.Join(",", abcOutputs));
                    Console.WriteLine("The new alphabet list contains {0} elements: ", abcOutputs.Count);

                }
            }            
        }
    }
}
