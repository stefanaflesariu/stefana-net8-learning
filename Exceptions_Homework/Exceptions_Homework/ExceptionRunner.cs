using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Exceptions_Homework.Exceptions;

namespace Exceptions_Homework
{
    public static class ExceptionRunner
    {

        public static void Run()
        {
            // Exercise1();
            // Exercise2();
            Exercise3();
        }

        public static void Exercise1()
        {
            try
            {
                Console.WriteLine("Introdu o data: ");
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


        public static void Exercise3()
        {
            Sum();
        }

        private static double Sum()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a list of numbers (separated by spaces): ");

            for (int i = 1; i < 5; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);
            }
            double sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
