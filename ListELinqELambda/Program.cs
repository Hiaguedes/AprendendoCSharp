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
    null,
    new ContaCorrente(3, 4878754),
    null,
    new ContaCorrente(66, 5748787)
    );
//contas.Sort(); // IComparable
// contas.Sort(new Comparador()); // IComparer


//var contasOrdenadas = contas.OrderBy((conta) => { 
//    if(conta == null) { 
//        return Int32.MaxValue; 
//    }
//    return conta.Agencia; 
//});

var contasOrdenadas = contas
                    .Where(agencia => agencia != null)
                    .OrderBy(conta => conta.Agencia);

// var contasOrdenadas = contas.OrderByDescending(conta => conta.Agencia);

Console.WriteLine($"contasOrdenadas: {string.Join('\n', contasOrdenadas)}");

//Console.WriteLine(string.Join("\n", contas));

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

/*
 Temos uma lista de string para representar todos os meses do ano:

var meses = new List<string>() { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };COPIAR CÓDIGO
Para ordenar esta lista pelo nome, podemos usar o método Sort(), pois a String implementa a interface IComparable e, por consequência, possui o método CompareTo.

var mesesOrdenados = meses.OrderBy(mes => mes);


Correta! A expressão lambda mes => mes recebe uma string e devolve a mesma string. Como este tipo implementa a interface IComparable, podemos usar o OrderBy sem problemas.
 */
