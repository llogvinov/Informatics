using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class ArrayStack
    {
        private int[] items { get; set; }
        private int maxSize;
        private int top;

        public ArrayStack(int _maxSize)
        {
            top = 0;
            maxSize = _maxSize;
            items = new int[maxSize];
        }

        public void DestroyStack() 
        {
            top = 0;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public void Push(int newElement) 
        {
            if (top >= maxSize) 
            { 
                Console.WriteLine("Стек переполнен"); 
            }
            else 
            { 
                top++;
                items[top] = newElement;
            }
        }

        public void Pop() 
        {

            if (IsEmpty()) 
            { 
                Console.WriteLine("Стек пуст"); 
            }
            else 
            { 
                top--; 
            }
        }

        public void GetTop() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек пуст");
            }
            else
            {
                Console.WriteLine(items[top]);
            }
        }
    }
}
