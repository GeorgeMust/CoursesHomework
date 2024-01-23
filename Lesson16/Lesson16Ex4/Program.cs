/*4.Исходная последовательность содержит сведения о
клиентах фитнес-центра. Каждый элемент последовательности включает следующие целочисленные поля:
<Год> <Номер месяца> <Продолжительность
занятий (в часах)> <Код клиента>
Определить год, в котором суммарная продолжительность
занятий всех клиентов была наибольшей, и вывести этот год
и наибольшую суммарную продолжительность. Если таких
годов было несколько, то вывести наименьший из них. */
namespace Lesson16Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Clients> clients = new List<Clients>
        {
            new Clients { Year = 2022, Month = 1, Duration = 5, ClientCode = 1 },
            new Clients { Year = 2022, Month = 1, Duration = 7, ClientCode = 2 },
            new Clients { Year = 2021, Month = 2, Duration = 9, ClientCode = 3 },
            new Clients { Year = 2021, Month = 2, Duration = 4, ClientCode = 4 },
            new Clients { Year = 2021, Month = 3, Duration = 6, ClientCode = 5 },
        };
            var groupedByYear = clients.GroupBy(c => c.Year);

            int maxTotalDuration = 0;
            int minYearWithMaxTotalDuration = int.MaxValue;

            foreach (var group in groupedByYear)
            {
                int totalDuration = group.Sum(c => c.Duration);
                if (totalDuration > maxTotalDuration)
                {
                    maxTotalDuration = totalDuration;
                    minYearWithMaxTotalDuration = group.Key;
                }
                else if (totalDuration == maxTotalDuration && group.Key < minYearWithMaxTotalDuration)
                {
                    minYearWithMaxTotalDuration = group.Key;
                }
            }

            Console.WriteLine($"Год с наибольшей суммарной продолжительностью: {minYearWithMaxTotalDuration}");
            Console.WriteLine($"Наибольшая суммарная продолжительность: {maxTotalDuration} часов");    
        }
    }
}
