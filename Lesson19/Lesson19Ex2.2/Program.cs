namespace Lesson19Ex2._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int time = 2000;
            RunTaskWithAwaiter(time).GetAwaiter().GetResult();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        public static Task RunTaskWithAwaiter(int time)
        {
            return Task.Delay(time).ContinueWith(_ => Console.WriteLine("Hello from callback"));
        }
    }
}
