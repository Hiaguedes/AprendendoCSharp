using System;
using ByteBank;
using Classes.Exceptions;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            try
            {
                Method();
            }
            catch (NullReferenceException error)
            {
                Console.WriteLine("Ocorreu um erro de referencia nula");
                Console.WriteLine(error.Message);
                Console.WriteLine("Na classe " + error.TargetSite);

            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Ocorreu um erro de argumento");
                Console.WriteLine(error.Message);
                Console.WriteLine("No parametro " + error.ParamName);
                Console.WriteLine("Na classe " + error.TargetSite);

            }
            catch (SaldoInsuficienteException ex) {
                Console.WriteLine("Excecao de saldo Insuficiente");
                Console.WriteLine(ex.Message);
             }
            catch (Exception error)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(error.Message);
                Console.WriteLine(error.StackTrace);
            }
            finally
            {
                Console.ReadLine(); 
            }

        }

        static void Method()
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

            // ContaCorrente conta3 = new ContaCorrente(40, 0);


            // ContaCorrente contaError = null;

            // contaError.Depositar(10);

            conta1.Sacar(100);
            conta2.Depositar(55);
            conta1.Depositar(300);

            conta1.Transferir(100, conta2);

            Console.WriteLine("O numero de contas criadas é de " + ContaCorrente.numeroContas);

            Console.WriteLine("Taxa Ate o momento " + ContaCorrente.TaxaOperacao);


        }
    }
}
