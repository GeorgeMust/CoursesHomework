using System.Xml.Linq;

namespace ClassLibrary1
{
    public class ArrayWorker
    {
        string[] InpArr;
        public ArrayWorker(string[] InpArr)
        {
            this.InpArr = InpArr;
        }
        public string[] InversArr(string[] InpArr)
        {
            for (int i = InpArr.Length - 1, j = 0; j < i; i--, j++)
            {
                string forTime = InpArr[i];
                InpArr[i] = InpArr[j];
                InpArr[j] = forTime;
            }
            return InpArr;
        }
        public void Print()
        {
            for (int i = 0; i < InpArr.Length; i++)
            {
                Console.WriteLine($"{i + 1}-й элемент массива: {InpArr[i]}");
            }
        }
    }
}
