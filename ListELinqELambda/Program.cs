using System.Collections;
using Extensions;
using ByteBank.Modelos;

List<int> list = new();

list.Add(0);
list.Add(1);
list.Remove(1);
list.AddRange(new int[] { 3, 4, 5 });
list.PushMany(1, 3, 46, 7); // metodo de extensao criado na pasta extensions

// var frase = "aaaaaa"; // a gente cria a variavel e deve atribuir algo a ela

list.Sort();

var contas = new List<ContaCorrente>();

contas.PushMany(
    new ContaCorrente(1, 1245787), 
    new ContaCorrente(20, 4878754),
    new ContaCorrente(154, 4257845),
    new ContaCorrente(5, 9565487),
    new ContaCorrente(3, 4878754),
    new ContaCorrente(66, 5748787)
    );
//contas.Sort(); // IComparable
contas.Sort(new Comparador()); // IComparer

Console.WriteLine(string.Join("\n", contas));

Console.WriteLine(string.Join('-', list));

public class Comparador : IComparer<ContaCorrente>
{
    public int Compare(ContaCorrente x, ContaCorrente y)
    {
        //if (x.Agencia == y.Agencia) return 0;
        //if(x.Agencia < y.Agencia) return -1;
        //return 1;

        return x.Agencia.CompareTo(y.Agencia);
    }
}
