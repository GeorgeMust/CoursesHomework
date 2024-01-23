/*Создать свой метод LINQ, Median, метод должен быть методом расширения, и он должен возвращать элемент перечисления находящийся в середине.*/
namespace Lesson16Ex5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LinqExtensions
    {
        public static T Median<T>(this IEnumerable<T> source)
        {
            if (source == null || !source.Any())
            {
                throw new InvalidOperationException("Перечисление не содержит элементов.");
            }
            int count = source.Count();

            int middleIndex = count / 2;

            var sortedSource = source.OrderBy(item => item);

            return sortedSource.ElementAt(middleIndex);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5 };

            int median = numbers.Median();

            Console.WriteLine($"Медиана: {median}");
        }
    }
}