using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsChar
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Strings e Char");

			char caractereEspecial = '@';

			Console.WriteLine(caractereEspecial);

			caractereEspecial = (char)(caractereEspecial + 10);

			Console.WriteLine(caractereEspecial);

			string titulo = "Simples assim" + 1;
			Console.WriteLine(titulo);

			string linhaQuebrada = "Oi \nComo vai você";
			Console.WriteLine(linhaQuebrada);

			Console.ReadLine();
		}
	}
}
