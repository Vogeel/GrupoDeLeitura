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
        int adicionarRevistaCategoria;
        public int numeroDeEdicao;
        public bool revistaReservada = false;
        public Menssagem menssagem = new ();
        public Caixa caixaDaRevista;
        public CategoriasDeRevista categoriaDaRevista;

        public void RegistrarRevista(Caixa[] caixa, CategoriasDeRevista[] categoria)
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

            Console.WriteLine("Qual categoria esta revista se encaixa?");

            for (int i = 0; i < categoria.Length; i++)
            {
                if (categoria[i] == null)
                    continue;

                Console.WriteLine($"{categoriaDaRevista.nomeCategoria} \nPode ser emprestada ate: {categoriaDaRevista.diasQuePodeEmprestar}\n  Id : {i} " );
            }
            Console.WriteLine("Qual Categoria quer? escolha pelo ID");
            adicionarRevistaCategoria = Convert.ToInt32(Console.ReadLine());
            categoriaDaRevista = categoria[adicionarRevistaCategoria];

            menssagem.Sucesso("Revista registrada com sucesso :-)");

        }


        public void Mostrar()
        {        
                    Console.WriteLine("Coleção da revista: " + tipoDeColecao);

                    Console.WriteLine("Numero de edição: " + numeroDeEdicao);

                    Console.WriteLine("Ano da revista: " + anoDaRevista);

            Console.WriteLine("Categoria da revista: " + categoriaDaRevista.nomeCategoria);

            Console.WriteLine("Devolução da categoria: "+ categoriaDaRevista.diasQuePodeEmprestar);

            Console.ReadLine();
        }

    }


}



    

