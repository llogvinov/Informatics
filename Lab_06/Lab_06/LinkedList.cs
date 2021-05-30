using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class LinkedList
    {
        private int maxSize = 100;
        public int last;
        public int[] items;

        public LinkedList()
        {
            last = 0;
            items = new int[maxSize];
        }

        public void Insert(int n, int newElement)
        {
            if (last >= 100)
            {
                Console.WriteLine("Список полон");
            }
            else
            {
                if (n > this.last || n < 0)
                {
                    Console.WriteLine("Такой позиции нет");
                }
                else
                {
                    for (int i = last; i >= n; i--)
                    {
                        items[i + 1] = items[i];
                    }
                    last = last + 1;
                    items[n] = newElement;
                }
            }
        }

        public void Remove(int n)
        {
            if (n > last || n < 1)
            {
                Console.WriteLine("Такой позиции нет");
            }
            else
            {
                last = last - 1;
                for (int i = n; i < last; i++)
                {
                    items[i] = items[i + 1];
                }
            }
        }

        public int Find(int x)
        {
            return Array.IndexOf(items, x);
        }

        public void PrintList()
        {
            Console.Write("Имеющийся лист: ");
            for (int i = 0; i < last; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
