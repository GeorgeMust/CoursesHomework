/*1)Создать Класс Panda , свойства Gender(это enum со значениями Male, Femail), свойство Color(это enum со значениями White-Black, Black, White)
доп свойства:
int HP(здоровье), 
int attack, 
int defence
string name
Определить операторы +/-, оператор + должен создавать новую панду цвета родителей(либо матери либо отца) - если обе панды с разным Gender.
оператор - означает что одна панда напала на вторую и у панды на которую напали отнимается здоровье(HP) в размере атаки нападающей панды(-defence) и возвращается результат в виде уменьшенной панды.
Здоровье не может упасть меньше 1 единицы, т.е. панды не убивают друг друга.
Реализовать сравнение панд по цвету и весу(HP).
*/
using System.Reflection.Metadata.Ecma335;

namespace Lesson11Ex1
{
    enum Gender
    {
        Male,
        Femail
    }
    enum Color
    {
        WhiteBlack,
        Black,
        White
    }
    internal class Panda
    {
         private int HP { get; set; }
        private int attack { get; set; }
        private int defence { get; set; }
        private string name { get; set; }
        private Color color { get; set; }
        private Gender gender { get; set; }

        public Panda(int HP, int attack, int defence, string name, Color color, Gender gender)
        {
            if (HP == 0)
            {
                throw new ArgumentException("HP не могут быть 0", nameof(HP));
            }
            this.HP = HP;
            this.attack = attack;
            this.defence = defence;
            this.name = name;
            this.gender = gender;
            this.color = color;
        }
        public static Panda operator +(Panda a, Panda b)
        {
            if (a.gender != b.gender)
            {
                return new Panda(100, 20, 10, "Kungfu", a.color, b.gender);
            }
            else
            {
                throw new InvalidOperationException("Нельзя скрестить панд одного пола");
            }
        }
        public static Panda operator -(Panda a, Panda b)
        {
            if ((b.HP + b.defence) > a.attack)
            {                
                if (b.defence < a.attack)
                {
                    b.HP += b.defence - a.attack;
                }
            }
            else
            {
                b.HP = 1;
            }
            return b;
        }
        public static bool operator==(Panda a, Panda b)
        {            
            if(a.HP == b.HP && a.color == b.color)
                return true;
            return false;
        }
        public static bool operator != (Panda a, Panda b)
        {
            return !(a == b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Panda(100, 20, 10, "Kunfu", Color.Black, Gender.Male);
            var b = new Panda(100, 20, 10, "Femfu", Color.White, Gender.Femail);
            //var e = new Panda(100, 20, 10, "Kun", Color.Black, Gender.Male);

            var c = a + b;
            b = (a - b);
            if(a == b)
            {
                Console.WriteLine("Правда");
            }
            else if (a != b)
            {
                Console.WriteLine("Ложь");
            }
            Console.WriteLine("Гуд");
        }
    }
}
