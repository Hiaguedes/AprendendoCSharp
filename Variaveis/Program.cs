using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Variáveis com C#");

			int idade = 3;

			Console.WriteLine(idade + 2 + ": Resultado da soma de idade com 2");

			Console.WriteLine(6 / 2 * (1 + 2));
			Console.WriteLine(0.1 + 0.2);

			double variablePoint = 5.2;

			Console.WriteLine(variablePoint.ToString());
			Console.WriteLine(15 / 2);
			Console.WriteLine(15.0 / 2);

			int salarioInt = (int)14.5;
			Console.WriteLine(salarioInt);

			float altura = 1.8f;

			Console.WriteLine(altura);

			Console.WriteLine("int para o caractere @ " + (int)'@');

			Console.ReadLine();
		}
	}
}
