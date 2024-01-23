/*2.Дана последовательность непустых строк A . ["Hello", "here", "we", "are"]. Получить последовательность символов, каждый элемент которой является начальным символом соответствующей строки
из A. Порядок символов должен быть обратным по отношению к порядку элементов исходной последовательности.*/
namespace Lesson16_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] posled = new string[] { "Hello", "here", "we", "are" };
            var rezultPosled = from n in posled
                               select n.First();
            rezultPosled = rezultPosled.Reverse();
            foreach (var n in rezultPosled) { Console.WriteLine(n); }
        }
    }
}
