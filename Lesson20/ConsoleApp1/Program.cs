using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine(@"C:\Work\КурсыC#\kourses\Lesson20\Plugin\bin\Debug\net8.0", "Plugin.dll");
            try
            {
                Assembly assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(path);
                Type type = assembly.GetTypes()[0];
                MethodInfo method = type.GetMethod("RunLogic");
                var instance = Activator.CreateInstance(type);
                method.Invoke(instance, new object[] { "Hey" });
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}