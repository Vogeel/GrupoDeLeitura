using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Reserva
    {
        public Emprestimo emprestimo = new();
        public Pessoa amigo;
        
        
        public DateTime diaDaReservaDaRevista;
        
        TimeSpan dias;
        public Menssagem menssagem = new();
        AcharObjeto acharObjeto = new AcharObjeto();

        public void ReservarRevista(Revista[] revista, Pessoa[] pessoa)
        {
            for (int i = 0; i < pessoa.Length; i++)
            {
                if (pessoa[i] == null)
                    continue;

                Console.WriteLine($" Amigo: {pessoa[i].nome}\n numero de telefone: {pessoa[i].numero}\n Responsável: {pessoa[i].nomeDoResponsavel}\n amigo ID: {i}\n\n");

            }
            Console.WriteLine("qual Amigo você é? escolha o numero do ID");
            int posicaopessoaRervaRevista = Convert.ToInt32(Console.ReadLine());
            amigo = pessoa[posicaopessoaRervaRevista];
            pessoa[posicaopessoaRervaRevista].jaTemUmaRevista = true;


            menssagem.Sucesso("Amigo identificado :)");

            bool errou = false;
            do {
                if (errou == true)
                {
                    menssagem.Erro("Excedeu dois dias!");
                }

                do {
                    if (errou == true)
                    {
                        menssagem.Erro("Data inválida!!!");
                    }
                    Console.WriteLine("Qual dia você está fazendo a reserva?");
                    errou = true;
                } while (!(DateTime.TryParse(Console.ReadLine(), out diaDaReservaDaRevista)));

                dias = DateTime.Today - diaDaReservaDaRevista;
                errou = true;
            } while (dias.Days > 2);




            DateTime diasReservado = diaDaReservaDaRevista.AddDays(2);
            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null)
                    continue;

                Console.WriteLine($" Revista: Ano: {revista[i].anoDaRevista}\n Numero Edição: {revista[i].numeroDeEdicao}\n Coleção: {revista[i].tipoDeColecao}\n Revista ID: {i}");

            }
            Console.WriteLine("Qual revista deseja reservar? escola o numero do ID");
            int posicaoRevistaReservada = Convert.ToInt32(Console.ReadLine());
            revista[posicaoRevistaReservada].revistaReservada = true;

            menssagem.Sucesso($"Revista reservada até o dia: {diasReservado} com Sucesso");

            Console.WriteLine("Deseja fazer um emprestimo? (sim/nao)");
            string resposta = Console.ReadLine();
            if(resposta == "sim")
            {
                Console.WriteLine("Para qual dia?");
                emprestimo.dataDeEmprestimo = DateTime.Parse(Console.ReadLine());
                emprestimo.pegouARevista = pessoa[posicaopessoaRervaRevista];
                revista[posicaoRevistaReservada].estaDisponivel = false;
            }

        }
        public void Mostrar()
        {

        }
        

            
        
    }
}
