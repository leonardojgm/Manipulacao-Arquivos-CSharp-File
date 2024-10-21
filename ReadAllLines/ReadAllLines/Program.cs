using System;
using System.IO;

namespace ReadAllLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linhas = File.ReadAllLines("arquivo2.txt");

            foreach (var linha in linhas) Console.WriteLine(linha);

            Console.ReadKey();
        }
    }
}
