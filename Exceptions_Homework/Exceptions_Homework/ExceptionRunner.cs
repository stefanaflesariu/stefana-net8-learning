using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Exceptions_Homework.Classes;
using Exceptions_Homework.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace Exceptions_Homework
{
    public static class ExceptionRunner
    {

        public static void Run()
        {
            // Exercise1();
            // Exercise2();
            // Exercise3();
            // Exercise4();
            // DateTime date = DateTime.Now;
            // Console.WriteLine(date.ToFullDateString());
            // int number = 9;
            // Console.WriteLine(number.ToBinary());
            // Exercise7();
            // Exercise8();
            // Exercise9();
            // Exercise10();
            Exercise11();
        }

        public static void Exercise1()
        {
            try
            {
                Console.WriteLine("Enter a date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                if (date > DateTime.Now)
                {
                    Console.WriteLine("The date is in the future");
                }
                if (date < DateTime.Now)
                {

                    throw new InvalidDateException();
                }
            }
            catch (InvalidDateException ex)
            {
                Console.WriteLine(" The date is not valid ");
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine(" The date it should be of the form YYYY.MM.DD");
            }


        }
        public static void Exercise2()
        {
            try
            {
                Console.WriteLine("Enter multiple names: ");
                for (int i = 1; i < 10; i++)
                {
                    string input = Console.ReadLine();
                    if (String.IsNullOrEmpty(input))
                    {
                        throw new BlankNameException();
                    }
                }
            }
            catch (BlankNameException ex)
            {
                Console.WriteLine("The name is blank");
            }
        }

        /*public static void Exercise3()
        {
            try
            {
                SumAndAverage();
            }
            catch (Exceptions.FormatException ex)
            {
                Console.WriteLine("Input string was not in a correct format.");
            }

        }

        public static void SumAndAverage()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter a list of numbers (separated by spaces): ");
            string input = Convert.ToString(Console.ReadLine());
            string[] numbers = input.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Equals(typeof(int)))
                {
                    list.Add(numbers[i]);
                }
                else
                {
                    throw new Exceptions.FormatException();
                }
            }
            //SUM
            double sum = 0;
            sum = list.Sum();
            Console.Write("Sum: ");
            Console.WriteLine(sum);

            //AVERAGE
            double average = 0;
            average = list.Average();
            Console.Write("Avrage: ");
            Console.Write(average);
        }*/
        public static void Exercise4()
        {


            Console.WriteLine("Enter the name of a file:");
            string fileName = Console.ReadLine();
            try
            {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File does not exist.");
                    FileStream file = File.Create(fileName);
                    Console.WriteLine("Please enter some text to write to the file");
                    string input = Console.ReadLine();

                    File.WriteAllText(fileName, input);
                    Console.WriteLine("File contents:");
                    File.ReadAllText(fileName);
                    Console.WriteLine("You cannot write to the file");
                }
                else if (File.Exists("file.txt") && File.ReadAllText(fileName).Length == 0)
                {
                    Console.WriteLine("File is empty.");
                    Console.WriteLine("Please enter some text to write to the file");
                    string input = Console.ReadLine();
                    File.WriteAllText("file.txt", input);
                    Console.WriteLine("File contents:");
                    File.ReadAllText(fileName);
                }
                else
                {
                    Console.WriteLine("File contents:");
                }
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine("You can't write or read to/into the file");
            }
        }
        public static string ToFullDateString(this DateTime date)
        {
            string result = date.ToString();
            return result;
        }
        public static string ToBinary(this int number)
        {
            string result = Convert.ToString(number, 2);
            return result;
        }
        public static void Exercise7()
        {
            // LINQ Query Syntax
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            var result = (from s in list
                          where s % 2 == 0
                          select s * s).Sum();

            Console.WriteLine("With Query Syntax: ");
            Console.WriteLine(result);

            // LINQ Method Syntax
            Console.WriteLine();
            Console.WriteLine("With Method Syntax: ");

            var result1 = (list.Where(s => s % 2 == 0).Select(s => s * s)).Sum();
            Console.WriteLine(result1);

        }
        public static void Exercise8()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            var result = (from s in list
                          select s * s).ToList();

            Console.WriteLine("With Query Syntax: ");
            foreach (var s in result)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            Console.WriteLine("With Method Syntax: ");
            var result1 = list.Select(s => s * s).ToList();
            foreach (var s in result1)
            {
                Console.Write(s + " ");
            }
        }
        public static void Exercise9()
        {
            var students = new List<Student> {
                 new Student { Name = "Alice", Grade = "A" },
                 new Student { Name = "Bob", Grade = "B" },
                 new Student { Name = "Charlie", Grade = "A" },
                 new Student { Name = "Dave", Grade = "C" }
            };

            Console.WriteLine("With Query Syntax: ");
            var result = (from std in students
                          where std.Grade == "A"
                          orderby std.Name descending
                          select std.Name).ToList();
            foreach (var s in result)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            Console.WriteLine("With Method Syntax: ");
            var result1 = students.OrderByDescending(s => s.Name).Where(s => s.Grade == "A").Select(s => s.Name).ToList();
            foreach (var s in result1)
            {
                Console.Write(s + " ");
            }
        }
        public static void Exercise10()
        {
            var products = new List<Product> {
                new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
                new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
                new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
                new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
                new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
            };

            //Sorted by price
            var products2 = products.GroupBy(x => x.Category).Distinct()
                            .Select(g => g.OrderBy(x => x.Price).First())
                            .OrderBy(x => x.Price).ToList();
            foreach (var product in products2)
            {
                Console.WriteLine("{0} {1} ", product.Category, product.Price);

            }

            // Sorted by name
            var products3 = products.GroupBy(x => x.Category).Distinct()
                            .Select(g => g.OrderBy(x => x.Name).First())
                            .OrderBy(x => x.Name).ToList();

            foreach (var product in products3)
            {
                Console.WriteLine("{0} {1} ", product.Category, product.Name);

            }
        }
        public static void Exercise11()
        {
            var products = new List<Product> {
                new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
                new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
                new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
                new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
                new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
            };

            var average = products.GroupBy(p => p.Category)
                          .Select(g => new
                          {
                              Category = g.Key,
                              Average = g.Average(p => p.Price)
                          })
                          .OrderByDescending(a => a.Average)
                          .ToList();
            foreach (var product in average)
            {
                Console.WriteLine("{0} {1} ", product.Category, product.Average);

            }
        }
    }
}
