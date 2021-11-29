using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringsChar
{
    internal class ExtratorArgumentos
    {
        public string URL { get; }
        private string _args { get; }
        public ExtratorArgumentos(string url)
        {
            if(VerificaNullOrEmpty(url)) { throw new ArgumentException("O argumento " + nameof(url) + " nao pode ser nulo ou vazio"); }

            URL = url;
            int indexInterrogation = url.IndexOf('?');
            _args = url.Substring(indexInterrogation + 1);
        }

        private bool VerificaNullOrEmpty(string texto)
        {
            return String.IsNullOrEmpty(texto);
        }

        public string GetValor(string nomeParam)
        {
            nomeParam += '=';
            int indexParam = _args.IndexOf(nomeParam);

            if(indexParam == -1) { throw new ArgumentException("Parametro inexistente"); }

            int paramLength = nomeParam.Length;

            string rawValue = _args.Substring(indexParam + paramLength);

            char[] options = { '&' };
            int indexToRemove = rawValue.IndexOfAny(options);

            if(indexToRemove == -1) { 
                return rawValue; 
            }
            string value = rawValue.Remove(indexToRemove);

            return value;
        }
    }
}
