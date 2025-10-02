using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsAndLoops_25_eng
{
    internal static class Assignments
    {
        /*
         ============================================================================
         Assignment 1: Collect numbers into a list
         Goal:
           - Read 'size' numbers from the console using the ReadInt helper function.
           - Store them into a new List<int> in the same order as the user enters them.
           - Use a for-loop and List.Add method.
         Constraints:
           - Do not use LINQ; use basic loops and List.Add.
         Example:
           Input (size = 5):  4 2 8 6 10
           Output list:       [4, 2, 8, 6, 10]
         Links:
           For-loop:   https://github.com/xamk-ture/FundamentalsExamples/blob/master/ForExample/Program.cs
           List<T>:    https://github.com/xamk-ture/FundamentalsExamples/blob/master/ListExample/Program.cs
         Steps:
           1) Create an empty list: var numbers = new List<int>();
           2) Do a for-loop i = 0 .. size-1.
           3) Call ReadInt with a message like $"Enter number {i+1}/{size}: ".
           4) Add the number to the list with List.Add.
           5) Return the list.
         ============================================================================
        */
        public static List<int> CollectNumbersToList(int size)
        {
            List<int> numbers = new();
            for (int i = 0; i < size; i++)
            {
                // ReadInt shows the given prompt message to the user.
                // \n means a new empty line, so the entered number is clearly on its own line.
                int number = ReadInt("Enter number \n");
                numbers.Add(number);
            }

            return numbers;
        }

        /*
         ============================================================================
         Assignment 2: Print list values
         Goal:
           - Print each number of the list on its own line in the given order.
           - Use a foreach-loop on IEnumerable<int>.
         Links:
           Foreach-loop: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ForEachExample/Program.cs
         Steps:
           1) foreach (var n in numbers)
           2) Print each n: Console.WriteLine(n);
         ============================================================================
        */
        public static void PrintList(IEnumerable<int> numbers)
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 3: Calculate average (no LINQ)
        /// Goal:
        ///   - Calculate sum using a for- or foreach-loop and divide by the count.
        /// Constraints:
        ///   - Do not use LINQ (Average/Min/Max).
        /// Links:
        ///   Foreach-loop: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ForEachExample/Program.cs
        /// Steps:
        ///   1) Iterate through all numbers and calculate the sum.
        ///   2) Divide the sum by the count of numbers (numbers.Count).
        ///   3) Return the result as double.
        /// ============================================================================
        /// </summary>
        public static double CalculateAverage(List<int> numbers)
        {
            int sum = 0;
            int count = 0;

            foreach (int num in numbers)
            {
                sum += num;
                count += 1;
            }

            double average = (double)sum / count;
            return average;
        }

        /*
         ============================================================================
         Assignment 4: Find min and max (no LINQ)
         Goal:
           - Find the smallest (min) and largest (max) values in one pass.
         Steps:
           1) Initialize min and max with the first value: min = numbers[0]; max = numbers[0];
           2) Iterate through the rest and update min/max with comparisons using foreach.
         ============================================================================
        */
        public static void FindMinAndMax(List<int> numbers, out int min, out int max)
        {
            throw new NotImplementedException("Empty list -> (0,0). Otherwise initialize with the first value and update with comparisons.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 3 (part B): Filter values greater than a threshold
        /// Goal:
        ///   - Return a NEW list with only those elements greater than the given 'threshold'.
        /// Constraints:
        ///   - Use foreach + if + List.Add; no LINQ.
        /// Steps:
        ///   1) Create an empty list result.
        ///   2) Add values that exceed the threshold.
        ///   3) Return result.
        /// ============================================================================
        /// </summary>
        public static List<int> FindAboveThreshold(List<int> numbers, int threshold)
        {
            throw new NotImplementedException("Build a new list containing only values greater than threshold.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 4: Remove a number from the list
        /// Goal:
        ///   - Try to remove 'number' from the list using List.Remove.
        ///   - Print feedback to the console whether the removal succeeded.
        /// Links:
        ///   List.Remove example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ListExample/Program.cs
        /// Steps:
        ///   1) bool ok = numbers.Remove(number);
        ///   2) If ok == true -> "Removed {number}", else -> "Value not found".
        /// ============================================================================
        /// </summary>
        public static void RemoveNumberFromList(List<int> numbers, int number)
        {
            throw new NotImplementedException("Use List.Remove and print whether it succeeded or not.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 5 : Add random numbers to the list (inclusive range)
        /// Goal:
        ///   - Add 'size' random numbers into the list in range [min, max].
        /// Note:
        ///   - If size <= 0, do nothing.
        /// Links:
        ///   Random usage: https://github.com/xamk-ture/FundamentalsExamples/blob/master/RandomExample/Program.cs
        /// Steps:
        ///   1) If size <= 0, return.
        ///   2) Create Random rng = new();
        ///   3) Loop size times, add rng.Next(min, max+1).
        /// ============================================================================
        /// </summary>
        public static List<int> GenerateRandomNumbersList(int size, int min, int max)
        {
            throw new NotImplementedException("If size > 0, generate values [min, max] and add them to list.");
        }

        // -----------------------------------------------------------------
        // DICTIONARY FUNCTIONS
        // -----------------------------------------------------------------

        /// <summary>
        /// ============================================================================
        /// Assignment 6: Collect (name, age) pairs into dictionary (unique keys)
        /// Goal:
        ///   - Read 'size' pairs of (name, age) into a new dictionary.
        ///   - Key is name (unique).
        ///   - If the name already exists, ask for a different one.
        /// Links:
        ///   Dictionary basics: https://github.com/xamk-ture/FundamentalsExamples/blob/master/DictionaryExample/Program.cs
        /// Steps:
        ///   1) Create empty Dictionary<string,int>.
        ///   2) For 'size' times:
        ///      - Ask for name (Console.ReadLine). If null/empty -> ask again.
        ///      - If dict.ContainsKey(name) -> ask for different name.
        ///      - Read age with ReadInt.
        ///      - dict.Add(name, age).
        ///   3) Return dict.
        /// ============================================================================
        /// </summary>
        public static Dictionary<string, int> CollectDataToDictionary(int size)
        {
            throw new NotImplementedException("Collect 'size' unique (name, age) pairs into a dictionary and return it.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 7: Print dictionary with foreach over KeyValuePair
        /// Goal:
        ///   - Print each entry as: "Key:{name} Value:{age}" (one per line).
        ///   - If dictionary is empty, print "(Empty)".
        /// ============================================================================
        /// </summary>
        public static void PrintDictionary(Dictionary<string, int> dict)
        {
            throw new NotImplementedException("Use foreach over KeyValuePair and print lines.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 8: Find value by key
        /// Goal:
        ///   - Print value if key is found, otherwise "Not found: {key}".
        /// ============================================================================
        /// </summary>
        public static void FindValueByKey(Dictionary<string, int> dict, string key)
        {
            throw new NotImplementedException("Use TryGetValue and print the found value or not found message.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 9: Remove key from dictionary
        /// Goal:
        ///   - Remove 'key' from dictionary and print feedback.
        /// ============================================================================
        /// </summary>
        public static void RemoveKeyFromDictionary(Dictionary<string, int> dict, string key)
        {
            throw new NotImplementedException("Use Remove and print whether it succeeded.");
        }

        /*
        ============================================================================
        Assignment 10a: Collect numbers into an array
        Goal:
          - Ask the user for 'size' numbers and store them in a new int[] array.
          - Similar to Assignment 1, but using an array.
          - Use a for-loop and ReadInt helper.
        Links:
          Array basics: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ArrayExample/Program.cs
        ============================================================================
        */
        public static int[] CollectNumbersToArray(int size)
        {
            throw new NotImplementedException("Create int[] of size 'size', fill with for-loop using ReadInt, and return.");
        }

        /*
         ============================================================================
         Assignment 10b: Print array values
         Goal:
           - Print each element of the array on its own line.
           - Use foreach or for-loop. (foreach is easier)
         ============================================================================
        */
        public static void PrintArray(int[] numbers)
        {
            throw new NotImplementedException("Use foreach or for-loop and print all values.");
        }

        // -----------------------------------------------------------------
        // HELPER (ready, use as-is)
        // -----------------------------------------------------------------
        /// <summary>
        /// Helper: Read a valid integer from console. Asks again if the input is not a number.
        /// If <paramref name="prompt"/> is null or empty, no message is shown.
        /// Uses int.TryParse.
        /// </summary>
        public static int ReadInt(string? prompt)
        {
            while (true)
            {
                if (!string.IsNullOrEmpty(prompt))
                    Console.Write(prompt);

                string input = Console.ReadLine();

                if (int.TryParse(input, out int n))
                    return n;

                Console.WriteLine("Please enter a valid integer.");
            }
        }
    }
}
