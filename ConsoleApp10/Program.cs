using System;
using System.IO;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Анатолий\OneDrive\Desktop\ess";
            var files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Contains("OneRepublic"))
                {
                    Console.WriteLine(files[i]);
                    File.Move(files[i], files[i].Remove(39, 14));
                }
            }
            
            
        }
    }
}