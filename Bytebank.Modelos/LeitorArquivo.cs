using System;
using System.IO;

namespace ByteBank.Modelos
{
    public class LeitorArquivo : IDisposable
    {
        public string CaminhoAquivo { get; private set; }
        private readonly Random random = new Random();
        public LeitorArquivo(string path)
        {
            Console.WriteLine("Nova instancia do leitor criada, para ler o arquivo "+ path);
            CaminhoAquivo = path;
        }

        public void LerLinha()
        {
            if (random.Next(0, 10) > 5)
            {
                throw new IOException("Erro");

            }
            Console.WriteLine("Lendo proxima linha");

            //Console.WriteLine(random.Next(0 ,10));
        }


        public void Dispose() {
            Console.WriteLine("Fechando instancia do leitor");
        }
    }
}
