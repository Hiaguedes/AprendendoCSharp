using System;
using System.IO;
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
                //Method();
                LendoAquivosExternos();
            }
            catch (NullReferenceException error)
            {
                Console.WriteLine("Ocorreu um erro de referencia nula");
                Console.WriteLine(error.Message);
                Console.WriteLine("Na classe " + error.TargetSite);

            }
            catch (IOException ex)
            {
                Console.WriteLine("Ocorreu um erro do tipo IO");
                Console.WriteLine(ex.StackTrace);
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
                Console.WriteLine(ex.StackTrace);
             }
            catch (Exception error)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(error.Message);
                Console.WriteLine(error.StackTrace);
                //Console.WriteLine(error.InnerException);
            }
            finally
            {
                Console.ReadLine(); 
            }

        }

        static void LendoAquivosExternos()
        {
            using (LeitorArquivo leitor = new LeitorArquivo("contas.txt")) // ele vai chamar o q seria o finally dentro do metodo Dispose, garantido pela interface IDisposable
            {
                leitor.LerLinha();
                leitor.LerLinha();
                leitor.LerLinha();
                leitor.LerLinha();

            }

            //try
            //{



            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("Ocorreu um erro do tipo IO");
            //    Console.WriteLine(ex.StackTrace);
            //}
            //finally {
            //    if(leitor != null)
            //        leitor.Dispose();
            //}

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

            conta1.Transferir(10, conta2);

            Console.WriteLine("O numero de contas criadas é de " + ContaCorrente.numeroContas);

            Console.WriteLine("Taxa Ate o momento " + ContaCorrente.TaxaOperacao);


        }
    }
}

/*
 O using é um açúcar sintático para o código:

RecursoDoSistema recurso = null;
try
{
    recurso = new RecursoDoSistema();
    recurso.Usar();
}
finally
{
    if(recurso != null)
    {
        recurso.Dispose();
    }
}

Correta! Com o bloco using, a instanciação do objeto acontece em um bloco try e no bloco finally o método Dispose é invocado após a verificação de referência nula.
 */
