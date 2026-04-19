using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj10921_L1_EX09
{
    internal class C10921_L1_EX09
    {
        static void Main(string[] args)
        {

            //Exercício 09.

            //Conversão de moeda.

            //Valor do dólar em reais no dia 15/03/2026 às 17:35: R$ 5,33.

            #region

            decimal VAL_DOLAR, COT, VAL_REAL;

            Console.Write("Digite o valor em dólar: $");
            VAL_DOLAR = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a cotação do dólar: R$");
            COT = Convert.ToDecimal(Console.ReadLine());

            VAL_REAL = VAL_DOLAR * COT;

            Console.WriteLine("O valor em reais é: R$" + VAL_REAL.ToString("F2"));

            Console.ReadKey();

            #endregion


        }
    }
}
