1
using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary with key = Category, value = List of items
            Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== DICTIONARY MENU =====");
                Console.WriteLine("1. Populate Dictionary");
                Console.WriteLine("2. Display Dictionary");
                Console.WriteLine("3. Remove a Key");
                Console.WriteLine("4. Add New Key and Value");
                Console.WriteLine("5. Add Value to Existing Key");
                Console.WriteLine("6. Sort Keys");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    // a. Populate Dictionary
                    case "1":
                        PopulateDictionary(myDictionary);
                        break;

                    // b. Display Dictionary
                    case "2":
                        DisplayDictionary(myDictionary);
                        break;

                    // c. Remove a Key
                    case "3":
                        RemoveKey(myDictionary);
                        break;

                    // d. Add New Key and Value
                    case "4":
                        AddNewKeyValue(myDictionary);
                        break;

                    // e. Add Value to Existing Key
                    case "5":
                        AddValueToExistingKey(myDictionary);
                        break;

                    // f. Sort Keys
                    case "6":
                        SortKeys(myDictionary);
                        break;

                    case "7":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        // ========================= METHODS =========================

        // Populate dictionary with sample data
        static void PopulateDictionary(Dictionary<string, List<string>> dict)
        {
            dict["Fruits"] = new List<string> { "Apple", "Banana", "Mango" };
            dict["Vegetables"] = new List<string> { "Carrot", "Spinach" };
            dict["Drinks"] = new List<string> { "Water", "Juice" };

            Console.WriteLine("Dictionary populated with sample data.");
        }

        // Display dictionary contents (foreach method)
        static void DisplayDictionary(Dictionary<string, List<string>> dict)
        {
            if (dict.Count == 0)
            {
                Console.WriteLine("Dictionary is empty.");
                return;
            }

            Console.WriteLine("\n--- Dictionary Contents ---");

            foreach (var pair in dict)
            {
                Console.Write($"{pair.Key}: ");
                Console.WriteLine(string.Join(", ", pair.Value));
            }
        }

        // Remove a key
        static void RemoveKey(Dictionary<string, List<string>> dict)
        {
            Console.Write("Enter key to remove: ");
            string key = Console.ReadLine();

            if (dict.Remove(key))
            {
                Console.WriteLine("Key removed successfully.");
            }
            else
            {
                Console.WriteLine("Key not found.");
            }
        }

        // Add new key and value
        static void AddNewKeyValue(Dictionary<string, List<string>> dict)
        {
            Console.Write("Enter new key: ");
            string key = Console.ReadLine();

            if (dict.ContainsKey(key))
            {
                Console.WriteLine("Key already exists.");
                return;
            }

            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            dict[key] = new List<string> { value };

            Console.WriteLine("New key-value pair added.");
        }

        // Add value to existing key
        static void AddValueToExistingKey(Dictionary<string, List<string>> dict)
        {
            Console.Write("Enter existing key: ");
            string key = Console.ReadLine();

            if (dict.ContainsKey(key))
            {
                Console.Write("Enter value to add: ");
                string value = Console.ReadLine();

                dict[key].Add(value);

                Console.WriteLine("Value added to existing key.");
            }
            else
            {
                Console.WriteLine("Key not found.");
            }
        }

        // Sort keys
        static void SortKeys(Dictionary<string, List<string>> dict)
        {
            if (dict.Count == 0)
            {
                Console.WriteLine("Dictionary is empty.");
                return;
            }

            Console.WriteLine("\n--- Sorted Keys ---");

            var sortedKeys = dict.Keys.OrderBy(k => k);

            foreach (var key in sortedKeys)
            {
                Console.WriteLine(key);
            }
        }
    }
}