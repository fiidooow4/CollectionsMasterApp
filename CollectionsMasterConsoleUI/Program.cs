using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            int[] arrayofFifty = new int[50];

            Populater(arrayofFifty);

            Console.WriteLine($"First number of the array: {arrayofFifty[0]}");
            Console.WriteLine($"Last number of the array: {arrayofFifty[arrayofFifty.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            NumberPrinter(arrayofFifty);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(arrayofFifty);
            NumberPrinter(arrayofFifty);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            Array.Reverse(arrayofFifty);
            NumberPrinter(arrayofFifty);
            Console.WriteLine("-------------------");

            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(arrayofFifty);
            NumberPrinter(arrayofFifty);
            Console.WriteLine("-------------------");

            Console.WriteLine("Sorted numbers:");
            Array.Sort(arrayofFifty);
            NumberPrinter(arrayofFifty);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            List<int> listofFifty = new List<int>();

            Console.WriteLine($"List Capacity: {listofFifty.Capacity}");

            Populater(listofFifty);

            Console.WriteLine($"Updated List Capacity: {listofFifty.Capacity}");

            Console.WriteLine("---------------------");

            Console.WriteLine("What number will you search for in the number list?");
            int userNumber;
            if (int.TryParse(Console.ReadLine(), out userNumber))
            {
                NumberChecker(listofFifty, userNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            NumberPrinter(listofFifty);
            Console.WriteLine("-------------------");

            Console.WriteLine("Evens Only!!");
            OddKiller(listofFifty);
            NumberPrinter(listofFifty);
            Console.WriteLine("------------------");

            Console.WriteLine("Sorted Evens!!");
            listofFifty.Sort();
            NumberPrinter(listofFifty);
            Console.WriteLine("------------------");

            int[] convertedArray = listofFifty.ToArray();
            listofFifty.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(x => x % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Number {searchNumber} is present in the list.");
            }
            else
            {
                Console.WriteLine($"Number {searchNumber} is not present in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0, 51));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }
        }

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
