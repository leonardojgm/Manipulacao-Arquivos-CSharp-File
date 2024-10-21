using System;
using System.IO;
using System.Text;

namespace FileStreamStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("arquivo12.txt", FileMode.Open, FileAccess.Read);
            StreamReader leitor = new StreamReader(stream, Encoding.UTF8);

            string line;

            while ((line = leitor.ReadLine()) != null) Console.WriteLine(line);

            while (leitor.Peek() > 0)
            {
                line = leitor.ReadLine();

                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}
