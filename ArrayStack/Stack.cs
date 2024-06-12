using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    public class ArrayStack<S>
    {
        private S[] Array;
        private int top; // index of the top element in the stack

        // Constructor to initialize the stack with a specified size
        public ArrayStack(int size)
        {
            Array = new S[size];
            top = -1; // Stack is initially is -1(empty) 
        }

        // Method to push an element onto the stack
        public void Push(S item)
        {
            if (top == Array.Length - 1)
            {
                Console.WriteLine("Stack Overflow! Cannot push element.");
                return;
            }

            top++;
            Array[top] = item;
        }

        // Method to pop the top element from the stack and return it
        public S Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow! Cannot pop element.");
                return default(S); // Return default value for type T (e.g., null for reference types)
            }

            S popped = Array[top];
            top--;
            return popped;
        }

        // Method to check if the stack is empty
        public bool IsEmpty()
        {
            return top == -1;
        }

        // Method to peek at the top element  without removing it
        public S Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return default(S); // Return default value for type S
            }

            return Array[top];
        }
    }
}
