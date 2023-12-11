using ClassLibrary2;

namespace Zadan2Les7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте ClassLibrary с типом Cone.Конструктор типа принимает 2 параметра: радиус(r) и высоту(h). 
             * Так же в типе есть два метода, которые рассчитывают площадь поверхности основания и полную площадь.*/

            Cone cone = new Cone(3, 4);
            Console.WriteLine("Площадь основания конуса: " + cone.CalcSground());
            Console.WriteLine("Полная площадь конуса: " + cone.CalcSfull());
        }
    }
}