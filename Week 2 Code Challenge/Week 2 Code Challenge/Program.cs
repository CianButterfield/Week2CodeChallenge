using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //call loop FizzBuzz
            for (int i = 0; i < 20; i++)
            {
                FizzBuzz(i);
            }

            //calls for LetterCounter
            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");

            //keep the console open
            Console.ReadKey();
        }

        //Function for FizzBuzz
        static void FizzBuzz(int number)
        {
            //if number is divisible by 15 it is divisible by 3 and 5, print "FizzBuzz"
            if (number % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            //number is only divisible by 5, print "Fizz"
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            //number is only divisible by 3, print "Buzz"
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            //number is not divisable by 3 or 5, print number
            else
            {
                Console.WriteLine(number);
            }
        }

        //Function for LetterCounter
        static void LetterCounter(char letter, string inString)
        {
            //declare variables to track the number of letters
            int numLower = 0;
            int numUpper = 0;
            int numTotal = 0;

            //loop through inString to check for letter
            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i] == char.ToLower(letter))
                {
                    numLower++;
                    numTotal++;
                }
                else if (inString[i] == char.ToUpper(letter))
                {
                    numUpper++;
                    numTotal++;
                }
            }

            //print the outputs
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + numLower);
            Console.WriteLine("Number of UPPERCASE " + letter + "'s found: " + numUpper);
            Console.WriteLine("Total Number of " + letter + "'s found: " + numTotal);
            Console.WriteLine("\n");
        }
    }
}
