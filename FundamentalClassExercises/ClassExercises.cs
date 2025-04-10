using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalClassExercises
{
    public class ClassExercises
    {
        /// <summary>
        /// Determines whether the given array of integers contains at least one odd number.
        /// </summary>
        /// <param name="numbers">An array of integers to check for odd numbers.</param>
        /// <returns>
        /// <c>true</c> if the array contains at least one odd number; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method uses a <c>foreach</c> loop to iterate through the array and checks each number
        /// to determine if it is odd by calculating the remainder when divided by 2.
        /// </remarks>
        public bool ContainsOddNumberUsingAForEach(int[] numbers)
        {
            foreach (int number in numbers)
            {
                int remainder = number % 2;

                if (remainder != 0)
                    return true;
                else continue;
            }

            return false;


        }

        /// <summary>
        /// Determines whether the given array of integers contains at least one odd number.
        /// </summary>
        /// <param name="numbers">An array of integers to check for odd numbers.</param>
        /// <returns>
        /// <c>true</c> if the array contains at least one odd number; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method uses a <c>while</c> loop to iterate through the array and checks each number
        /// to determine if it is odd by calculating the remainder when divided by 2.
        /// </remarks>
        public bool ContainsOddNumberUsingAWhile(int[] numbers)
        {
            int index = 0;

            while (index < numbers.Length)
            {
                int remainder = numbers[index] % 2;

                if (remainder != 0)
                    return true;

                index++;

            }


            return false;
        }

        /// <summary>
        /// Determines whether the given array of integers contains at least one odd number.
        /// </summary>
        /// <param name="numbers">An array of integers to check for odd numbers.</param>
        /// <returns>
        /// <c>true</c> if the array contains at least one odd number; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method uses a <c>for</c> loop to iterate through the array and checks each number
        /// to determine if it is odd by calculating the remainder when divided by 2.
        /// </remarks>
        public bool ContainsOddNumber(int[] numbers)
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                int remainder = numbers[x] % 2;

                if (remainder != 0)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the given string is a palindrome.
        /// </summary>
        /// <param name="forwardString">The string to check for palindrome properties.</param>
        /// <returns>
        /// <c>true</c> if the string is a palindrome; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// A palindrome is a string that reads the same backward as forward. This method reverses the input string
        /// using the <see cref="StringReverse"/> method and compares it to the original string.
        /// </remarks>
        public bool IsPalindrome(string forwardString)
        {
            string reversedString = StringReverse(forwardString);

            //  An if statement could be used or the boolean expression 
            //  forwardString == reversedString   Both of these mean the same thing.

            /*   if (forwardString == reversedString)
                   return true;

               else
                   return false;
            */

            return forwardString == reversedString;
        }


        /// <summary>
        /// Reverses the given string and returns the reversed result.
        /// </summary>
        /// <param name="forwardString">The string to be reversed.</param>
        /// <returns>
        /// A new string that is the reverse of the input string.
        /// </returns>
        /// <remarks>
        /// This method iterates through the input string from the end to the beginning
        /// and constructs the reversed string by appending each character.
        /// </remarks>
        public string StringReverse(string forwardString)
        {
            string reversedString = string.Empty; // ""

            for (int x = forwardString.Length - 1; x >= 0; x--)
            {
                reversedString += forwardString[x];
            }

            return reversedString;
        }


        public string RemoveVowels(string sentence)
        {
            char[] vowels = { 'a', 'e', 'i','o','u' };

            string sentenceNoVowels = string.Empty;
           
            foreach(char letter in sentence)
            {
                
                if (!vowels.Contains(char.ToLower(letter)))
                {
                    sentenceNoVowels = sentenceNoVowels + letter;
                }
            }

            
            return sentenceNoVowels;
        }
    }
}
