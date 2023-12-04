namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создать метод который рекурсивно находит n-е число ряда Фибоначи.
            пример использования Fibonacci(n), где n- это n-е по счету число Фибоначчи.*/
            Console.WriteLine("Введите число ряда Фибоначчи: ");
            Console.WriteLine(Fibonachi(InpStr()));
        }
        static int InpStr()
        {
            bool parseOk = false;
            while (!parseOk)
            {
                string? strIn = Console.ReadLine();
                if (int.TryParse(strIn, out int num))
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Введён неверный формат данных");
                }
            }
            return 0;
        }
        static int Fibonachi(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                int n1 = Fibonachi(num - 1);
                int n2 = Fibonachi(num - 2);
                return (n1 + n2);
            }
        }
    }
}
