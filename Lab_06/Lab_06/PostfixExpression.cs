using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    class PostfixExpression
    {
        private string op = "+-*/";
        private string data;
        private ConnectedListStack stack;
        private int f = 1;
        private double res;
        
        public PostfixExpression(string text)
        {
            data = text;
            stack = new ConnectedListStack();
        }
        
        public string GetStartExp()
        {
            return data;
        }
        
        private bool IsOperator(char inch)
        {
            return inch == '*' || inch == '/' ||
                inch == '+' || inch == '-';
        }
        
        private int Priority(char inch)
        {
            if (inch == '*' || inch == '/')
            {
                return 2;
            }
            if (inch == '+' || inch == '-')
            {
                return 1;
            }
            return 0;
        }
        
        public string ReversePostfix()
        {
            string postfix = null;
            ConnectedListStack mstack = new ConnectedListStack();
            foreach (char cur in data)
            {
                if (Char.IsDigit(cur))
                    postfix += cur;
                if (IsOperator(cur))
                {
                    if (mstack.count == 0 || mstack.GetTop() == "(")
                    { 
                        mstack.Push(Convert.ToString(cur)); 
                    }
                    else if (Priority(Char.Parse(mstack.GetTop())) < Priority(cur))
                    { 
                        mstack.Push(Convert.ToString(cur)); 
                    }
                    else if (Priority(Char.Parse(mstack.GetTop())) >= Priority(cur))
                    {
                        while (mstack.count != 0 && mstack.GetTop() != "("
                            && !(Priority(Char.Parse(mstack.GetTop())) < Priority(cur)))
                        {
                            postfix += mstack.GetTop();
                            mstack.Pop();
                        }
                        mstack.Push(Convert.ToString(cur));
                    }
                }
                if (Convert.ToString(cur) == "(")
                {
                    mstack.Push(Convert.ToString(cur));
                }
                if (Convert.ToString(cur) == ")")
                {
                    while (mstack.count != 0 && mstack.GetTop() != "(")
                    {
                        postfix += mstack.GetTop();
                        mstack.Pop();
                    }
                    if (mstack.GetTop() == "(")
                    {
                        mstack.Pop();
                    }
                }
            }
            while (mstack.count != 0)
            {
                postfix += mstack.GetTop();
                mstack.Pop();
            }
            data = postfix;
            return postfix;
        }
        
        public void Calc()
        {
            foreach (char x in data)
            {
                if (op.Contains(x))
                {
                    if (stack.count < 2)
                    {
                        Console.WriteLine("Ошибка");
                        f = 0;
                        break;
                    }
                    int op2 = Int32.Parse(stack.GetTop());
                    stack.Pop();
                    int op1 = Int32.Parse(stack.GetTop());
                    stack.Pop();
                    if (x == Char.Parse("+")) 
                    { 
                        res = op1 + op2;
                    }
                    else if (x == Char.Parse("-"))
                    {
                        res = op1 - op2;
                    }
                    else if (x == Char.Parse("*"))
                    {
                        res = op1 * op2;
                    }
                    else
                    {
                        res = op1 / op2;
                    }
                    stack.Push(Convert.ToString(res));
                }
                else
                {
                    stack.Push(Convert.ToString(x));
                }
            }
            if (stack.count == 1)
            {
                Console.WriteLine("Ответ: " + stack.GetTop());
            }
            else if (f == 1)
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
