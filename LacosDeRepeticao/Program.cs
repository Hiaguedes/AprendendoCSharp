using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorInvestido = 1000;

            for (int mes = 1; mes<13; mes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + mes + (mes > 1 ? " meses" : " mês") +  " o valor total será de " + valorInvestido);

            }


            Console.WriteLine(valorInvestido);


            Console.ReadLine();
        }
    }
}
