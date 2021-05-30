using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int data)
        {
            this.data = data;
        }
    }

    class DoubleLinkedList
    {
        private Node first;
        private Node last;
        public int count;

        public DoubleLinkedList()
        {
            first = null;
            last = null;
            count = 0;
        }

        public void InsertAfter(Node ref_node, Node new_node)
        {
            new_node.prev = ref_node;
            if (ref_node.next == null)
            {
                last = new_node;
            }
            else
            {
                new_node.next = ref_node.next;
                new_node.next.prev = new_node;
            }
            ref_node.next = new_node;
            count++;
        }

        public void InsertBefore(Node ref_node, Node new_node)
        {
            new_node.next = ref_node;
            if (ref_node.prev == null)
            {
                first = new_node;
            }
            else
            {
                new_node.prev = ref_node.prev;
                new_node.prev.next = new_node;
            }
            ref_node.prev = new_node;
            count++;
        }

        public void InsertStart(Node new_node)
        {
            if (first == null)
            {
                first = new_node;
                last = new_node;
                count++;
            }
            else
                InsertBefore(first, new_node);
        }

        public void InsertEnd(Node new_node)
        {
            if (last == null)
            {
                last = new_node;
                first = new_node;
                count++;
            }
            else
            {
                InsertAfter(last, new_node);
            }
        }
        
        public void Remove(Node node)
        {
            if (node.prev == null)
            {
                first = node.next;
            }
            else
            {
                node.prev.next = node.next;
            }
            if (node.next == null)
            {
                last = node.prev;
            }
            else
            {
                node.next.prev = node.prev;
            }
            count--;
        }

        public void PrintDLL()
        {
            Console.Write("Имеющийся двусвязный список: ");
            Node current = first;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}