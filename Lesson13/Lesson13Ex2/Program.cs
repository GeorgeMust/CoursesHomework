/*Создайте пользовательский список Collection<T> работающий с классами реализующими IComparable. Class должен иметь свойство IdNumber (int),
Реализуйте добавление в список нового объекта так, чтобы после добавления список сортировался по свойству IdNumber.
Заполните список начальными данными.
Добавьте в ваш список новый элемент.
После каждого изменения списка выводите его на экран.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace Lesson13Ex2
{
    public class MyClass : IReliseComparable
    {
        public int IdNumber { get; set; }

        public int CompareTo(IReliseComparable comparePart)
        {
            if (comparePart == null)
            {
                return 1;
            }
            else
            {
                return this.IdNumber.CompareTo(comparePart.IdNumber);
            }
        }
    }
    public interface IReliseComparable : IComparable<IReliseComparable>
    {
        int IdNumber { get; set; }

        public int CompareTo(IReliseComparable comparePart)
        {
            if (comparePart == null)
            {
                return 1;
            }
            else
            {
                return this.IdNumber.CompareTo(comparePart.IdNumber);
            }
        }
    }

    public class MyCollection<T> : Collection<T> where T : IReliseComparable
    {
        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            var count = base.Count;
            var myArray = new T[count];
            base.CopyTo(myArray, 0);

            Array.Sort(myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                base[i] = myArray[i];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCollection<MyClass> collection = new MyCollection<MyClass>();
            // Заполнение списка начальными данными
            collection.Add(new MyClass { IdNumber = 3 });
            collection.Add(new MyClass { IdNumber = 1 });
            // Вывод списка до добавления нового элемента
            Console.WriteLine("Список до добавления нового элемента:");
            foreach (var item in collection)
            {
                Console.WriteLine(item.IdNumber);
            }
            collection.Add(new MyClass { IdNumber = 2 });
            collection.Add(new MyClass { IdNumber = 4 });
            // Вывод списка после добавления нового элемента
            Console.WriteLine("Список после добавления нового элемента:");
            foreach (var item in collection)
            {
                Console.WriteLine(item.IdNumber);
            }

            Console.ReadLine();
        }
    }
}