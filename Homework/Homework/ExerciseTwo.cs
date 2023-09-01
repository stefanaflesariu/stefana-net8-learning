using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class ExerciseTwo
    {
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
