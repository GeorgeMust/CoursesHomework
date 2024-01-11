/*Написать метод который будет принимать массив слов и возвращать итератор(использовать yield return). Метод должен возвращать только слова длинна которых больше 5 символов.

Использовать метод внутри foreach добавив в него массив из 3 рандомных слов. 
Слова нужно генерировать методом, который принимает количество слов как параметр и вытягивает значения из словаря в рандомном порядке. 
Реализовать словарь Dictionary<int, string> как внутренний словарь метода, он должен содержать 10 записей.*/
namespace Lesson13Ex1
{
    internal class Program
    {
        private static IEnumerable<int> WordOut(string[] arrWords)
        {
            for (int i = 0; i < arrWords.Length; i++)
            {
                if ((arrWords[i]).Length > 5)
                {
                    yield return i;
                }
            }
        }
        private static string[] WordGet(int countWords)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>
            {
                {1, "lebro1" },
                {2, "lebro2" },
                {3, "lebro3" },
                {4, "leo" },
                {5, "lebr" },
                {6, "lebro6" },
                {7, "lebro7" },
                {8, "lebro8" },
                {9, "lebro9" },
                {10, "lebro10" }
            };

            Random random = new Random();
            string[] arrWords = new string[3];

            for (int j = 0; j < countWords; j++)
            {
                myDictionary.TryGetValue(random.Next(1, 10), out string result);
                arrWords[j] = result;
            }
            return arrWords;
        }

        static void Main()
        {
            string[] arrWords = WordGet(3);
            foreach (int word in WordOut(arrWords))
            {
                Console.Write((word).ToString() + ": " + arrWords[word] + " ");
            }
        }
    }
}