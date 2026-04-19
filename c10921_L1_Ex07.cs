using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj10921_L1_EX07
{
    internal class C10921_L1_EX07
    {
        static void Main(string[] args)
        {

            //Exercício 07.

            //Exercício para calcular o volume de uma esfera.

            #region

            double R, VOL;

            Console.Write("Digite o raio da esfera (R): ");
            R = Convert.ToDouble(Console.ReadLine());

            VOL = 3.14 * Math.Pow(R, 2);

            //Precisei reproduzir o R² e encontrei o código: Math.Pow(R,2). O código serve como uma expressão de potência, onde R é a base, e 2 é o expoente.

            Console.WriteLine("O volume da esfera é: " + VOL);

            Console.ReadKey();

            #endregion

        }
    }
}
