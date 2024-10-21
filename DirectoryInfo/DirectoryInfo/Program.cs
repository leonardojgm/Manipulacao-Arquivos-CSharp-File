using System;
using System.IO;

namespace DirectoryInfo1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Maia\Pictures");

            foreach (var pasta in di.GetDirectories())
            {
                foreach (var arquivo in pasta.GetFiles())
                {
                    Console.WriteLine("Arquivo: {0} Tamanho: {1} Kb", arquivo.Name, arquivo.Length / 1024);
                }
            }
            Console.ReadKey();
        }
    }
}
