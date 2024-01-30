using System;
using System.IO;

public class DirectoryHelper
{
    public static int GetFileCount(string path)
    {
        try
        {
            // Получаем список всех файлов в указанной папке и ее подпапках
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            return files.Length;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении количества файлов: {ex.Message}");
            return -1;
        }
    }

    public static FileInfo[] GetFiles(string path)
    {
        try
        {
            // Получаем список всех файлов в указанной папке и ее подпапках
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            // Преобразуем массив строк в массив объектов FileInfo
            FileInfo[] fileInfos = new FileInfo[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                fileInfos[i] = new FileInfo(files[i]);
            }

            return fileInfos;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении списка файлов: {ex.Message}");
            return null;
        }
    }

    public static int GetFileCountByExtension(string path, string extension)
    {
        try
        {
            // Получаем список всех файлов с указанным расширением в указанной папке и ее подпапках
            string[] files = Directory.GetFiles(path, $"*.{extension}", SearchOption.AllDirectories);
            return files.Length;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении количества файлов: {ex.Message}");
            return -1;
        }
    }

    public static FileInfo[] GetFilesByExtension(string path, string extension)
    {
        try
        {
            // Получаем список всех файлов с указанным расширением в указанной папке и ее подпапках
            string[] files = Directory.GetFiles(path, $"*.{extension}", SearchOption.AllDirectories);

            // Преобразуем массив строк в массив объектов FileInfo
            FileInfo[] fileInfos = new FileInfo[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                fileInfos[i] = new FileInfo(files[i]);
            }

            return fileInfos;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при получении списка файлов: {ex.Message}");
            return null;
        }
    }
public static void Main(string[] args)
    {
        string folderPath = "C:\\Work\\КурсыC#";

        int fileCount = DirectoryHelper.GetFileCount(folderPath);
        Console.WriteLine($"Количество файлов: {fileCount}");

        FileInfo[] files = DirectoryHelper.GetFiles(folderPath);
        if (files != null)
        {
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.FullName);
            }
        }

        string extension = "txt";

        int fileCountByExtension = DirectoryHelper.GetFileCountByExtension(folderPath, extension);
        Console.WriteLine($"Количество файлов с расширением {extension}: {fileCountByExtension}");

        FileInfo[] filesByExtension = DirectoryHelper.GetFilesByExtension(folderPath, extension);
        if (filesByExtension != null)
        {
            foreach (FileInfo file in filesByExtension)
            {
                Console.WriteLine(file.FullName);
            }
        }
    }
}