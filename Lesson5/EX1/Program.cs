namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создать метод который выводит в консоль таблицу умножения для конкретного числа. 
            Входными парраметрами метода являются число которое нужно умножать и максимальное число 
            на которое мы умножаем. 
            Например: первый параметр =3, второй тоже 3.
            Результат 
            3x1 = 3
            3x2 = 6
            3x3 = 9
            Использовать циклы.
            Добавить изменения в git repository.*/
            int frst_number, max_number;
            Console.WriteLine("Введите число, которое нужно умножать: ");
            frst_number = InpStr();
            Console.WriteLine("Введите максимальное число, на которое мы умножаем: ");
            max_number = InpStr();
            Multply(frst_number, max_number);
        }
        static int Multply(int first_num, int max_num)
        {
            for (int i = 1; i <= max_num; i++)
            {
                Console.WriteLine($"{first_num}*{i} = {(first_num * i)}", first_num, i);
            }
            return 0;
        }
        static int InpStr()
        {

            bool parseOk = false;
            while (!parseOk)
            {
                string? strInput = Console.ReadLine();
                if (int.TryParse(strInput, out int num))
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Неверный формат данных");
                }
            }
            return 0;
        }
    }
}
