using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class ExerciseOne
    {
        // 1.Create a generic method that takes in a list of any type and reverses the order of the elements.
        public static void ReverseOrderOflements<T>(List<T> list)
        {
            List<T> reverse = new List<T>();
            for (int i = list.Count; i > 0; i--)
            {
                reverse.Add(list[i - 1]);
            }
            foreach (T i in reverse)
            {
                Console.Write(i + " ");
            }
        }
    }
}
