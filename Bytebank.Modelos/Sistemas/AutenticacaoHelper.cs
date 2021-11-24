using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Sistemas
{
    internal class AutenticacaoHelper // internal e pra uso interno do projeto
    {
        public static bool CompararSenhas(string senhaReal, string senhaTentativa)
        {
            return senhaReal == senhaTentativa;
        }
    }
}
