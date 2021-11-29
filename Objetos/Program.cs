using ByteBank.Funcionarios;

Console.WriteLine("Resultado to String " + new Desenvolvedor("111111").ToString());

object dev1 = new Desenvolvedor("111111");
object dev2 = new Desenvolvedor("111111");

Console.WriteLine(dev1.Equals(dev2));