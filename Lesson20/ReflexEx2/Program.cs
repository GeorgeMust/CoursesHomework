/*С помощью рефлексии подгрузите библиотеку в новом проекте.
Bзмените код типа так чтобы после этого c помощью рефлексии вызвать метод CarMethod() и увидеть в консоли сообщение "Hey!" */
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.Loader;
namespace ReflexEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(@"C:\Work\КурсыC#\kourses\Lesson20\Car\bin\Debug\net8.0", "Car.dll");
            Assembly carAssembly = Assembly.LoadFrom(path);

            Type carType = carAssembly.GetType("Car.MyCar");

            object carObject = Activator.CreateInstance(carType);

            MethodInfo carMethod = carType.GetMethod("CarMethod", BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo ageField = carType.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
            ageField.SetValue(carObject, 5);

            try
            {
                carMethod.Invoke(carObject, new object[] { "Hey!" });
            }
            catch (Exception)
            {
                Console.WriteLine("Try again");
            }

            Console.ReadLine();
        }
    }
}
