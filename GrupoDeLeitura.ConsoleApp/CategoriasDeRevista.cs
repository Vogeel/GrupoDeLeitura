using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class CategoriasDeRevista
    {
        public string nomeCategoria;
        public double diasQuePodeEmprestar;
        public Menssagem menssagem = new();

        public void CadastrarCategoria(Revista[] revista)
        {
            Console.WriteLine("Qual o nome da categoria que deseja adcionar?");
            nomeCategoria = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Quantos dias esta categoria por ficar emprestada?");
            diasQuePodeEmprestar = Convert.ToDouble(Console.ReadLine());
        }
            
            



    }
}
