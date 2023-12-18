/*Реализовать структуру классов.
Все классы должны переопределять виртуальный метод Live, хищники должны при этом охотиться если они голодны, травоядные есть траву.
Добавить для этого необходимые свойства.*/
using System;
using System.Runtime.CompilerServices;
namespace Les9Ex1
{    
    internal class Animal
    {
        protected bool isHungry;
        public Animal(bool isHungry)
        {
            this.isHungry = isHungry;
        }
        public virtual void Live()
        {
            isHungry = true;
            Console.WriteLine("Животное снова хочет кушать");            
        }
    }
    internal class HerbivoreAnimal : Animal
    {
        public HerbivoreAnimal(bool isHungry) : base(isHungry) { }
        public override void Live()
        {
            isHungry = true;
            Console.WriteLine("Травоядное снова хочет кушать");
        }
        public void EatGrass()
        {
            if (isHungry)
            {
                Console.WriteLine("Травоядное ест");
                isHungry = false;
            }
            else
            {
                Console.WriteLine("Травоядное не хочет есть");
            }
        }
    }
    internal class Predator: Animal
    {
        public Predator(bool isHungry) : base(isHungry) { }        
        public override void Live()
        {
            isHungry = true;
            Console.WriteLine("Хищник снова хочет кушать");
        }
        public void Bife()
        {
            if (isHungry)
            {
                Console.WriteLine("Хищник ест");
                isHungry = false;
            }
            else
            {
                Console.WriteLine("Хищник не хочет есть");
            }
        }

    }
    internal class Rabbit: HerbivoreAnimal 
    {
        private string nameAn;
        public Rabbit(bool isHungry, string nameAn) : base(isHungry) 
        {
            this.nameAn = nameAn; 
        }        
    }
    internal class Deer: HerbivoreAnimal 
    {
        private string nameAn;
        public Deer(bool isHungry, string nameAn) : base(isHungry)
        {
            this.nameAn = nameAn;
        }
    }
    internal class Wolf: Predator 
    {
        private string nameAn;
        public Wolf(bool isHungry, string nameAn) : base(isHungry)
        {
            this.nameAn = nameAn;
        }
    }
    internal class Bear: Predator 
    {
        private string nameAn;
        public Bear(bool isHungry, string nameAn) : base(isHungry)
        {
            this.nameAn = nameAn;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear(true, "Медведь 1");
            Deer deer = new Deer(true, "Олень 1");
            Rabbit rabbit = new Rabbit(true, "Кролик 1");
            Wolf wolf = new Wolf(true, "Волк 1");
            bear.Bife();
            bear.Bife();
            bear.Live();
            bear.Bife();
            Console.WriteLine();

            deer.EatGrass();
            deer.EatGrass();
            deer.Live();
            deer.EatGrass();
            Console.WriteLine();

            rabbit.EatGrass();
            rabbit.EatGrass();
            rabbit.Live();
            rabbit.EatGrass();
            Console.WriteLine();

            wolf.Bife();
            wolf.Bife();
            wolf.Live();
            wolf.Bife();
        }
    }
}
