using System;
using System.IO;

namespace StreamWriterLine
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter escritor = new StreamWriter("arquivo4.txt");

            escritor.WriteLine("Primeira linha.");
            escritor.WriteLine("Algum texto.");

            escritor.Close();

            Console.ReadKey();
        }
    }
}
