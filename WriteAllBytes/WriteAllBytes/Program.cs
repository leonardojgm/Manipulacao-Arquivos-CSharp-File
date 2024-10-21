using System;
using System.IO;
using System.Text;

namespace WriteAllBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Isto é uma string em C Sharp.";
            byte[] bytes = Encoding.UTF8.GetBytes(texto);

            File.WriteAllBytes("arquivo3.txt", bytes);

            Console.ReadKey();
        }
    }
}
