using System;
using System.IO;

namespace Directory1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Directory.Exists("Test"))
            {
                Console.WriteLine("Esta pasta já existe!");
            }
            else
            {
                Directory.CreateDirectory("Test");
                Console.WriteLine("Esta pasta não existe, então eu criei uma!");
            }

            Console.ReadKey();

            Directory.Delete("Test");

            Console.ReadKey();
        }
    }
}
