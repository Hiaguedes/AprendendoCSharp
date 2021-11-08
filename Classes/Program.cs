using System;
using ByteBank;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta1 = new ContaCorrente(12345, 1)
            {
                Saldo = 200,
                Titular =
                {
                    nome = "Gabriela Fernandes",
                    cpf = "1111111"
                }
            };

            ContaCorrente conta2 = new ContaCorrente(1235, 1)
            {
                Saldo = 500,
                Titular =
                {
                    nome = "João Fernandes",
                    cpf = "1111111"
                }
            };

            conta1.Sacar(100);
            conta2.Depositar(55);
            conta1.Depositar(300);

            conta1.Transferir(100, conta2);

            Console.WriteLine("O numero de contas criadas é de " + ContaCorrente.numeroContas);

            Console.ReadLine();
        }
    }
}
