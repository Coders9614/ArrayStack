using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    public class Program
    {
        
        public static void Main()
        {
            // Create a stack of integers size of 5
            ArrayStack<int> stack = new ArrayStack<int>(5);
               

            // Push elements 
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            // Try to push one more element with causing overflow
            stack.Push(60);
            // Pop elements from the stack 
            Console.WriteLine("Popping elements from the stack:");
            //The IsEmpty() method returns true if top (the index of the top element in the stack) is -1,
            //indicating there are no elements in the stack.
            while (!stack.IsEmpty())
            {
                int popped = stack.Pop();
                Console.WriteLine($"Popped: {popped}");
            }

            // Try to pop one more element (will cause underflow)
            int underflow = stack.Pop();
            Console.WriteLine($"Popped: {underflow}"); // Should print default value for int (0)

            // Push new elements
            stack.Push(100);
            stack.Push(200);

            // Peek at the top element without removing it
            int topElement = stack.Peek();
            Console.WriteLine($"Top element: {topElement}");

            // Display if stack is empty or not
            Console.WriteLine($"Is the stack empty? {stack.IsEmpty()}");
            Console.ReadKey();
        }
    }
}
