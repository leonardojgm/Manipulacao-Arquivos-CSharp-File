using System;
using System.IO;

namespace StreamReaderLinha
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader leitor = new StreamReader("arquivo4.txt");

            string linha;

            while ((linha = leitor.ReadLine()) != null) Console.WriteLine(linha);

            Console.ReadKey();
        }
    }
}
