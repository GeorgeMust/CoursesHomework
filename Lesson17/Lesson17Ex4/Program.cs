using System;
using System.IO;

public class MyItem
{
    public int Age { get; set; }
    public string Name { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyItem item = new MyItem
        {
            Age = 25,
            Name = "John Doe"
        };

        string filePath = "example.json";
        string json = Newtonsoft.Json.JsonConvert.SerializeObject(item);

        System.IO.File.WriteAllText(filePath, json);

        string data = System.IO.File.ReadAllText(filePath);
        Console.WriteLine(data);
    }
}