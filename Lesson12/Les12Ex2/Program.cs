//Используя структуру из 1 создать класс Zoo который может принимать плотоядных животных в один загон, а травоядных в другой, использовать интерфейсы.
using Lesson12Ex1;
namespace Lesson12Ex2
{
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
            if (animal is ICarnivore)
            {
                predators[cntrPredators++] = animal;
                Console.WriteLine("Взагон для хищников помещено " + cntrPredators + " животных");
            }
            else if (animal is IHerbivore)
            {
                herbivors[cntrHerbivors++] = animal;
                Console.WriteLine("В загон для травоядных помещено " + cntrHerbivors + " животных");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo(3, 3);

            Elephant elephant = new Elephant("Гудок", "Серый", 3.2);
            elephant.setName("El1");
            elephant.displayAnimal();
            Console.WriteLine(elephant.getName());
            elephant.displayEatH();

            zoo.anType(elephant);

            Bear bear = new Bear("Рык", "Бурый");
            bear.setName("Bear1");
            bear.displayAnimal();
            Console.WriteLine(bear.getName());
            bear.displayEatH();
            bear.displayEatC();

            zoo.anType(bear);

            Cat cat = new Cat("Мяукает", "Рыжий");
            cat.setName("Myau");
            cat.displayAnimal();
            Console.WriteLine(cat.getName());
            cat.displayEatC();

            zoo.anType(cat);
        }
    }
}
