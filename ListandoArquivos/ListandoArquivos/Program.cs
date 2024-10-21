using System;
using System.IO;

namespace ListandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diretorios = Directory.GetDirectories(@"C:\");

            foreach (var diretorio in diretorios) Console.WriteLine(diretorio);

            foreach (string arquivo in Directory.GetFiles(@"C:\Windows")) Console.WriteLine(arquivo);

            Console.ReadKey();
        }
    }
}
