using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Revista
    {
        public bool estaDisponivel = true;
        public int anoDaRevista;
        public string tipoDeColecao;
        int adicinarRevistaCaixa;
        public int numeroDeEdicao;
        public int numeroCaixa;
        public int ano;
        
        public Caixa caixaDaRevista;

        public void RegistrarRevista(Caixa[] caixa)
        {

            Console.WriteLine("Qual o Ano da revista?");
            anoDaRevista = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Qual o numero de Edição da revista?");
            numeroDeEdicao = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Qual a coleção da revista?");
            tipoDeColecao = Convert.ToString(Console.ReadLine());



            Console.WriteLine("Qual a caixa que desejaguardar?");
            for (int i = 0; i < caixa.Length; i++)
            {
                if (caixa[i] == null)
                    continue;

                Console.WriteLine($"Caixa: {caixa[i].corCaixa}, {caixa[i].entiquetaCaixa}, {caixa[i].numeroCaixa}. Caixa numero: {i}");
            }



            adicinarRevistaCaixa = Convert.ToInt32(Console.ReadLine());
            caixaDaRevista = caixa[adicinarRevistaCaixa];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista registrada com sucesso :-)");
            Console.ResetColor();
            Console.ReadLine();

        }


        public void Mostrar(Revista[] revista)
        {
            for (int j = 0; j < revista.Length; j++)
            {

                if (revista[j] != null)
                {
                    Console.WriteLine("Coleção da revista: " + revista[j].tipoDeColecao);



                    Console.WriteLine("Numero de edição: " + revista[j].numeroDeEdicao);



                    Console.WriteLine("Ano da revista: " + revista[j].anoDaRevista);




                }
            }
            Console.ReadLine();
        }

    }


}



    

