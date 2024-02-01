using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread numbersThread = new Thread(PrintNumbers);
        numbersThread.Start();

        Thread lettersThread = new Thread(PrintLetters);
        lettersThread.Start();
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(500); 
        }
    }

    static void PrintLetters()
    {
        for (char c = 'A'; c <= 'J'; c++)
        {
            Console.WriteLine(c);
            Thread.Sleep(500); 
        }
    }
}
