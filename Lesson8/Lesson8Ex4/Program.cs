using System;

namespace Les8Ex4
{
    internal class Item
    {
        private string Name = "unknown";

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }

    internal class Bag
    {
        private Item[] items = new Item[8];
        private bool _isOpen;

        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }

        public void AddItem(Item item)
        {
            if (!_isOpen)
            {
                Console.WriteLine("Сумка закрыта");
                return;
            }

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    Console.WriteLine($"Вещь с именем '{item.GetName()}' добавлена в сумку");
                    return;
                }
            }

            Console.WriteLine("Сумка заполнена");
        }

        public Item GetItem(int index)
        {
            if (!_isOpen)
            {
                Console.WriteLine("Сумка закрыта");
                return null;
            }

            if (index >= 0 && index < items.Length)
            {
                Item item = items[index];
                items[index] = null;
                Console.WriteLine("Вещь была вынута");
                return item;
            }

            Console.WriteLine("Некорректный индекс");
            return null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item();
            Item item2 = new Item();
            Item item3 = new Item();

            Bag bag = new Bag();
            bag.IsOpen = true;

            bag.AddItem(item1);
            bag.AddItem(item2);
            bag.AddItem(item3);

            Item removedItem = bag.GetItem(1);

            if (removedItem != null)
            {
                Console.WriteLine("Вынута вещь с именем: " + removedItem.GetName());
            }
        }
    }
}