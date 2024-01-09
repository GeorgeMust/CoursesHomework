/*Создать класс Person, со свойствами возраст, пол(enum).
Создать коллекцию людей и добавить туда 10 человек, 5 девушек, 5 мужчин.
Попробовать отсортировать коллекцию методом Sort.
List<Person> listOfPerson = new List<Person>();
listOfPerson.Sort();
Реализовать интерфейс IComparable<Person> , девушки должны быть перед мужчинами, возраст в порядке возрастания.
Сделать тоже самое с помощью отдельного сортировщика PersonComparer, это класс реализующий интерфейс IComparer<Person?>
Пример сортировки:
Array.Sort(collection, new PersonComparer());*/
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;

namespace Lesson12Ex4
{
    enum Gender
    {
        Male,
        Female
    }
    internal class Person :  IComparable<Person>
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        internal Person(int Age, Gender Gender)
        {
            this.Age = Age;
            this.Gender = Gender;
        }
        public override string ToString()
        {
            return $"Возраст: {Age}   Пол: {Gender}";
        }
        public int CompareTo(Person comparePart)
        {
            if (comparePart == null)
            {
                return 1;
            }
            else
            {
                if ((comparePart.Gender == Gender.Male && this.Gender == Gender.Female) || (this.Age < comparePart.Age && this.Gender == comparePart.Gender))
                {
                    return -1;
                }               
                else if(this.Age > comparePart.Age)
                {
                    return 1;
                }
                return 0;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person man1 = new Person(32, Gender.Male);
            Person man2 = new Person(31, Gender.Male);
            Person man3 = new Person(30, Gender.Male);
            Person man4 = new Person(22, Gender.Male);
            Person man5 = new Person(34, Gender.Male);

            Person woman1 = new Person(31, Gender.Female);
            Person woman2 = new Person(34, Gender.Female);
            Person woman3 = new Person(33, Gender.Female);
            Person woman4 = new Person(35, Gender.Female);
            Person woman5 = new Person(22, Gender.Female);


            List<Person> listOfPerson = new List<Person>();

            listOfPerson.Add(man1);
            listOfPerson.Add(man2);
            listOfPerson.Add(man3);
            listOfPerson.Add(woman4);
            listOfPerson.Add(woman5);
            listOfPerson.Add(man4);
            listOfPerson.Add(man5);
            listOfPerson.Add(woman1);
            listOfPerson.Add(woman2);
            listOfPerson.Add(woman3);            
                        
            Console.WriteLine("\nДо сортировки:");
            listOfPerson.ForEach(Console.WriteLine);
            listOfPerson.Sort();
            Console.WriteLine("\nПосле сортировки:");
            listOfPerson.ForEach(Console.WriteLine);
            Console.WriteLine("Всё гуд");
        }
    }
}
