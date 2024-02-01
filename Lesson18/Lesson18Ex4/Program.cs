using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string file1Path = "file1.txt";
        string file2Path = "file2.txt";
        string file3Path = "file3.txt";

        await CreateFilesAsync(file1Path, file2Path, file3Path);

        Task<string> task1 = ReadFileAsync(file1Path);
        Task<string> task2 = ReadFileAsync(file2Path);

        await Task.WhenAll(task1, task2);

        await WriteToFileAsync(file3Path, task1.Result, task2.Result);

        Console.WriteLine("Запись в файл");
    }

    static async Task CreateFilesAsync(string file1Path, string file2Path, string file3Path)
    {
        using (StreamWriter sw1 = new StreamWriter(file1Path))
        {
            await sw1.WriteLineAsync("Текст первого файла");
        }

        using (StreamWriter sw2 = new StreamWriter(file2Path))
        {
            await sw2.WriteLineAsync("Текст второго файла");
        }

        File.Create(file3Path).Dispose();
    }

    static async Task<string> ReadFileAsync(string filePath)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            return await sr.ReadToEndAsync();
        }
    }

    static async Task WriteToFileAsync(string filePath, string content1, string content2)
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            await sw.WriteAsync(content1);
            await sw.WriteAsync(content2);
        }
    }
}