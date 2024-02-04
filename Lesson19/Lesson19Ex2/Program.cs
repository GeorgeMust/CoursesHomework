/*2.Создать метод принимающий величину милисекунд time,и запускающий задачу которая через определенное время(равное параметру time) выполняет вывод в консоль
строки "Hello from callback" посредством продолжения. Попробовать сделать это через awaiter и через ContinueWith*/
using System;
using System.Threading.Tasks;
namespace Lesson19Ex2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            int time = 2000;
            await RunCallbackAfterDelay(time);            

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        public static async Task RunCallbackAfterDelay(int time)
        {
            await Task.Delay(time);
            Console.WriteLine("Hello from callback");
        }
    }
}
