using System.IO;
using System.Text;

namespace FileStreamUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fluxo = File.Create("arquivo12.txt"))
            using (StreamWriter escritor = new StreamWriter(fluxo, Encoding.UTF8))
                escritor.WriteLine("Isso foi criado com o File.Creator");

            using (FileStream fluxob = File.Create("arquivo12b.txt"))
            using (StreamWriter escritor = new StreamWriter(fluxob, Encoding.UTF8))
            {
                byte[] dados = Encoding.UTF8.GetBytes("Isto é uma sentença");

                for (int i = 0; i < dados.Length; i++) fluxob.WriteByte(dados[i]);
            }
        }
    }
}
