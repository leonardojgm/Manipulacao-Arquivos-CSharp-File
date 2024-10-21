using System;
using System.IO;

namespace StreamReaderToEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader leitor = new StreamReader("arquivo4.txt");

            Console.WriteLine(leitor.ReadToEnd());

            Console.ReadKey();
        }
    }
}
