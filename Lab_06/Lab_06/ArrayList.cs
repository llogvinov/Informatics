using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class ArrayList
    {
        class StackNode
        {
            public int item;
            public StackNode next;
        }

        private StackNode top;
        public int count;
        
        public ArrayList()
        {
            top = null;
            count = 0;
        }

        private bool IsEmpty()
        {
            return top == null;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек пуст");
            }
            else
            {
                StackNode temp = top;
                top = top.next;
                temp.next = null;
                temp = null;
                count--;
            }
        }

        public void Push(int newElement)
        {
            StackNode temp = new StackNode();
            temp.item = newElement;
            temp.next = top;
            top = temp;
            count++;
        }

        public int GetTop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек пуст");
                return 0;
            }
            else
            {
                return top.item;
            }
        }

    }
}
