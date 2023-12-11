using ClassLibrary1;

namespace Les7Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте ClassLibrary с типом ArrayWorker, который будет уметь принимать массив, инвертировать его и возвращать.
             * Массив передаем сами явно в метод, а не через консоль.*/

            string[] firstArr = { "abs", "abt", "prt" };
            ArrayWorker arrayWorker = new ArrayWorker(firstArr);
            arrayWorker.InversArr(firstArr);
            arrayWorker.Print();
        }
    }
}