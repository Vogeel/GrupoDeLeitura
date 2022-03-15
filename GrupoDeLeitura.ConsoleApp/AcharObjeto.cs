using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class AcharObjeto
    {
        public int AcharPosicaoParaOObjeto(dynamic array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                    continue;
                return i;
            }
            return -1;
        }
    }
}
