/*1.Создать метод выполняющий делегат Action в асинхронном режиме, 
метод передавать в качестве параметра, добавить возможность отмены через токен.*/
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace Lesson19Ex1
{
    internal class Program
    {
        static async Task Main()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;

            Task task = new Task(() =>
            {
                bool isContinue = true;
                token.Register(() =>
                {
                    Console.WriteLine("Операция прервана");
                    isContinue = false;
                });
                while (isContinue)
                {
                    Console.WriteLine("Задача выполняется...");
                    Thread.Sleep(500);
                }
            }, token);
            task.Start();

            Thread.Sleep(2000);
            cancelTokenSource.Cancel();
            Thread.Sleep(1000);
            Console.WriteLine($"Task Status: {task.Status}");
            cancelTokenSource.Dispose();
        }
    }
}
