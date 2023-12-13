/*Создайте метод расширения для массива int, который возвращает наибольший элемент.*/
namespace Les8Ex3
{    public static class IntMaxNumber
    {
        public static int IntMaxNum(this int[] intArr)
        {
            return intArr.Max();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 6, 3, 4, };
            Console.WriteLine(intArr.IntMaxNum());
        }

    }
}
