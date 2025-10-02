// Program.cs
using System;
using System.Collections.Generic;

namespace CollectionsAndLoops_25_eng
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                PrintMenu();
                Console.Write("\nChoice (0 exits): ");
                string choice = (Console.ReadLine() ?? "").Trim();

                switch (choice)
                {
                    case "1":
                        // 1) Collect numbers into a list and print
                        Console.WriteLine("\n=== Task 1: Collect numbers into a list and print them ===");
                        int listsize = Assignments.ReadInt("How many numbers should be collected into the list?: ");
                        List<int> list1 = Assignments.CollectNumbersToList(listsize);
                        Console.WriteLine("\nEntered numbers:");
                        Assignments.PrintList(list1);
                        Pause();
                        break;

                    case "2":
                        // 2) Calculate average, min, max (collection as parameter)
                        Console.WriteLine("\n=== Task 2: Average, min and max (without LINQ) ===");
                        int listsize2 = Assignments.ReadInt("How many numbers should be collected into the list?: ");
                        List<int> numbersForStats = Assignments.CollectNumbersToList(listsize2);

                        double avg = Assignments.CalculateAverage(numbersForStats);
                        Console.WriteLine($"\nAverage: {avg}");

                        Assignments.FindMinAndMax(numbersForStats, out int min, out int max);
                        Console.WriteLine($"Minimum: {min}");
                        Console.WriteLine($"Maximum: {max}");
                        Pause();
                        break;

                    case "3":
                        // 3) Filter > threshold (collection as parameter, threshold asked from user)
                        Console.WriteLine("\n=== Task 3: Filter values greater than threshold ===");
                        int listsize3 = Assignments.ReadInt("How many numbers should be collected into the list?: ");
                        List<int> numbersForFilter = Assignments.CollectNumbersToList(listsize3);
                        int threshold = Assignments.ReadInt("Enter threshold value: ");
                        List<int> above = Assignments.FindAboveThreshold(numbersForFilter, threshold);

                        Console.WriteLine("\nNumbers greater than the threshold:");
                        if (above.Count == 0)
                            Console.WriteLine("(No values)");
                        else
                            Assignments.PrintList(above);

                        Pause();
                        break;

                    case "4":
                        // 4) Remove numbers from list (repeatedly)
                        Console.WriteLine("\n=== Task 4: Remove numbers from list ===");
                        int listsize4 = Assignments.ReadInt("How many numbers should the list contain initially?: ");
                        List<int> numbersForRemove = Assignments.CollectNumbersToList(listsize4);

                        while (true)
                        {
                            Console.Write("\nEnter number to remove: ");
                            int toRemove = Assignments.ReadInt(null);
                            Assignments.RemoveNumberFromList(numbersForRemove, toRemove);

                            Console.WriteLine("Updated list:");
                            Assignments.PrintList(numbersForRemove);

                            Console.Write("Remove another number? (y/n): ");
                            string again = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
                            if (again != "y") break;
                        }
                        Pause();
                        break;

                    case "5":
                        // 5) Add random numbers to list (collection as parameter; ask how many and range)
                        Console.WriteLine("\n=== Task 5: Add random numbers to list ===");

                        int addsize = Math.Max(0, Assignments.ReadInt("How many random numbers should be added?: "));
                        int minRand = Assignments.ReadInt("Random numbers minimum (inclusive): ");
                        int maxRand = Assignments.ReadInt("Random numbers maximum (inclusive): ");

                        List<int> randomNumbers = Assignments.GenerateRandomNumbersList(addsize, minRand, maxRand);
                        Console.WriteLine("\nList after adding random numbers:");
                        Assignments.PrintList(randomNumbers);
                        Pause();
                        break;

                    case "6":
                        // 6) Collect (name, age) into dictionary
                        Console.WriteLine("\n=== Task 6: Collect (name, age) pairs into dictionary ===");
                        int pairsize = Assignments.ReadInt("How many (name, age) pairs should be collected?: ");
                        Dictionary<string, int> people = Assignments.CollectDataToDictionary(pairsize);

                        Console.WriteLine("\nEntered data:");
                        Assignments.PrintDictionary(people);
                        Pause();
                        break;

                    case "7":
                        // 7) Print dictionary
                        Console.WriteLine("\n=== Task 7: Print dictionary ===");
                        int pairsize2 = Assignments.ReadInt("How many (name, age) pairs should be collected first into the dictionary?: ");
                        Dictionary<string, int> dictForPrint = Assignments.CollectDataToDictionary(pairsize2);

                        Console.WriteLine("\nDictionary contents:");
                        Assignments.PrintDictionary(dictForPrint);
                        Pause();
                        break;

                    case "8":
                        // 8) Find value by key (dictionary as parameter, ask key)
                        Console.WriteLine("\n=== Task 8: Find value by key ===");
                        int pairsize3 = Assignments.ReadInt("How many (name, age) pairs should be collected first into the dictionary?: ");
                        Dictionary<string, int> dictForFind = Assignments.CollectDataToDictionary(pairsize3);

                        Console.Write("Enter name to search: ");
                        string keyToFind = Console.ReadLine() ?? "";
                        Assignments.FindValueByKey(dictForFind, keyToFind);
                        Pause();
                        break;

                    case "9":
                        // 9) Remove key from dictionary (repeatedly)
                        Console.WriteLine("\n=== Task 9: Remove key from dictionary ===");
                        int pairsize4 = Assignments.ReadInt("How many (name, age) pairs should be collected first into the dictionary?: ");
                        Dictionary<string, int> dictForRemove = Assignments.CollectDataToDictionary(pairsize4);

                        while (true)
                        {
                            Console.Write("Enter name to remove: ");
                            string keyToRemove = Console.ReadLine() ?? "";
                            Assignments.RemoveKeyFromDictionary(dictForRemove, keyToRemove);

                            Console.WriteLine("\nUpdated dictionary:");
                            Assignments.PrintDictionary(dictForRemove);

                            Console.Write("Remove another? (y/n): ");
                            string again2 = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
                            if (again2 != "y") break;
                        }
                        Pause();
                        break;

                    case "10":
                        // 10) Array: collect numbers into array and print
                        Console.WriteLine("\n=== Task 10: Array ===");
                        int arraySize = Assignments.ReadInt("How many numbers should be collected into the array?: ");
                        int[] arr = Assignments.CollectNumbersToArray(arraySize);

                        Console.WriteLine("\nArray numbers:");
                        Assignments.PrintArray(arr);
                        Pause();
                        break;

                    case "0":
                        Console.WriteLine("\nThank you! Press Enter to exit.");
                        Console.ReadLine();
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        Pause();
                        break;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Loops & Collections – Practice ===\n");
            Console.WriteLine("Choose a task:");
            Console.WriteLine(" 1) Collect numbers into a list and print");
            Console.WriteLine(" 2) Calculate average, min and max (without LINQ)");
            Console.WriteLine(" 3) Filter numbers greater than threshold");
            Console.WriteLine(" 4) Remove numbers from list (repeatedly)");
            Console.WriteLine(" 5) Add random numbers to list");
            Console.WriteLine(" 6) Collect (name, age) pairs into dictionary");
            Console.WriteLine(" 7) Print dictionary");
            Console.WriteLine(" 8) Find value by key (name)");
            Console.WriteLine(" 9) Remove key from dictionary (repeatedly)");
            Console.WriteLine("10) Array: collect numbers into array and print");
            Console.WriteLine(" 0) Exit");
        }

        private static void Pause()
        {
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
