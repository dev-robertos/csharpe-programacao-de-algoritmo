using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj10921_L1_EX01
{
    internal class C10921_L1_EX01
    {
        static void Main(string[] args)
        {
            // Exercício 01.

            // Área da Sala

            #region

            double L, C, AREA;

            Console.Write("Digite a largura da sala (L): ");
            L = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o comprimento da sala (C): ");
            C = Convert.ToDouble(Console.ReadLine());

            AREA = L * C;

            Console.WriteLine("A área da sala é (AREA): " + AREA + " m²");

            Console.ReadKey();

            #endregion

        }
    }
}
