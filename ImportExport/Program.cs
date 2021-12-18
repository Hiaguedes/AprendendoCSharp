// See https://aka.ms/new-console-template for more information
using ImportExport;
var enderecoArquivo = "contas.txt";

var dataStream = new HandleDataStream();

dataStream.Leitor(enderecoArquivo);

// dataStream.BinaryWriter();
// dataStream.BinaryReader(); 

dataStream.WriteNote();

// static void EscreverBuffer(byte[] buffer, int numeroBytesLidos)
// {
//     var TextFormat = System.Text.Encoding.Default; // padrao do sistema operacional
//     var texto = TextFormat.GetString(buffer, 0, numeroBytesLidos);
//     Console.Write(texto);
//
//     //foreach(var _byte in buffer)
//     //{
//     //    Console.Write((char)_byte);
//         
//     //}
// }