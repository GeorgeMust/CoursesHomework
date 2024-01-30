using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "C:\\Work\\КурсыC#\\example.txt"; // Путь к файлу

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Привет с первой строки");
            writer.WriteLine();
            writer.WriteLine("Привет с 3й строки");
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
