using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj10921_L1_EX11
{
    internal class C10921_L1_EX11
    {
        static void Main(string[] args)
        {
            //Exercício 11.

            //Quantos tijolos são necessários para construir uma determinada parede.

            #region

            double CT, LT, CP, LP;
            double TJL, PRD, QTD;

            Console.Write("Digite o comprimento do tijolo (CT): ");
            CT = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura do tijolo (LT): ");
            LT = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o comprimento da parede (CP): ");
            CP = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura da parede (LP): ");
            LP = Convert.ToDouble(Console.ReadLine());

            TJL = CT * LT;

            PRD = CP * LP;

            QTD = Math.Ceiling(PRD / TJL);

            //O código Math.Ceiling() é utilizado para arredondar o resultado para cima.
            //No video que utilizei para aprender o cálculo, o profissional da área da construção diz que, como não podemos comprar tijolos pela metade, era bom que arredondassemos o resultado para cima.
            //Considerando a experiência de uso do cliente, achei interessante o programa oferecer esse resultado arredondado, sem que o cliente precise pensar em fazer esse cálculo.
            //Já que, na pressa e correria do dia a dia, às vezes focamos apenas em resolver o problema, e não na forma que resolvemos o problema.

            Console.WriteLine("A quantidade de tijolos necessária para construir a parede é: " + QTD);

            Console.ReadKey();

            #endregion

        }
    }
}
