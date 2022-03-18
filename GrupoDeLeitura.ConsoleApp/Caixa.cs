using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoDeLeitura.ConsoleApp
{
    internal class Caixa
    {
        public int numeroCaixa;
        public string corCaixa;
        public string entiquetaCaixa;
        public Menssagem menssagem = new ();
        

        public void RegistrarCaixa()
        {

            Console.WriteLine("Qual o numero da caixa?");
            numeroCaixa = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Qual a cor da caixa?");
            corCaixa = Convert.ToString(Console.ReadLine());



            Console.WriteLine("Qual a entiqueta da caixa?");
            entiquetaCaixa = Convert.ToString(Console.ReadLine());

            menssagem.Sucesso("Caixa Registrada com sucesso :-)");
        }
        public void Mostrar()
        {                      
                    Console.WriteLine("Numero da caixa: " + numeroCaixa);

                    Console.WriteLine("Cor da caixa: " + corCaixa);

                    Console.WriteLine("Entiqueta da caixa: " + entiquetaCaixa);
           
            Console.ReadLine();
        }
    }
}
