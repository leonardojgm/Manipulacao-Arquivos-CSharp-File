using System;
using System.IO;
using System.Text;

namespace FileStream1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fluxo = new FileStream("arquivo.txt", FileMode.Create, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(fluxo);

            escritor.WriteLine("Uma linha.");
            escritor.WriteLine("Outra linha.");
            escritor.Close();
            fluxo.Close();

            FileStream fluxo1 = new FileStream("arquivo1b.txt", FileMode.Create, FileAccess.Write);
            byte[] texto = Encoding.UTF8.GetBytes("Algum texto em bytes.");

            fluxo1.Write(texto, 0, 6);
            fluxo1.Close();

            using (FileStream fluxo2 = new FileStream("arquivo1c.txt", FileMode.Create, FileAccess.Write))
            using (StreamWriter escritor2 = new StreamWriter(fluxo2))
            {
                escritor2.WriteLine("Linha em using.");
                escritor2.WriteLine("Linha usando dispose.");
            }

            Console.ReadKey();
        }
    }
}
