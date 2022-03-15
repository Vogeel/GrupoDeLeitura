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

        public int caixaDaRevista;

        public void RegistrarCaixa()
        {

            Console.WriteLine("Qual o numero da caixa?");
            numeroCaixa = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Qual a cor da caixa?");
            corCaixa = Convert.ToString(Console.ReadLine());



            Console.WriteLine("Qual a entiqueta da caixa?");
            entiquetaCaixa = Convert.ToString(Console.ReadLine());
        }
        public void Mostrar(Caixa[] caixa)
        {
            for (int j = 0; j < caixa.Length; j++)
            {

                if (caixa[j] != null)
                {
                    Console.WriteLine("Numero da caixa: " + caixa[j].numeroCaixa);



                    Console.WriteLine("Cor da caixa: " + caixa[j].corCaixa);



                    Console.WriteLine("Entiqueta da caixa: " + caixa[j].entiquetaCaixa);




                }
            }
            Console.ReadLine();
        }
    }
}
