/*Создать класс Молотые Зерна и Вода.
Придумать свойства которыми могут обладать классы. ( обязательное условие: Вода должна обладать температурой и объемом, зерна крепостью и объемом)
Добавить операторы + в классы чтобы при слаживании воды и кофе получался новый класс Кофе.
Кофе может обладать разными характеристиками крепости в зависимости от объемов, от температуры воды и крепости зерен. (реализовать крепость кофе через enum), объем через Int 
*/
namespace Lesson11Ex2
{
    enum Strength
    {
        minValue,
        avgValue,
        maxValue
    }
    internal class GroundGrains
    {
        internal Strength strength { get; set; }
        internal int volume { get; set; }
        internal GroundGrains(Strength strength, int volume)
        {
            this.strength = strength;
            this.volume = volume;
        }
        public static Cofe operator +(GroundGrains a, Water b)
        {
            Cofe cofe = new Cofe();
            cofe.volume = a.volume + b.volume;
            cofe.temperature = b.temperature;
            cofe.strength = a.strength;
            return cofe;
        }
    }
    internal class Water
    {
        internal int volume;
        internal int temperature;
        internal Water(int volume, int temperature)
        {
            this.volume = volume;
            this.temperature = temperature;
        }
        public static Cofe operator +(Water a, GroundGrains b)
        {
            Cofe cofe = new Cofe();
            cofe.volume = a.volume + b.volume;
            cofe.temperature = a.temperature;
            cofe.strength = b.strength;
            return cofe;
        }
    }
    internal class Cofe
    {
        internal int volume;
        internal int temperature;
        internal Strength strength;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var grgr = new GroundGrains(Strength.minValue, 50);
            var water = new Water(100, 100);
            Cofe cofe = grgr + water;
            Cofe cofe1 = water + grgr;
            Console.WriteLine("Всё гуд");
        }
    }
}
