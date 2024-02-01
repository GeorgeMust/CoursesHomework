using System;
using System.Threading;

class Program
{
    private static int sharedVariable = 0;
    private static Mutex mutex = new Mutex(); 

    static void Main()
    {
        Thread[] threads = new Thread[5];
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(IncrementSharedVariable);
            threads[i].Start();
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine("Конечное значение переменной: " + sharedVariable);
    }

    static void IncrementSharedVariable()
    {
        for (int i = 0; i < 10000; i++)
        {
            mutex.WaitOne();
            sharedVariable++; 
            mutex.ReleaseMutex();
        }
    }
}