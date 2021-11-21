﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace proov
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Nikita\samples\shoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add something to your shopping list? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myShoppingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }
            Console.Clear();

            foreach (string wish in myShoppingList)
            {
                Console.WriteLine($"Your wish: {wish}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
