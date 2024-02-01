using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Создание и запуск первого потока для вывода чисел
        Thread numbersThread = new Thread(PrintNumbers);
        numbersThread.Start();

        // Создание и запуск второго потока для вывода букв
        Thread lettersThread = new Thread(PrintLetters);
        lettersThread.Start();
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(500); // Пауза между выводом чисел
        }
    }

    static void PrintLetters()
    {
        for (char c = 'A'; c <= 'J'; c++)
        {
            Console.WriteLine(c);
            Thread.Sleep(500); // Пауза между выводом букв
        }
    }
}
