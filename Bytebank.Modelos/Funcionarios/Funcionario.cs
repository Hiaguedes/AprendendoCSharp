using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        internal protected abstract double GetBonificacao();

        public override bool Equals(object? obj)
        {

            Funcionario? refObj = obj as Funcionario;

            if(refObj == null) return false; // possivel pq usamos o as Funcionario, se a conversao do objeto recebido nao e um funcionario entao ele se transforma em null

            return CPF == refObj.CPF;
        }
    }
}
