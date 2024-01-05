namespace Lesson12Ex1
{
    abstract class Animal
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
    internal class Cat: Animal, ICarnivore
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
    internal class Bear: Animal, ICarnivore, IHerbivore
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
    internal class Elephant: Animal, IHerbivore
    {
        private string sound;
        private string color;

        public string typeH { get; }
        public string foodH { get; }

        public Elephant(string sound, string color): base()
        {
            this.sound = sound;
            this.color = color;
            this.typeH = "Слон";
            this.foodH = "Листья";
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant("Гудок", "Серый");
            elephant.setName("El1");
            elephant.displayAnimal();
            Console.WriteLine(elephant.getName());
            elephant.displayEatH();

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
