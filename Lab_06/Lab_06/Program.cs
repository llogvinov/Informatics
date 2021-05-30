using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание ограниченного стека в виде массива");
            ArrayStack arrayStack = new ArrayStack(5);
            arrayStack.Push(2);
            arrayStack.Push(5);
            arrayStack.GetTop();
            arrayStack.Pop();
            arrayStack.GetTop();
            arrayStack.DestroyStack();
            arrayStack.GetTop();
            Console.WriteLine("_____________________________________");

            Console.WriteLine("Создание стека в виде связанного списка");
            ConnectedListStack conStack = new ConnectedListStack();
            conStack.GetTop();
            conStack.Push("2");
            Console.WriteLine("Stack top = " + conStack.GetTop());
            conStack.Push("3");
            Console.WriteLine("Stack top = " + conStack.GetTop());
            conStack.Push("5");
            Console.WriteLine("Stack top = " + conStack.GetTop());
            conStack.Pop();
            Console.WriteLine("Stack top = " + conStack.GetTop());
            conStack.Pop();
            Console.WriteLine("Stack top = " + conStack.GetTop());
            Console.WriteLine("_____________________________________");

            Console.WriteLine("Создание ограниченной очереди");
            Queue queue = new Queue(5);
            queue.EnQueue(3);
            queue.EnQueue(2);
            queue.EnQueue(1);
            queue.GetFront();
            Console.WriteLine("Удаление первого элемента в очереди");
            queue.DeQueue();
            queue.GetFront();
            Console.WriteLine("_____________________________________");

            Console.WriteLine("Создание односвязного списка");
            LinkedList list = new LinkedList();
            list.Insert(0, 1);
            list.Insert(1, 2);
            list.Insert(2, 3);
            list.PrintList();
            Console.WriteLine("Удаление элемента под индексом 2");
            list.Remove(2);
            list.PrintList();
            Console.WriteLine("_____________________________________");

            Console.WriteLine("Создание двусвязного списка");
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            DoubleLinkedList ddl = new DoubleLinkedList();
            ddl.InsertStart(n1);
            ddl.InsertEnd(n4);
            ddl.InsertAfter(n1, n2);
            ddl.InsertBefore(n4, n3);
            ddl.PrintDLL();
            ddl.Remove(n1);
            Console.WriteLine("Удаление элемента под индексом 0");
            ddl.PrintDLL();
            Console.WriteLine("_____________________________________");

            Console.WriteLine("Создание кольцевого односвязного списка");
            CycledLinkedList cll = new CycledLinkedList();
            cll.Insert(1);
            cll.Insert(2);
            cll.Insert(3);
            cll.PrintCLL(2);
            Console.WriteLine("_____________________________________");

            Console.WriteLine("Вычисление постфиксных выражений.");
            PostfixExpression exp = new PostfixExpression(" 2*(3+2)*((5*2-8)+(6-2*2))");
            Console.WriteLine("Инфиксное выражение: " + exp.GetStartExp());
            Console.WriteLine("Постиксное выражение: " + exp.ReversePostfix());
            exp.Calc();

            Console.ReadLine();
        }
    }
}
