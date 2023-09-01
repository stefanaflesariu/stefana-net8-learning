using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Queue<T> 
    {
        public List<T> queue = new List<T>();
        public void Enqueue( T value)
        {
            queue.Add(value);
        }
        public void Dequeue(T value)
        {
            queue.Remove(value);
        }
        public T Peek(int index)
        {
            T value = queue[index - 1];
            return value;
        }
        public void CheckIfEmpty()
        {
            bool IsEmpty;
            if (queue.Count == 0)
            {
                IsEmpty = true;
                Console.WriteLine(" Empty Queue");
            }
            else
            {
                IsEmpty = false;
                Console.WriteLine(" Queue not empty");
            }
        }
    }
}
