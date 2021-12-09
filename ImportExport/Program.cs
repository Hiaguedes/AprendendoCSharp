// See https://aka.ms/new-console-template for more information
var enderecoArquivo = "contas.txt";

using(var fs = new FileStream(enderecoArquivo, FileMode.Open))
{

    var buffer = new byte[1024]; // representa 1kB
    var numeroBytesLidos = -1;


    while (numeroBytesLidos != 0)
    {
        numeroBytesLidos = fs.Read(buffer); // tamanho do buffer, comeca da onde e termina aonde
        EscreverBuffer(buffer, numeroBytesLidos);
    }
}

static void EscreverBuffer(byte[] buffer, int numeroBytesLidos)
{
    var TextFormat = System.Text.Encoding.Default; // padrao do sistema operacional
    var texto = TextFormat.GetString(buffer, 0, numeroBytesLidos);
    Console.Write(texto);

    //foreach(var _byte in buffer)
    //{
    //    Console.Write((char)_byte);
        
    //}
}