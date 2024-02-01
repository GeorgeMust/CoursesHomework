using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Parallel.ForEach(numbers, number =>
        {
            int square = number * number;
            Console.WriteLine("Квадрат числа {0} равен {1}", number, square);
        });

        Console.ReadLine();
    }
}