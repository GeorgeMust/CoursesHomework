/*Написать класс магазин, он должен работать с определенными товарами(со свойства ми название и цена), так же у него должен быть продавец. и иметь следующий функционал:
Добавить товар, при этом проверяем что данный товар уже существует в магазине, если существует- генерируем исключение.
Продать товар, при этом проверяем что оплата прошла, если денег недостаточно- генерируем эксепшн и возвращаем товар.
Ликвидировать магазин если он пуст, если товары еще есть то генерировать исключение.
В случае если продавца нет-> генерировать исключение, т.к. никакая функция не может быть выполнена корректно.(можно это проверять в конструкторе-передавать продавца параметром)*/
public class Shop
{
    private string seller;
    private List<Item> items;

    public Shop(string seller)
    {
        if (string.IsNullOrEmpty(seller))
        {
            throw new ArgumentException("Продавец не может быть пустым");
        }

        this.seller = seller;
        items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        if (items.Select(i => i.Name).Contains(item.Name))
        {
            throw new Exception("Товар уже существует в магазине");
        }

        items.Add(item);
    }

    public void SellItem(string itemName, decimal payment)
    {
        if (items.Count == 0)
        {
            throw new Exception("Магазин пуст");
        }

        if (string.IsNullOrEmpty(seller))
        {
            throw new Exception("Продавец не указан");
        }

        var item = items.FirstOrDefault(i => i.Name == itemName);
        if (item == null)
        {
            throw new Exception("Такого товара нет в магазине");
        }

        if (payment < item.Price)
        {
            throw new Exception("Недостаточно средств для покупки товара");
        }

        items.Remove(item);
    }

    public void LiquidateShop()
    {
        if (items.Count > 0)
        {
            throw new Exception("В магазине еще есть товары");
        }
    }
}

public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Customer
{
    public string Name { get; set; }
}

namespace Testft2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("Продавец");
            Item item1 = new Item { Name = "Колбаса", Price = 10.99m };
            Item item2 = new Item { Name = "Pringles", Price = 5.99m };
            Customer customer1 = new Customer { Name = "Поккпатель" };

            try
            {
                shop.AddItem(item1);
                shop.AddItem(item2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                shop.SellItem("Колбаса", 15m);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                shop.LiquidateShop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
