using System;
using System.IO;

namespace FileInfo1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(@"E:\Textos\Estudos\Cursos\C#\Código Logo\File\FileStreamFileOpen\FileStreamFileOpen\bin\Debug\arquivo12.txt");

            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.Attributes);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine("Tamanho: {0} Kb", fi.Length / 1024);

            Console.ReadKey();
        }
    }
}
