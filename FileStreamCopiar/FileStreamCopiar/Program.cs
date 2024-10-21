using System;
using System.IO;

namespace FileStreamCopiar
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"E:\Textos\Estudos\Cursos\C#\Código Logo\File\FileStreamFileOpen\FileStreamFileOpen\bin\Debug\arquivo12.txt";

            using (FileStream streamLido = new FileStream(arquivo, FileMode.Open, FileAccess.Read))
            using (FileStream streamEscrito = new FileStream("arquivo12.txt", FileMode.Create, FileAccess.Write))
            {
                int bytesLidos = 0;
                byte[] buffer = new byte[4096];

                while ((bytesLidos = streamLido.Read(buffer, 0, buffer.Length)) > 0)
                {
                    streamEscrito.Write(buffer, 0, bytesLidos);

                    Console.WriteLine("Mais 4kb foram lidos");
                }
            }

            Console.ReadKey();
        }
    }
}
