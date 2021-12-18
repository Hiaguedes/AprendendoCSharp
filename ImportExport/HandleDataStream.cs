using System;
// ficou fatando coisas da classe File do C#
using System.Text;
using ByteBank.Modelos;

namespace ImportExport;

public class HandleDataStream
{
    
    private string PATH = "contasExportadas.csv";
    private string PATH_TXT= "teste.txt";
    public void Leitor (string path)
    {
        using (var fileFlow = new FileStream(path, FileMode.Open))
            using (var leitor = new StreamReader(fileFlow, Encoding.UTF8))
            {
                while (!leitor.EndOfStream)
                {
                var linha = leitor.ReadLine();
                var conta = CovertToContaCorrente(linha);
                
                Console.WriteLine(conta.ToString());
                }
            }
    }

    public void CriarCSV()
    {
        using (var fs = new FileStream(PATH, FileMode.Create))
        {
            var contaString = "45,12345,1000.30,Luiz Fernando";
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(contaString);
            
            fs.Write(bytes, 0, bytes.Length);
        }
    }

    public void WriteCSV()
    {
        using (var fs = new FileStream(PATH_TXT, FileMode.Create))
        {
            using (var writer = new StreamWriter(fs, Encoding.UTF8))
            {
                writer.WriteLine("123, 34567,1200, Pedro");
                writer.Flush();
            };
        }
    }

    public void WriteNote()
    {
        using(var entryFLow = Console.OpenStandardInput())
        using (var fs = new FileStream("console.txt", FileMode.Create))
            using(var writer = new StreamWriter(fs, Encoding.UTF8))
        {
            var buffer = new byte[1024];

            while (true)
            {
                var bytesLidos = entryFLow.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, bytesLidos);
                fs.Flush();
                
                // writer.Write();
                // writer.Flush();
                
                Console.WriteLine($"Foi lido {bytesLidos}");
            }
        }
                
                
    }

    public void BinaryWriter()
    {
        using(var fs = new FileStream(PATH_TXT,FileMode.Create))
        using (var writer = new BinaryWriter(fs))
        {
            writer.Write(464);
            writer.Write(12345);
            writer.Write(4000.50);
            writer.Write("Alessandro");
        }
    }
    
    public void BinaryReader()
    {
        using(var fs = new FileStream(PATH_TXT,FileMode.Open))
        using (var reader = new BinaryReader(fs))
        {
            var agencia = reader.ReadInt32();
            var numero = reader.ReadInt32();
            var saldo = reader.ReadDouble();
            var nomeTitular = reader.ReadString();
            
            Console.WriteLine(nomeTitular, agencia, numero, saldo);
        }
    }
    static ContaCorrente CovertToContaCorrente(string linha)
    {
        // agencia numero saldo titular
        string[] campos = linha.Split(',');
        
        var agencia = int.Parse(campos[0]);
        var numero = int.Parse(campos[1]);
        var saldo = double.Parse(campos[2].Replace('.', ','));
        var titular = campos[3];
        
        return new ContaCorrente(agencia, numero)
        {
            Saldo = saldo,
            Titular =
            {
                nome= titular,
                cpf= "",
            }
        };
        
    }
    }
