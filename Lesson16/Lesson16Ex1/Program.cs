/*1.Дана целочисленная последовательность [-10, 22, 13, 43, -5, -12, 100].
Извлечь из нее все четные отрицательные числа, поменяв порядок извлеченных чисел на обратный.
*/
using System.Linq;
namespace Lesson16Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { -10, 22, 13, 43, -5, -12, 100 };
            var rezult = mass.Where(n => n <0 && n%2 == 0).Reverse();
            
            foreach (int n in rezult)
            {
                Console.WriteLine(n);
            }
        }
    }
}
