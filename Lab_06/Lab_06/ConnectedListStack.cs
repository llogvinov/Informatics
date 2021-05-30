using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class ConnectedListStack
    {
        class StackNode
        {
            public string item;
            public StackNode next;
        }

        private StackNode top;
        public int count;

        public ConnectedListStack()
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
                StackNode node = top;
                top = top.next;
                node.next = null;
                node = null;
                count--;
            }
        }

        public void Push(string newItem)
        {
            StackNode temp = new StackNode();
            temp.item = newItem;
            temp.next = top;
            top = temp;
            count++;
        }

        public string GetTop()
        {
            if (IsEmpty())
            {
                return "Стек пуст";
            }
            else
            {
                return top.item;
            }
        }

    }
}
