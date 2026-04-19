using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj10921_L1_EX06
{
    internal class C10921_L1_EX06
    {
        static void Main(string[] args)
        {


            //Exercício 06.

            //Descobrir a idade atual de uma pessoa, a partir do ano atual (AA) e do ano de nascimento (AN).

            #region

            int AA, AN, IDD;

            Console.Write("Digite o ano atual: ");
            AA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ano de nascimento: ");
            AN = Convert.ToInt32(Console.ReadLine());

            IDD = AA - AN;

            Console.WriteLine("A idade atual dessa pessoa é: " + IDD + " anos");

            Console.ReadKey();

            #endregion

        }
    }
}
