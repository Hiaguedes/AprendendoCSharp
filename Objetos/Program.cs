using ByteBank.Funcionarios;
using System.Collections;
using Objetos.Lista;

Console.WriteLine("Resultado to String " + new Desenvolvedor("111111").ToString());

object dev1 = new Desenvolvedor("111111");
object dev2 = new Desenvolvedor("111111");

Console.WriteLine(dev1.Equals(dev2));

int[] idades = new int[5];

idades[0] = 10;
idades[1] = 35;
idades[2] = 27;
idades[3] = 8;
idades[4] = 41;
Console.WriteLine(String.Join('-', idades));

string[] listaComprar = new string[5];

listaComprar[2] = "dwdwdwd";

Console.WriteLine(String.Join('-', listaComprar));

int acc = 0;
for (int i = 0; i < idades.Length; i++)
{
    int idade = idades[i];
    //Console.Beep();
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine($"Idade coloca no indice {i} e de valor {idade}");
    acc += idade;
}

Console.WriteLine($"Acumulador = {acc}");
Console.WriteLine($"Media = {acc / idades.Length}");

Desenvolvedor[] devs = new Desenvolvedor[5];

devs[0] = new Desenvolvedor("1111");

Console.WriteLine(devs[0].GetType());
//Console.WriteLine(devs[1].GetType()); //erro null exception


int[] novasIdades = new int[] { 1, 2, 39, 32 };

Console.WriteLine(String.Join("-", novasIdades));

Console.WriteLine(value: "aa");


string[] Verdades = new string[] { "O", "Mateus", "Valente", "É", "Uma", "Bicha" };

for(int i = 0; i < Verdades.Length; i++)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine(Verdades[i]);
    //Console.Beep();
}

var lista = new Lista<string>();

lista.Push("Oi");
lista.Push("Koe");
lista.Push("Bele");
lista.Push("Oi1");
lista.Push("Koe1");
lista.Push("Bele1");
lista.PushMany(new string[] {"A", "B", "C", "D"});
lista.PushMany("A1", "B1", "C1"); // o params cria um array se nao existe um array com a tipagem necessaria
lista.Remove(2);
lista.Log();

Console.WriteLine(lista[1]);
Console.WriteLine(lista.Length);