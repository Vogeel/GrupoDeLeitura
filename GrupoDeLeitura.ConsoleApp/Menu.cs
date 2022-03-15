using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Menu
    {
        public int opcao;
        public int MenuPrincipal()
        {
            Console.WriteLine
                ("=======================================================\n" +
                "Digite 1 para adicionar uma revista\n" +
                "Digite 2 para adicionar uma caixa\n" +
                "Digite 3 para adicionar um amigo\n" +
                "Digite 4 para fazer um emprestimo\n" +
                "\n======================================================\n"+
                "Digite 5 para visualizar as revistas\n" +
                "Digite 5 para visualizar as caixas\n" +
                "Digite 5 para visualizar os amigos\n" +
                "Digite 5 para visualizar os emprestimos\n" +
                "=======================================================");
            opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

    }
}
