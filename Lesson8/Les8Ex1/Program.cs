/*Создать класс Item, у класса должно быть одно приватное поле Name со значением по умолчанию “unknown”
Добавить публичный метод SetName который устанавливать значение приватного поля Name. 
Добавить публичный метод GetName который будет возвращать значение приватного поля Name.*/
using System.Runtime.CompilerServices;

namespace Les8Ex1
{
    internal class Item
    {
        private string Name = "unknown";
        public string GetName() 
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name=Name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            Console.WriteLine(item.GetName());
            item.SetName("newName");
            Console.WriteLine(item.GetName());
        }
    }
}
