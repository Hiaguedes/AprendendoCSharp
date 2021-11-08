using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 17;
            int qtdePessoas = 5;

            if (idade >= 18 || qtdePessoas >= 2)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            bool foiPromovido = true;
            double salario;

            if (foiPromovido)
            {
                salario = 4200.0;
            }
            else
            {
                salario = 3800.0;
            }

            Console.WriteLine(salario);


            Console.ReadLine();
        }
    }
}
