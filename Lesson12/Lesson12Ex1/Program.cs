namespace Lesson12Ex1
{
    public abstract class Animal
    {
        protected string name = "";
        protected int numOfLegs;
        public void setName(string name) 
        { 
            this.name = name;
        }
        public string getName() 
        {
            return this.name;
        }
        public void setNumOfLegs(int legs)
        {
            this.numOfLegs = legs;
        }
        public int getNumOfLegs()
        {
            return this.numOfLegs;
        }
        public virtual void displayAnimal()
        {
            Console.WriteLine("Animal");
        }
    }
    public class Cat: Animal, ICarnivore
    {
        private string sound;
        private string color;
        public string typeC { get; }
        public string foodC { get; }

        public Cat(string sound, string color): base()
        {
            this.sound = sound;
            this.color = color;
            this.typeC = "Кот";
            this.foodC = "Консервы";
        }
        public void displayEatC()
        {
            Console.WriteLine(foodC);
        }
        public override void displayAnimal()
        {
            Console.WriteLine(typeC);
        }
    }
    public class Bear: Animal, ICarnivore, IHerbivore
    {
        private string sound;
        private string color;
        public string typeH { get; }
        public string foodH { get; }
        public string typeC { get; }
        public string foodC { get; }
        public Bear(string sound, string color): base()
        {
            this.sound = sound;
            this.color = color;
            this.typeH = "Медведь";
            this.foodH = "Малина";
            this.typeC = "Медведь";
            this.foodC = "Мясо";
        }
        public void displayEatH()
        {
            Console.WriteLine(foodH);
        }
        public void displayEatC()
        {
            Console.WriteLine(foodC);
        }
        public override void displayAnimal()
        {
            Console.WriteLine(typeC);
        }
    }
    public class Elephant: Animal, IHerbivore, IEquatable
    {
        private string sound;
        private string color;
        public double size;

        public string typeH { get; }
        public string foodH { get; }
        public bool MyEquals(double other)
        {
            if(other == this.size)
            {
                return true;
            }
            else
            {
                if(this.size < other)
                {
                    Console.WriteLine("Размер слона " + this.name + " меньше " + other);
                }
                else
                {
                    Console.WriteLine("Размер слона " + this.name + " больше " + other);
                }
                return false;
            }
        }
        public Elephant(string sound, string color, double size) : base()
        {
            this.sound = sound;
            this.color = color;
            this.typeH = "Слон";
            this.foodH = "Листья";
            this.size = size;
        }
        public void displayEatH()
        {
            Console.WriteLine(foodH);
        }
        public override void displayAnimal()
        {
            Console.WriteLine(typeH);
        }        
    }

    public interface ICarnivore
    {
        public string typeC { get; }
        public string foodC { get; }
        public void displayEatC();
    }
    public interface IHerbivore
    {
        public string typeH { get; }
        public string foodH { get; }
        public void displayEatH();
    }
    public interface IEquatable
    {
        public bool MyEquals(double other);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant1 = new Elephant("Гудок", "Серый", 3.2);
            elephant1.setName("El1");
            elephant1.displayAnimal();
            Console.WriteLine(elephant1.getName());
            elephant1.displayEatH();

            Elephant elephant2 = new Elephant("Гудок", "Светло-Серый", 3.4);
            elephant2.setName("El2");
            elephant2.displayAnimal();
            Console.WriteLine(elephant2.getName());
            elephant2.displayEatH();

            if (elephant1.MyEquals(elephant2.size))
            {
                Console.WriteLine("Размеры слонов равны");
            }
            else
            {
                Console.WriteLine("Размеры слонов не равны");
            }

            Bear bear = new Bear("Рык", "Бурый");
            bear.setName("Bear1");
            bear.displayAnimal();
            Console.WriteLine(bear.getName());
            bear.displayEatH();
            bear.displayEatC();

            Cat cat = new Cat("Мяукает", "Рыжий");
            cat.setName("Myau");
            cat.displayAnimal();
            Console.WriteLine(cat.getName());
            cat.displayEatC();
        }
    }
}
