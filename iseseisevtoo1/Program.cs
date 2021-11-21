﻿using System;
using System.IO;

namespace iseseisevtoo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\Nikita\samples";
            Console.WriteLine("Enter directory name:");

            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();


            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and File exist.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
}
