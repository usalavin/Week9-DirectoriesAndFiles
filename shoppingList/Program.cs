using System;
using System.Collections.Generic;

namespace shoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myShoppingList = new List<string>();

            Console.WriteLine(myShoppingList.Count);

            myShoppingList.Add("bread");
            myShoppingList.Add("chocolate");
            myShoppingList.Add("milk");
            myShoppingList.Add("potato");


            Console.WriteLine(myShoppingList.Count);

            foreach (string wish in myShoppingList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
