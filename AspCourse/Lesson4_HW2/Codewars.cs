using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_HW2
{
    internal class Codewars
    {
        public Codewars() { }

        // Task1
        //https://www.codewars.com/kata/5513795bd3fafb56c200049e
        /*
          Create a function with two arguments that will return an array of the first n multiples of x.
          Assume both the given number and the number of times to count will be positive numbers greater than 0.
            Examples
            countBy(1,10) === [1,2,3,4,5,6,7,8,9,10]
            countBy(2,5) === [2,4,6,8,10]
        */

        public static List<int> CountBy(int x, int n)
        {
            List<int> ints = new List<int>(n);

            for (int i = 0; i < ints.Capacity; i++)
            {
                ints.Add((i + 1) * x);
            }

            return ints;
        }

        // Task2
        //https://www.codewars.com/kata/57e76bc428d6fbc2d500036d
        /*
          Write a function to split a string and convert it into an array of words.
            Examples
         "Robin Singh" ==> ["Robin", "Singh"]
         "I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
        */
        public static List<string> StringToListOfWords(string str)
        {
            List<string> result = str.Split(' ').ToList();
            return result;
        }

        // Task3
        //https://www.codewars.com/kata/576bb71bbbcf0951d5000044
        /*        
        Given an array of integers.
        Return an array, where the first element is the count of positives numbers and 
        the second element is sum of negative numbers. 
        0 is neither positive nor negative.
        If the input is an empty array or is null, return an empty array.
            Example
            For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
        */

        public static List<int> CountOfPositiveAndSumOfNegative(List<int> ints)
        {
            List<int> result = new List<int>(2);
            int count = 0;
            int sum = 0;
            foreach (int e in ints)
            {
                if (e >= 0)
                {
                    count++;
                }
                else
                {
                    sum += e;
                }
            }
            result.Add(count);
            result.Add(sum);

            return result;
        }

        //https://www.codewars.com/kata/515e271a311df0350d00000f
        /*         
         Complete the square sum function so that it squares each number passed into it 
         and then sums the results together.
            Example
            for [1, 2, 2] it should return 9 because 1^2+2^2+2^2 = 9
        */

        public static int SquareThenSum(List<int> ints)
        {
            int result = 0;
            foreach (int e in ints)
            {
                result += e ^ 2;
            }
            return result;
        }

        //https://www.codewars.com/kata/5583090cbe83f4fd8c000051
        /*
          Given a random non-negative number, you have to return the digits of this 
          number within an array in reverse order.
            Examples
             35231 => [1,3,2,5,3]
             0 => [0]
        */

        public static List<int> ReversedListOfDigits(int n)
        {
            List<int> result = new List<int>();
            string stringOfDigits = n.ToString();
            foreach (var e in stringOfDigits)
            {
                result.Add(e);
            }
            result.Reverse();
            return result;
        }

        //
        // ADDITIONAL TASKS
        //

        //https://www.codewars.com/kata/57a5015d72292ddeb8000b31
        /*
         A palindrome is a word, phrase, number, or other sequence of 
        characters which reads the same backward or forward. 
         This includes capital letters, punctuation, and word dividers.
         Implement a function that checks if something is a palindrome. 
         If the input is a number, convert it to string first.
            Examples
             "anna"   ==> true
             "walter" ==> false
             12321    ==> true
             123456   ==> false
        */

        public static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] == str[str.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsPalindrome(int n)
        {
            string str = n.ToString();
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] == str[str.Length - 1 - i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        //https://www.codewars.com/kata/5514e5b77e6b2f38e0000ca9
        /*
          Given an array of integers of any length, return an array that has 1 added to the value represented by the array.
            * the array can't be empty
            * only non-negative, single digit integers are allowed
          Return nil (or your language's equivalent) for invalid inputs.
                Examples
                 [4, 3, 2, 5] would return [4, 3, 2, 6]
                 [1, 2, 3, 9] would return [1, 2, 4, 0]
                 [9, 9, 9, 9] would return [1, 0, 0, 0, 0]
                 [0, 1, 3, 7] would return [0, 1, 3, 8]
        */

        public static List<int> PlusOneToArray(List<int> list)
        {
            int number = 0;
            int counter = list.Count;
            foreach (var e in list)
            {
                number += e * Convert.ToInt32(Math.Pow(10, --counter));
            }
            number++;
            string str = number.ToString();
            List<int> result = new List<int>();

            foreach (var e in str)
            {
                result.Add(Convert.ToInt32(e - '0'));
                // char.GetNumericValue(e);
            }

            return result;
        }

        //https://www.codewars.com/kata/515f51d438015969f7000013
        /*
          Write a function that when given a number >= 0, returns an Array of ascending length subarrays.
            Examples
             pyramid(0) => [ ]
             pyramid(1) => [ [1] ]
             pyramid(2) => [ [1], [1, 1] ]
             pyramid(3) => [ [1], [1, 1], [1, 1, 1] ]
        */

        public static List<List<int>> Pyramid(int n)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                result.Add(new List<int>(i + 1));
                //int counter = 1;

                for (int k = 0; k < result[i].Capacity; k++)
                {
                    result[i].Add(1);
                }

                //counter++;
            }
            return result;
        }

        //https://www.codewars.com/kata/5250a89b1625e5decd000413
        /*
          Write a function that flattens an Array of Array objects into a flat Array. 
          Your function must only do one level of flattening. 
            Examples
             flatten [1,2,3] # => [1,2,3]
             flatten [[1,2,3],["a","b","c"],[1,2,3]]  # => [1,2,3,"a","b","c",1,2,3]
             flatten [[[1,2,3]]] # => [[1,2,3]]
        */

        // As far as I know, there is no way to have a general solution to this problem, so I made
        // List<List<int>> to List<int>

        public static List<int> FlattenList(List<List<int>> array)
        {
            List<int> result = new List<int>();

            foreach (var item in array)
            {
                foreach (var item2 in item)
                {
                    result.Add(item2);
                }
            }
            return result;
        }

        public static List<string> FlattenList(List<List<string>> array)
        {
            List<string> result = new List<string>();

            foreach (var item in array)
            {
                foreach (var item2 in item)
                {
                    result.Add(item2);
                }
            }
            return result;
        }

        //https://www.codewars.com/kata/556196a6091a7e7f58000018
        /*
            Given a sequence of numbers, find the largest pair sum in the sequence.
                Examples
                 [10, 14, 2, 23, 19] -->  42 (= 23 + 19)
                 [99, 2, 2, 23, 19]  --> 122 (= 99 + 23)           
        */

        public static int GetLargestPairSum(List<int> intsToSum)
        {
            int firstToSum = int.MinValue; 
            int secondToSum = int.MinValue;

            if (intsToSum.Count < 2) return 0; // If List is too short

            foreach (var e in intsToSum)
            {
                if (e > firstToSum && firstToSum <= secondToSum)
                {
                    firstToSum = e;
                } else if (e > secondToSum) {
                    secondToSum = e;
                }
            }
            int result = firstToSum + secondToSum;
            return result;
        }
    }
}