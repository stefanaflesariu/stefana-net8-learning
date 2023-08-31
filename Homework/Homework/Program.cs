using System;
using System.Linq.Expressions;

namespace Homework 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("Reversed list of elements of type int");
            List<int> list = new List<int>() { 1, 8, 6, 9, 3, 4, 1, 6, 3 };
            ReverseOrderOflements<int>(list);

            Console.WriteLine();
            Console.WriteLine("Reversed list of elements of type string");
            List<string> list1 = new List<string>() { "A", "B", "D", "M", "F" };
            ReverseOrderOflements<string>(list1);

            Console.WriteLine();
            //Exercise 2
            DisplayDistinctValues(list);
            Console.WriteLine();
            DisplayDistinctValues(list1);

            //
        }

        // 1.Create a generic method that takes in a list of any type and reverses the order of the elements.
        public static void ReverseOrderOflements<T>(List<T> list)
        {
            List<T> reverse = new List<T>();
            for(int i = list.Count; i > 0 ; i--)
            {
                reverse.Add(list[i-1]);
            }
            foreach (T i in reverse)
            {
                Console.Write(i + " ");
            }
        }

        // 2.Create a generic method that takes in a list of any type and applies a specific action to each element
        // using a lambda expression.
        public static void DisplayDistinctValues<T>(List<T> list)
        {
            var list2 = list.Select(x => x + " ana");
            foreach (var i in list2)
            {
                Console.Write(i + " ");
            }
        }

    }



}
