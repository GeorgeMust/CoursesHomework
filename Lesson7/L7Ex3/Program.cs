using System.Runtime.CompilerServices;

namespace Lesson7Ex3
{
    public class MyStack
    {
        private int hPoint;
        private int[] stackArr = new int[] { };
        public MyStack(int len)
        {
            this.stackArr = new int[len];
            this.hPoint = 0;
        }
        public void Push(int inpI)
        {
            stackArr[this.hPoint++] = inpI;
        }
        public int Pop()
        {
            int outI = stackArr[--this.hPoint];
            return outI;
        }
        public bool IsEmpty()
        {
            if (hPoint == 0)
            {
                return false;
            }
            return true;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack(3);
            myStack.Push(10);
            myStack.Push(15);
            myStack.Push(25);
            while (true)
            {
                if (myStack.IsEmpty())
                {
                    Console.WriteLine("Стек заполнен");
                    Console.WriteLine(myStack.Pop());
                }
                else
                {
                    Console.WriteLine("Стек пуст");
                    break;
                }
            }
        }
    }
}