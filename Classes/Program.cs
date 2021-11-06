using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta1 = new ContaCorrente
            {
                Agencia = 1235,
                Numero = 1,
                Saldo = 120,
                Titular = "Gabriela Fernandes"
            };

            Console.WriteLine(conta1.Titular);

            conta1.Saldo += 500;
            Console.WriteLine(conta1.Saldo);


            Console.ReadLine();
        }
    }
}
