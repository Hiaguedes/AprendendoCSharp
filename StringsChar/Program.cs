using System;
using System.Text.RegularExpressions;

namespace StringsChar
{
    class Program
    {
        static void Main()
        {
            Basico();
            ChavesString();
            UsandoRegex();

            Console.ReadLine();
        }

        public static void Basico(){
            Console.WriteLine("Strings e Char");

            char caractereEspecial = '@';

            Console.WriteLine(caractereEspecial);

            caractereEspecial = (char)(caractereEspecial + 10);

            Console.WriteLine(caractereEspecial);

            string titulo = "Simples assim" + 1;
            Console.WriteLine(titulo);

            string linhaQuebrada = "Oi \nComo vai você";
            Console.WriteLine(linhaQuebrada);

        }

        public static void ChavesString()
        {
            string url = "pagina?argumentos";

            Console.WriteLine(url.Substring(6));
            Console.WriteLine(url.Split('?')[1]);

            Console.WriteLine(url.IndexOf('?'));

            Console.WriteLine(url.Substring(url.IndexOf('?') + 1));

            char[] options = {'?'};
            Console.WriteLine("pagina?argumentos?simples".IndexOfAny(options));

            //Console.WriteLine("Regex" ,Regex.Match("pagina?argumentos?simples", "?"));

            string outraURL = "pagina?moedaOrigem=real&moedaDestino=dolar";
            string args = outraURL.Substring(outraURL.IndexOf('?') + 1);

            string moedaOrigem = args.Split('&')[0];
            string moedaDestino = args.Split('&')[1];

            Console.WriteLine("moedaOrigem: " + moedaOrigem + " moedaDestino: " + moedaDestino);

            ExtratorArgumentos extrator = new ExtratorArgumentos("pagina?moedaOrigem=real&moedaDestino=dolar&valor=1500");

            Console.WriteLine(extrator.GetValor("moedaOrigem"));
            Console.WriteLine(extrator.GetValor("moedaDestino"));
            Console.WriteLine(extrator.GetValor("valor"));

            Console.WriteLine("https://www.google.com/search?q=fff".StartsWith("https://www.google.com"));
            Console.WriteLine("https://www.google.com/search?q=fff".Contains("google"));

        }

        public static void UsandoRegex()
        {
            Console.WriteLine("Testes com Regex");

            Console.WriteLine(Regex.Match("Meu nome e Fulano, meu numero e (021)8795-4669 e estamos atendendo das 17:30 as 21:15", @"(\(0?\d{2}\))?9?\d{4}[-]?\d{4}"));
            Console.WriteLine(new Regex(@"(\(0?\d{2}\))?9?\d{4}[- ]?\d{4}").IsMatch("8795 4669"));
        }
    }
}
