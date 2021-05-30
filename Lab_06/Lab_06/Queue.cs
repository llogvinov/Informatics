using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class Queue
    {
        private int[] items;
        private int maxSize;
        private int front;
        private int rear;
        private int count;

        public Queue(int _maxSize)
        {
            front = 0;
            rear = -1;
            maxSize = _maxSize;
            items = new int[maxSize];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public void EnQueue(int newElement)
        {
            if (count == maxSize)
            {
                Console.WriteLine("Очередь полна");
            }
            else
            {
                rear = (rear + 1) % maxSize;
                items[rear] = newElement;
                count++;
            }
        }

        public void DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Очерень пуста");
            }
            else
            {
                front = (front + 1) % maxSize;
                count--;
            }
        }

        public void GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Очерень пуста");
            }
            else
            {
                Console.WriteLine("Первый элемент очереди: " + items[front]);
            }
        }

    }
}
