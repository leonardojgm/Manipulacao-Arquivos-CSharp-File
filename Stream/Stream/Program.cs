using System;
using System.IO;

namespace Stream1
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileStream, MemoryStream, Stream

            string arquivo = @"E:\Textos\Estudos\Cursos\C#\Código Logo\File\FileStreamFileOpen\FileStreamFileOpen\bin\Debug\arquivo12.txt";
            using (FileStream streamLido = new FileStream(arquivo, FileMode.Open, FileAccess.Read))
            using (FileStream streamEscrito = new FileStream("arquivo12.txt", FileMode.Create, FileAccess.Write))
                Copiar(streamLido, streamEscrito, 2048);

            FileInfo fi = new FileInfo(@"E:\Textos\Estudos\Cursos\C#\Código Logo\File\FileStreamFileOpen\FileStreamFileOpen\bin\Debug\arquivo12.txt");
            Stream saida = new FileStream("arquivo13.txt", FileMode.Create, FileAccess.Write);
            Copiar(fi.OpenRead(), saida, 4096);

            Console.ReadKey();
        }

        private static void Copiar(Stream streamIn, Stream streamOut, int tamanhoDoBuffer)
        {
            int bytesLidos = 0;
            byte[] buffer = new byte[tamanhoDoBuffer];

            while ((bytesLidos = streamIn.Read(buffer, 0, buffer.Length)) > 0) streamOut.Write(buffer, 0, bytesLidos);
        }
    }
}
