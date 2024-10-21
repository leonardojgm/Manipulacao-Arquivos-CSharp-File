using System;
using System.IO;
using System.Text;

namespace ReadAllBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] dados = File.ReadAllBytes("arquivo3.txt");

            Console.WriteLine(Encoding.UTF8.GetString(dados));

            Console.ReadKey();
        }
    }
}
