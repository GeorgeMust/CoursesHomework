namespace EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите факториал: ");
            Console.WriteLine(Factorial(InpStr()));
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
        static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else if (num == 1)
            {
                return 1;
            }
            else
            {
                int n1 = Factorial(num - 1);
                return (n1 * num);
            }
        }
    }
}
