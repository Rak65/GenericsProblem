using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Which program you want to run: ");
                Console.WriteLine("1. Delete element from the array.");
                Console.WriteLine("2. Delete element from the array using generic method.");
                Console.WriteLine("3. Delete element from the array using Generic Class concept.");
                Console.WriteLine("4. Find the minimum using Generics.");
                Console.WriteLine("5. Exit");

                string choice=Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        DeleteArray.Array();
                        break;
                    case "2":
                        DeleteUsingGenericMethod.ArrayGeneric();
                        break;
                    case "3":
                        Generic.ArrayGenerics();
                        break;
                    case "4":
                        int minInt = FindMinimum.FindMin(10, 5, 15);
                        Console.WriteLine("Minimum integer: " + minInt);
                        float minFloat = FindMinimum.FindMin(3.14f, 2.71f, 3.5f);
                        Console.WriteLine("Minimum float: " + minFloat);
                        string minString = FindMinimum.FindMin("apple", "banana", "cherry");
                        Console.WriteLine("Minimum string: " + minString);
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default: Console.WriteLine("Try again:---");
                        break;
                }
            }
        }
    }
}
