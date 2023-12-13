/*Реализовать структуру классов : Engine(содержит метод для включения двигателя), Transport(абстрактный класс), Car, Plane, абстрактные члены: 
свойство типа Engine 
метод Move. 
Переопределение Move должно вызывать приватную логику движения наследников и включать двигатель.*/
using System.Buffers;

namespace Les8Ex2
{
    abstract class Transport
    {        
        public abstract void Move();
        public Engine engine { get; set; } = new Engine();
    }
    public class Engine
    {
        private string onAct = "Двигатель выключен";
        public void OnEng()
        {
            this.onAct = "Двигатель включен";
            Console.WriteLine(this.onAct);
        }
    }
    internal class Car: Transport
    {
        public override void Move()
        {
            engine.OnEng();
            Console.WriteLine("Машина едет");            
        }
    }
    internal class Plane: Transport
    {
        public override void Move()
        {
            engine.OnEng();
           Console.WriteLine("Самолёт летит");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
        //    car.engine = new Engine();
            car.Move();
            Plane plane = new Plane();
            plane.Move();
         }
    }
}
