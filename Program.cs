using System;
using System.Collections.Generic;

namespace Project
{
    class Code
    {
        static Dictionary<string, string> itemsMap = new Dictionary<string, string>();
        const string commands = "Type 'add item' then press ENTER to add an item to the list.\nType 'list items' then press ENTER to view the items in the list.\n" +
            "Type 'remove item' then press ENTER to remove an item from the list.\nType 'clear items' then press ENTER to remove all items from the list." +
            "\nType 'commands' then press ENTER to view this message again.";
        static void Main()
        {
            Console.WriteLine(commands);
            Listen();
        }

        static void Listen()
        {
            string input = Console.ReadLine().ToLower();
            if (input == null)
            {
                return;
            }
            else
            {
                Listener(input);
            }
        }

        static void AddItem()
        {
            Console.WriteLine("Adding item. Type name of item then press ENTER...");
            string userInput = Console.ReadLine();
            if (userInput != null)
            {
                if (!itemsMap.ContainsKey(userInput))
                {
                    itemsMap.Add(userInput, userInput);
                }
                else
                {
                    Console.WriteLine("Item already exists!");
                }
            }
            Listen();
        }

        static void ListItem()
        {
            Console.WriteLine("Listing items...");
            foreach (KeyValuePair<string, string> item in itemsMap)
            {
                Console.WriteLine(item.Value);
            }
            Listen();
        }

        static void RemoveItem()
        {
            Console.WriteLine("Remove item. Type name of item then press ENTER...");
            string userInput = Console.ReadLine();
            if (userInput != null)
            {
                if (itemsMap.ContainsKey(userInput))
                {
                    itemsMap.Remove(userInput);
                }
                else
                {
                    Console.WriteLine("Item does not exist!");
                }
            }
            Listen();
        }

        static void ClearItems()
        {
            Console.WriteLine("Items cleared...");
            itemsMap.Clear();
            Listen();
        }

        static void ListCommands()
        {
            Console.WriteLine("Listing commands...");
            Console.WriteLine(commands);
            Listen();
        }

        static void Listener(string command)
        {
            const string addItem = "add item";
            const string listItems = "list items";
            const string removeItem = "remove item";
            const string clearItems = "clear items";
            const string listCommands = "commands";
            if (command != null)
            {
                switch(command)
                {
                    case addItem:
                        AddItem();
                        break;
                    case listItems:
                        ListItem();
                        break;
                    case removeItem:
                        RemoveItem();
                        break;
                    case clearItems:
                        ClearItems();
                        break;
                    case listCommands:
                        ListCommands();
                        break;
                    default: Listen(); break;
                }
            }
        }
    }
}