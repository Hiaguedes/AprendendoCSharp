using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static int numeroContas { get; private set; } = 0;
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            numeroContas++;
        }

        public Titular Titular
        {
            get;
            set;
        } = new Titular();

        public int Agencia
        {
            get;
            set;
        }

        public int Numero
        {
            get;
            set;
        }

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

        public bool Sacar(double valor)
        {
            if (valor > _saldo)
            {
                Console.WriteLine("Valor digitado maior que o saldo em conta");
                return false;

            }

            _saldo -= valor;

            Console.WriteLine("O saldo da conta do " + Titular.nome + " agora é de R$ " + _saldo);
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
            Console.WriteLine("O saldo da conta do " + Titular.nome + " agora é de R$ " + _saldo);
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor > _saldo)
            {
                Console.WriteLine("Valor digitado maior que o saldo em conta");
                return false;
            }

            this.Sacar(valor);
            contaDestino.Depositar(valor);

            return true;
        }

    }
}
