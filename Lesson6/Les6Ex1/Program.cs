namespace lesson6Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создать метод принимающий массив и строку, метод должен проверить параметры, если 
            они невалидны вернуть null.
            Если валидны, проверить что в массиве есть место и добавить туда значение.
            Если места нет, создать массив большей длинны и добавить туда новое значение.(старые значения тоже
            сохраняются!). В случае если массив уже содержит данное значение, новое значение не возвращать, вернуть исходный массив( проверка равенства не должна учитывать регистр). Если сложно реализовать задание, создать блок схему алгоритма и прислать мне.*/
            Console.WriteLine("Введите строку: ");
            string? inStr = Console.ReadLine();
            Console.WriteLine("Введите длину массива: ");
            string?[] arrNewIn = new string[lenIn()];
            for (int i = 0; i < arrNewIn.Length; i++)
            {
                Console.WriteLine("Введите " + i + "-й элемент массива: ");
                arrNewIn[i] = Console.ReadLine();
            }
            arrNewIn = RezultStr(arrNewIn, inStr);
            if (arrNewIn != null)
            {
                Console.WriteLine("Массив:");
                for (int i = 0; i < arrNewIn.Length; i++)
                {
                    Console.WriteLine(arrNewIn[i]);
                }
            }
            else
            {
                Console.WriteLine("Результирующий массив пуст");
            }
        }
        static string?[] RezultStr(string?[] arr, string? str)
        {
            if (!(arr == null) && !(String.IsNullOrEmpty(str)))
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    string str1 = str;
                    string str2 = arr[i];

                    if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase))
                    {
                        return arr;
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (String.IsNullOrEmpty(arr[i]))
                    {
                        arr[i] = str;
                        return arr;
                    }
                    else if (i == (arr.Length - 1))
                    {
                        /*string?[] arrNew = new string[arr.Length + 1];
                        for (int j = 0; j < arrNew.Length-1; j++)
                        {
                            arrNew[j] = arr[j];
                        }
                        arrNew[arr.Length] = str;*/
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = str;
                        return arr;
                    }
                }
            }
            return null;
        }
        static int lenIn()
        {
            bool parseOk = false;
            while (!(parseOk))
            {
                string? strInp = Console.ReadLine();
                if (int.TryParse(strInp, out int num))
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Неверная длина массива: {0}", strInp);
                }
            }
            return 0;
        }
    }
}
