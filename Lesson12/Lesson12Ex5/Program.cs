/*Создать тип MobileNetwork и дженерик тип MobilePhone<T> который имеет свойство типа T с названием Network. Добавить ограничение что T является MobileNetwork или его наследником.*/
namespace Lesson12Ex5
{
    public class MobileNetwork
    {

    }

    public class MobilePhone<T> where T : MobileNetwork
    {
        public T Network { get; set; }
    }

    public class SpecificMobileNetwork : MobileNetwork
    {

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MobilePhone<SpecificMobileNetwork> phone = new MobilePhone<SpecificMobileNetwork>();
            phone.Network = new SpecificMobileNetwork();            
        }
    }
}