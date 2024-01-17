/*Создать консольное приложение, приложение просит пользователя ввести два значения [0-255], и затем возвращает в консоль результат деления первого числа на второе. Использовать метод int.Parse. Какие исключения могут возникнуть? Добавить обработку исключений в приложение.
      Создать ситуацию при котором придется обрабатывать исключения.*/
namespace testft
{
    public class NumberOutOfRange : Exception
    {
        public NumberOutOfRange(string message) : base(message)
        {

        }
    }
    public class ParseFailed : Exception
    {
        public ParseFailed(string message) : base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int chisl = 0;
            int znamen = 0;
            int div = 0;
            try
            {
                Console.Write("Введите делимое: ");
                InpInt(ref chisl);
                Console.Write("Введите делитель: ");
                InpInt(ref znamen);
                try
                {
                    if (znamen == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль");
                    }
                    div = chisl / znamen;

                    Console.WriteLine("Результат деления: " + div);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch (NumberOutOfRange ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Введено делимое: " + chisl + " делитель: " + znamen);
            }
        }
        static void InpInt(ref int value)
        {
            value = ConvToInt();
            if (value < 0 || value > 255)
            {
                throw new NumberOutOfRange("Выходит за заданный диапазон");
            }
        }
        static int ConvToInt()
        {
            int rezult = 0;
            bool parseOk = false;
            while (!parseOk)
            {
                try
                {
                    string? str = Console.ReadLine();
                    if (int.TryParse(str, out int value))
                    {
                        rezult = value;
                        parseOk = true;
                    }
                    else
                    {
                        throw new ParseFailed("Ошибка преобразования");
                    }
                }
                catch (ParseFailed ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return rezult;
        }
    }
}

