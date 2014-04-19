using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Code_Challenge
{
    class Program
    {
        /// <summary>
        /// I will test my ability to use C# effectively across multiple function types
        /// </summary>
        /// <param name="args">Inputs appropriate to each function</param>
        static void Main(string[] args)
        {
            //Create 'for' loop to run FizzBuzz across every number defined
            for (var i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }
            //Run LetterCounter for these three statements
            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");
            //Call TextStats function with a three sentence string
            TextStats("Seedpaths has been one of the best experiences of my life. It has caused me to seriously re-evaluate my way of thinking and my perception of myself.  I never want to miss this kind of educational opportunity.");

            //Always place readkey at the end of the main
            Console.ReadKey();
        }
        //create FizzBuzz function
        static void FizzBuzz(int number)
        {
            //Begin lengthy 'if' series
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        //Make LetterCounter function
        static void LetterCounter(char letter, string inString)
        {
            //Print inString raw before running the process
            Console.WriteLine("Input: " + inString);
            //Declare a variable to store the number of times the letter occurs lowercase
            int letLittle = 0;
            //Declare a variable to store the number of times the letter occurs uppercase
            int letBig = 0;
            //Use Convert.ToString to turn letter into a string
            string letter2 = Convert.ToString(letter);
            //Create two string variables to represent upper and lowercase versions of the letter
            string letterUp = letter2.ToUpper();
            string letterDown = letter2.ToLower();
            //Have 'for' loop that will compare every character in inString against letter
            for (var i = 0; i <= inString.Length - 1; i++)
            {
                string backStep = inString[i].ToString();
                if (backStep == letterDown)
                {
                    letLittle += 1;
                }
                if (backStep == letterUp)
                {
                    letBig += 1;
                }
            }
            //Declare a variable that adds the two values together
            int letTotal = letLittle + letBig;
            //Print each uppercase, lowercase, and overall instance of the letter parameter
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + letLittle);
            Console.WriteLine("Number of UPPERCASE " + letter + "'s found: " + letBig);
            Console.WriteLine("Total Number of " + letter + "'s found: " + letTotal);
        }
        //Create TextStats function
        static void TextStats(string input)
        {
            //Variable to turn input into array around spaces
            var cut = input.Split(' ');
            //Variable to store the length of input
            int values = input.Length;
            //Variable to store the total number of characters in input
            int characters = values;
            //Variable to store the number of words the cut array contains
            int words = cut.Length;
            //Variable to store the number of vowels found within input
            int vowels = 0;
            //Variable to store the number of consonants within input
            int consonants = 0;
            //Variable to store the number of special characters within input
            int special = 0;
            //Variable to contain the reference word for LongestWord
            string Longest = "Goose";
            //Variable to store the length of Longest
            int highLength = Longest.Length;
            //Variable to contain the reference word for ShortestWord
            string Shortest = "is";
            //Variable to store the length of Shortest
            int lowLength = Shortest.Length;

            //Make 'for' loop that runs through every character in input
            for (var i = 0; i < values; i++)
            {
                var symbol = input[i];
                if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
                {
                    vowels += 1;
                }
                else if (symbol == '.' || symbol == '!' || symbol == '?' || symbol == ',' || symbol == '-')
                {
                    special += 1;
                }
                else if (symbol == ' ')
                {
                }
                else
                {
                    consonants += 1;
                }
            }
            for (var i = 0; i < words; i++)
            {
                var wordsActual = cut[i];
                if (cut[i].Length > highLength)
                {
                    Longest = cut[i];
                }
                if (cut[i].Length < lowLength)
                {
                    Shortest = cut[i];
                }
            }
            //Print out every statistic required
            Console.WriteLine("Number of characters: " + characters);
            Console.WriteLine("Number of words: " + words);
            Console.WriteLine("Number of vowels: " + vowels);
            Console.WriteLine("Number of consonants: " + consonants);
            Console.WriteLine("Number of special characters: " + special);
            Console.WriteLine("Longest Word: " + Longest);
            Console.WriteLine("Shortest Wourd: " + Shortest);
        }
    }
}
