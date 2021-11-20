using System;
using Classes.Exceptions;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static int numeroContas { get; private set; } = 0;

        public Titular Titular
        {
            get;
            set;
        } = new Titular();
        public int Agencia { get; }
        public int Numero { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0) throw new Exception("Valor não pode ser negativo");

                _saldo = value;
            }
        }


        public static double TaxaOperacao { get; private set; }

        public ContaCorrente(int agencia, int numeroConta)
        {
            if (agencia <=0)
            {
                ArgumentException argumentException = 
                    new ArgumentException("O argumento " + nameof(agencia) + " no construtor de ContaCorrente nao pode ser menor ou igual a zero", nameof(agencia));
                throw argumentException;
            }

            if(numeroConta <= 0)
            {
                ArgumentException argumentException = new ArgumentException("O argumento " + nameof(numeroConta) + " no construtor de ContaCorrente nao pode ser menor ou igual a zero", nameof(numeroConta));
                throw argumentException;
            }
            Agencia = agencia;
            Numero = numeroConta;
            numeroContas++;

            try
            {
                TaxaOperacao = 30 / numeroContas;   

            }
            catch(DivideByZeroException)
            {
                TaxaOperacao = 30;
            }


        }

        public void Sacar(double valor)
        {
            if(valor < 0) {
                throw new ArgumentException("Valor invalido para o saque, valor negativo", nameof(valor));
             }

            if (valor > _saldo)
            {
                // Console.WriteLine("Valor digitado maior que o saldo em conta");
                // throw new SaldoInsuficienteException("O atual saldo em conta e de: " + _saldo + "\nnao podemos sacar um valor maior que esse");
                throw new SaldoInsuficienteException(_saldo, valor);
            }

            _saldo -= valor;

            Console.WriteLine("O saldo da conta do " + Titular.nome + " agora é de R$ " + _saldo);
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
            Console.WriteLine("O saldo da conta do " + Titular.nome + " agora é de R$ " + _saldo);
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para a transferencia, valor negativo", nameof(valor));
            }


            try
            {
                Sacar(valor);

            }
            catch (SaldoInsuficienteException ex)
            {
                throw new OperacaoFinanceiraException("Pegou uma transferencia de valor maior que o saldo", ex); // no sacar eu tenho a mensagem do valor especifico no transferir nao (regra de negocio da exception)
            }
            contaDestino.Depositar(valor);

        }

    }
}
