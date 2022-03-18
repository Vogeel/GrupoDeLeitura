using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Emprestimo
    {
        public Pessoa pegouARevista;
        public Revista revistaEmprestada;
        public DateTime dataDeEmprestimo;
        public DateTime dataDeFecharEmprestimo;
        public bool emprestimoAberto;
        int numeroRevista;
        int numeroPessoa;
        public Menssagem menssagem = new();
        DateTime diasParaEntregarRevista;



        public void RegistrarEmprestimo(Revista[] revista, Pessoa[] amigo, CategoriasDeRevista[] categoria)
        {
            emprestimoAberto = true;
            Console.WriteLine("Data do emprestimo");
            dataDeEmprestimo = DateTime.Parse(Console.ReadLine());

            for (int i = 0; i < revista.Length; i++)
            {
                if (revista[i] == null)
                    continue;

                Console.WriteLine($" Revista: Ano: {revista[i].anoDaRevista}\n Numero de Edição: {revista[i].numeroDeEdicao}\n Coleção: {revista[i].tipoDeColecao}\n Categoria: {categoria[i].nomeCategoria}\n Pode ficar" +
                    $" {categoria[i].diasQuePodeEmprestar} dias com ela\n Revista numero: {i}\n");
            }

            do
            {
                Console.WriteLine("qual revista deseja emprestar");

            } while (!(int.TryParse(Console.ReadLine(), out numeroRevista)) || revista[numeroRevista] == null || revista[numeroRevista].estaDisponivel == false || revista[numeroPessoa].revistaReservada == false);
            revistaEmprestada = revista[numeroRevista];
            revista[numeroRevista].estaDisponivel = false;




            for (int i = 0; i < amigo.Length; i++)
            {
                if (amigo[i] == null)
                    continue;

                Console.WriteLine($"Nome do amigo: {amigo[i].nome}, Nome do responsavel: {amigo[i].nomeDoResponsavel}, Endereço: {amigo[i].endereco}. Amigo numero: {i}");
            }

            do
            {
                Console.WriteLine("qual amigo deseja pegar emprestado");

            } while (!(int.TryParse(Console.ReadLine(), out numeroPessoa)) || amigo[numeroPessoa] == null || amigo[numeroPessoa].jaTemUmaRevista == true || amigo[numeroPessoa].EstaComMulta == true);
            pegouARevista = amigo[numeroPessoa];

            amigo[numeroPessoa].jaTemUmaRevista = true;

            diasParaEntregarRevista = dataDeEmprestimo.AddDays(categoria[numeroRevista].diasQuePodeEmprestar);

            menssagem.Sucesso($"Revista Emprestada com sucesso :-), deverá entregar até o dia: {diasParaEntregarRevista}");
            if (diasParaEntregarRevista > DateTime.Today)
                amigo[numeroPessoa].EstaComMulta = true;
        }

        


        public void Mostrar()
        {       
                    Console.WriteLine("Quem pegou a revista: " + pegouARevista.nome);

                    Console.WriteLine("Nome do responsavel " + pegouARevista.nomeDoResponsavel);

                    Console.WriteLine("Dia que pegou a revista " + dataDeEmprestimo.ToString("dd/MM/yyyy"));
            if (emprestimoAberto == true)
                Console.WriteLine("O emprestimo está aberto!");
            else
                Console.WriteLine("O emprestimo não está aberto!!");

            Console.ReadLine();           
        }
    }
}
