using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class Node_CLL
    {
        public int data;
        public Node_CLL next;

        public Node_CLL(int _data)
        {
            data = _data;
        }
    }

    class CycledLinkedList
    {
        private Node_CLL head;
        public int count;

        public CycledLinkedList()
        {
            head = null;
            count = 0;
        }

        public void Insert(int data)
        {
            Node_CLL curr = new Node_CLL(data);
            Node_CLL ptr = head;
            curr.next = head;
            if (head != null)
            {
                while (ptr.next != head)
                {
                    ptr = ptr.next;
                }
                ptr.next = curr;
            }
            else
            {
                curr.next = curr;
            }
            head = curr;
        }

        //n - количество элементов в цилкическом списке
        public void PrintCLL(int n)
        {
            Node_CLL ptr = head;
            int k = 0;
            do
            {
                Console.Write(ptr.data + " ");
                k++;
                ptr = ptr.next;
            }
            while (k != n + 1);
            Console.WriteLine();
        }

    }
}
