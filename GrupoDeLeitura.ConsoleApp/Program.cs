using System;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Revista[] revista = new Revista[100];
            Caixa[] caixa = new Caixa[100];
            Pessoa[] pessoa = new Pessoa[100];
            Emprestimo[] emprestimo = new Emprestimo[100];
            AcharObjeto acharObjeto = new AcharObjeto();
            Reserva[] reserva = new Reserva[100];
            CategoriasDeRevista[] categoria = new CategoriasDeRevista[100];
            do
            {
                switch(menu.MenuPrincipal())
                {
                    case "1":
                        int posicao = acharObjeto.AcharPosicaoParaOObjeto(revista);
                        revista[posicao] = new();
                        revista[posicao].RegistrarRevista(caixa, categoria);                        
                        break;

                    case "2":
                        posicao = acharObjeto.AcharPosicaoParaOObjeto(caixa);
                        caixa[posicao] = new();
                        caixa[posicao].RegistrarCaixa();
                        break;

                    case "3":
                        posicao = acharObjeto.AcharPosicaoParaOObjeto(pessoa);
                        pessoa[posicao] = new();
                        pessoa[posicao].RegistrarPessoa();
                        break;

                   case "4":
                        posicao = acharObjeto.AcharPosicaoParaOObjeto(emprestimo);
                        emprestimo[posicao] = new();
                        emprestimo[posicao].RegistrarEmprestimo(revista, pessoa, categoria);
                        break;

                    case "5":
                        posicao = acharObjeto.AcharPosicaoParaOObjeto(reserva);
                        reserva[posicao] = new();
                        reserva[posicao].ReservarRevista(revista, pessoa);
                        break;

                    case "6":
                        Mostrar(revista);
                        break;

                    case "7":
                        Mostrar(caixa);
                        break;

                    case "8":
                        Mostrar(pessoa);
                        break;

                    case "9":
                        Mostrar(emprestimo);
                        break;

                    case "10":
                        Mostrar(reserva);
                        break;
                  
                    case "s":
                        return;
                        

                }
            }while (true);
        }

        private static void Mostrar(dynamic[] variavel)
        {
            for (int i = 0; i < variavel.Length; i++)
            {
                if (variavel[i] == null)
                    continue;
                Console.WriteLine($"ID : {i}");
                variavel[i].Mostrar();
            }
        }
    }
}
