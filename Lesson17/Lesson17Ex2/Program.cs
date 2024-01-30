using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = "C:\\Work\\КурсыC#";
        string[] folderNames = new string[20];

        // Добавил создание директорий
        for (int i = 0; i < 20; i++)
        {
            string folderName = "MyTestFolder" + i;
            string folderPath = Path.Combine(directoryPath, folderName);
            Directory.CreateDirectory(folderPath);
            folderNames[i] = folderPath;
        }

        foreach (string folderPath in folderNames)
        {
            if (Directory.Exists(folderPath))
            {
                Directory.Delete(folderPath);
                Console.WriteLine("Папка удалена: " + folderPath);
            }
        }
    }
}
