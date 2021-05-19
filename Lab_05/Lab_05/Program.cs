using System;
using System.Collections.Generic;

namespace Lab_05
{
    class Node
    {
        public char value;
        public Node Right;
        public Node Left;
    }

    class Tree
    {
        public Node Root;
        
        public void direct(Node node)
        {
            Console.Write(node.value);
            if (node.Left != null) 
                direct(node.Left);
            if (node.Right != null) 
                direct(node.Right);
        }

        public void reverse(Node node)
        {
            if (node.Left != null) 
                reverse(node.Left);
            Console.Write(node.value);
            if (node.Right != null) 
                reverse(node.Right);
        }

        public void terminal(Node node)
        {
            if (node.Left != null) 
                terminal(node.Left);
            if (node.Right != null) 
                terminal(node.Right);
            Console.Write(node.value);
        }

        public void terminalParse(Node node, List<string> list)
        {
            if (node.Left != null) 
                terminalParse(node.Left, list);
            if (node.Right != null) 
                terminalParse(node.Right, list);
            list.Add(node.value.ToString());
        }

        public int Solve()
        {
            List<string> symbols = new List<string>() { "*", "/", "+", "-" };
            List<string> buff = new List<string>();
            terminalParse(Root, buff);
            int i = 0;
            while (buff.Count != 1)
            {
                if (symbols.Contains(buff[i]))
                {
                    int result = 0;
                    switch (buff[i])
                    {
                        case "+":
                            result = int.Parse(buff[i - 2]) + int.Parse(buff[i - 1]);
                            break;
                        case "-":
                            result = int.Parse(buff[i - 2]) - int.Parse(buff[i - 1]);
                            break;
                        case "*":
                            result = int.Parse(buff[i - 2]) * int.Parse(buff[i - 1]);
                            break;
                        case "/":
                            result = int.Parse(buff[i - 2]) / int.Parse(buff[i - 1]);
                            break;
                    }
                    buff[i] = result.ToString();
                    buff.RemoveAt(i - 2);
                    i--;
                    buff.RemoveAt(i - 1);
                    i--;
                    foreach (string a in buff) 
                        Console.Write(a);
                    Console.WriteLine();
                }
                i++;
            }
            return int.Parse(buff[0]);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            #region firstTask
            Console.WriteLine("Task 1:");
            Node D = new Node() { value = 'd' };
            Node E = new Node() { value = 'e' };
            Node F = new Node() { value = 'f' };
            Node B = new Node() { value = 'b', Right = E, Left = D };
            Node C = new Node() { value = 'c', Right = F };
            Node A = new Node() { value = 'a', Right = C, Left = B };
            
            Tree tree = new Tree() { Root = A };
            tree.direct(tree.Root);
            Console.WriteLine();
            tree.reverse(tree.Root);
            Console.WriteLine();
            tree.terminal(tree.Root);
            Console.WriteLine();
            #endregion

            #region secondTask
            Console.WriteLine("\nTask 2:");
            Node a = new Node() { value = '2' };
            Node b = new Node() { value = '3' };
            Node c = new Node() { value = '7' };
            Node d = new Node() { value = '4' };
            Node e = new Node() { value = '3' };
            Node f = new Node() { value = '+', Left = a, Right = b };
            Node g = new Node() { value = '-', Left = c, Right = d };
            Node h = new Node() { value = '*', Left = f, Right = g };
            Node i = new Node() { value = '/', Left = h, Right = e };

            Tree equation = new Tree() { Root = i };
            equation.terminal(equation.Root);

            Console.WriteLine();
            Console.WriteLine("Result: " + equation.Solve());
            Console.ReadLine();
            #endregion
        }

    }
}

