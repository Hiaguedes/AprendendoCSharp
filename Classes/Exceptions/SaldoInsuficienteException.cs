using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {

        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(string Message): base(Message)
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("O atual saldo em conta e de: " + saldo + "\nnao podemos sacar um valor maior que esse uma vez que se tentou sacar um valor de "+ valorSaque)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;

        }
    }
}
