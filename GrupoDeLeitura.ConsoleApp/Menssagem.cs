using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Menssagem
    {
        
        public void Erro(string mensagen)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mensagen);
            Console.ResetColor();
            Console.ReadKey();
        }
        public void Sucesso(string mensagen)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mensagen);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
