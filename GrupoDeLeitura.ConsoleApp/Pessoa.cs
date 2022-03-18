using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Pessoa
    {
        public string nome;
        public string nomeDoResponsavel;
        public int numero;
        public string endereco;
        public bool jaTemUmaRevista = false;
        public bool EstaComMulta = false;
        public Menssagem menssagem = new ();
        public void RegistrarPessoa()
        {

            Console.WriteLine("Qual o nome do amigo?");
            nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Qual o nome do responsavel?");
            nomeDoResponsavel = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Qual o numero do responsavel?");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual endereço?");
            endereco = Convert.ToString(Console.ReadLine());

            menssagem.Sucesso("Pessoa registrada com sucesso :-)");
        }
        public void Mostrar()
        {            
         Console.WriteLine("Amigo: " + nome);

         Console.WriteLine("Nome do responsavel" + nomeDoResponsavel);

         Console.WriteLine("Endereço: " + endereco);

         Console.WriteLine("Numero do responsavel: " + numero);

            if (jaTemUmaRevista == true)
                Console.WriteLine("Esse amigo está com uma revista!");
            else
                Console.WriteLine("Esse amigo não está com nenhuma revista");

            if (EstaComMulta == true)
            {

                menssagem.Erro("Este amigo está devendo!! coloteiro.\n");
                Console.WriteLine("Ele deseja quitar as multas?(sim/nao");
                string quitarmulta = Console.ReadLine();

                if (quitarmulta == "sim")
                {
                    EstaComMulta = false;
                    menssagem.Sucesso("Multa quitada :-)");
                    Console.ReadLine();
                }
                else
                    menssagem.Erro("Cuidado com suas amizades!");
                                   
            }
            else
                Console.WriteLine("Esse amigo não está devendo, Score bom!");

        
                      
            Console.ReadLine();
        }
    }
}
