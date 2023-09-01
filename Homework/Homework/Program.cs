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
            ExerciseOne.ReverseOrderOflements<int>(list);

            Console.WriteLine();
            Console.WriteLine("Reversed list of elements of type string");
            List<string> list1 = new List<string>() { "A", "B", "D", "M", "F" };
            ExerciseOne.ReverseOrderOflements<string>(list1);

            Console.WriteLine();
            //Exercise 2
            ExerciseTwo.DisplayDistinctValues(list);
            Console.WriteLine();
            ExerciseTwo.DisplayDistinctValues(list1);
            
            Console.WriteLine();
            //Exercise 3
            Queue<string> queue = new Queue<string>();
            queue.CheckIfEmpty();
            queue.Enqueue("Ana");
            queue.Enqueue("Maria");
            queue.Enqueue("Cristina");
            queue.Dequeue("Ana");
            Console.WriteLine(queue.Peek(1));


            Console.WriteLine();
            //Exercise 4
        }

    }



}
