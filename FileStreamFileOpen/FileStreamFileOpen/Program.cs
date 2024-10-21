using System;
using System.IO;

namespace FileStreamFileOpen
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = File.OpenRead("arquivo12.txt"))
            using (StreamReader leitor = new StreamReader(stream))
                while (leitor.Peek() > 0) Console.WriteLine(leitor.ReadLine());

            Console.ReadKey();
        }
    }
}
