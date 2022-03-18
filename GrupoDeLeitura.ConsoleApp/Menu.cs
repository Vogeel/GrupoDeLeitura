using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Menu
    {
        public string opcao;
        public string MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================================================\n\n");
            Console.ResetColor();
            Console.WriteLine
                ("Digite 1 para adicionar uma revista\n" +
                "Digite 2 para adicionar uma caixa\n" +
                "Digite 3 para adicionar um amigo\n" +
                "Digite 4 para fazer um emprestimo\n" +
                "Digite 5 para fazer uma Reserva de Revista\n");

                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================================================\n\n");
            Console.ResetColor();

            Console.WriteLine("Digite 6 para visualizar as revistas\n" +
                "Digite 7 para visualizar as caixas\n" +
                "Digite 8 para visualizar os amigos\n" +
                "Digite 9 para visualizar os emprestimos\n" +
                "Digite 10 para visualizar as reservas\n");

              Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=======================================================\n\n");
            Console.ResetColor();

            Console.WriteLine("Digite s para sair");
            opcao = Convert.ToString(Console.ReadLine());
            return opcao;
        }

    }
}
