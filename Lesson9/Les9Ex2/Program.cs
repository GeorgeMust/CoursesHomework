/*Реализовать класс Зоопарк (Zoo), класс должен уметь принимать животное и в зависимости от его типа отправлять его в загон для хищников и в загон для травоядных.
Используйте проверки типов, метод должен принимать аргумент типа Animal.*/
namespace Les9Ex2
{
    enum typeEat: int
    {
        Predator = 0,
        Herbivor
    }
    internal class Zoo
    {
       private int cntrPredators = 0, cntrHerbivors = 0;
        private Animal[] predators, herbivors;
        public Zoo(int sizePredators, int sizeHerbivors)
        {
            predators = new Animal[sizePredators];
            herbivors = new Animal[sizeHerbivors];
        }
        public void anType(Animal animal)
        {
            if(animal.GetTypeAnimal() == (int)typeEat.Predator)
            {
                predators[cntrPredators++] = animal;
                Console.WriteLine("Взагон для хищников помещено " + cntrPredators + " животных");
            }
            else if(animal.GetTypeAnimal() == (int)typeEat.Herbivor)
            {
                herbivors[cntrHerbivors++] = animal;
                Console.WriteLine("В загон для травоядных помещено " + cntrHerbivors + " животных");
            }
        }
    }
    internal class Animal
    {
        private int typeAnimal;  
        public Animal(int typeAnimal)
        {
            this.typeAnimal = typeAnimal;
        }
        public int GetTypeAnimal()
        {
            return this.typeAnimal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo(3, 3);
                        
            Animal animal1 = new Animal((int)typeEat.Predator);
            Animal animal2 = new Animal((int)typeEat.Predator);
            Animal animal3 = new Animal((int)typeEat.Herbivor);
            zoo.anType(animal1);
            zoo.anType(animal2);
            zoo.anType(animal3);
        }
    }
}
