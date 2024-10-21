using System;
using System.IO;

namespace WriteAllLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linhas = { "Primeira sentença.", "Segunda sentença." };

            File.WriteAllLines("arquivo2.txt", linhas);

            Console.ReadKey();
        }
    }
}
