using System.Runtime.CompilerServices;

namespace Lesson7Ex3
{
    public class MyQueue
    {
        private int pBegin;
        private int pEnd;
        private int[] queueArr = new int[] { };
        public MyQueue(int len)
        {
            this.queueArr = new int[len];
            this.pBegin = 0;
            this.pEnd = 0;
        }
        public void Push(int inpI)
        {
            queueArr[this.pEnd++] = inpI;
            if (this.pEnd == this.queueArr.Length)
            {
                this.pEnd = 0;
            }
        }
        public int Pop()
        {
            int outI = queueArr[this.pBegin++];
            if (this.pBegin == this.queueArr.Length)
            {
                this.pBegin = 0;
            }
            return outI;
        }
        public bool IsEmpty()
        {
            if (this.pEnd == this.pBegin)
            {
                return false;
            }
            return true;
        }
        public int Size()
        {
            return ((this.pEnd - this.pBegin + queueArr.Length) % queueArr.Length);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue(5);
            myQueue.Push(1);
            myQueue.Push(2);
            myQueue.Push(3);
            while (true)
            {
                if (myQueue.IsEmpty())
                {
                    Console.WriteLine("Размер очереди: " + myQueue.Size() + " элемент: " + myQueue.Pop());
                }
                else
                {
                    Console.WriteLine("Очередь пуста");
                    break;
                }
            }
            myQueue.Push(4);
            myQueue.Push(5);
            myQueue.Push(6);
            while (true)
            {
                if (myQueue.IsEmpty())
                {
                    Console.WriteLine("Размер очереди: " + myQueue.Size() + " элемент: " + myQueue.Pop());
                }
                else
                {
                    Console.WriteLine("Очередь пуста");
                    break;
                }
            }
        }
    }
}
