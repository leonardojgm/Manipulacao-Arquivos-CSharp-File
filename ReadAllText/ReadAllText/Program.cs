using System;
using System.IO;

namespace ReadAllText
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = File.ReadAllText("arquivo1.txt");

            Console.WriteLine(texto);

            Console.ReadKey();
        }
    }
}
