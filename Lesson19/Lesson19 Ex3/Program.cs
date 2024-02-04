/*3. Создать класс Пиццерия, класс должен иметь возможность создавать пиццу в асинхронном режиме,
но количество доступных для созданий пицц зависит от количество его работников(рассмотреть возможность работы с блокираторами(симафор))
Асинхронный метод создающий пиццу должен внутри иметь задержку имитирующую приготовление пиццы.*/
namespace Lesson19_Ex3
{
    public class Pizzeria
    {
        public int quantityWorkers;
        public Pizzeria(int quantityWorkers)
        {
            this.quantityWorkers = quantityWorkers;
        }    
    }
    internal class Program
    {
        private static Semaphore sem;
        static void Main(string[] args)
        {
            int quantityPizz = 15;
            Pizzeria pizzeria = new Pizzeria(3);
            sem = new Semaphore(pizzeria.quantityWorkers, pizzeria.quantityWorkers);
            for (int i = 1; i <= quantityPizz; i++)
            {
                Thread t = new Thread(new ParameterizedThreadStart(Worker));

                t.Start(i);
                Thread.Sleep(250);
            }
        }
        private static void Worker(object num)
        { 
            sem.WaitOne();

            Console.WriteLine("Повар готовит пиццу {0}", num);

            Thread.Sleep(1000);

            Console.WriteLine("Повар приготовил пиццу {0}", num);
            sem.Release();
        }
    }
}
