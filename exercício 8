using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj10921_L1_EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercício 08.

            //Calcular o valor que deve ser pago pelo cliente pelo tempo em que ele utilizar o estacionamento.

            #region

            int HE, ME, HS, MS;
            double TEMPO, PAG;

            Console.Write("Digite a hora de entrada: ");
            HE = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite os minutos de entrada: ");
            ME = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a hora de saída: ");
            HS = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite os minutos de saída: ");
            MS = Convert.ToInt32(Console.ReadLine());

            TEMPO = ((HS * 60 + MS) - (HE * 60 + ME));

            PAG = TEMPO * (4.00 / 60);

            // Depois de algum tempo tentando entender porque o resultado dava zero, encontrei a resposta.
            // O C# entende que, quando não há um número decimal representado no código, o resultado da divisão é apenas o número inteiro.
            // O número 4 dividido para 60 é igual a 0,06. Na lógica do C#, por ser um número inteiro (o 4 sozinho), apenas o 0 é considerado. Dessa forma, o resultado da equação era sempre zero.
            // Por isso é necessário expressar "4.00" para que o resultado seja um número decimal (0,06). Assim o C# entende que, o que vem depois da vírgula, também é importante.
            // Ainda na pesquisa entendi que a melhor representação para horas é int, pois horas são números inteiros.
            // Hora é apenas uma unidade de medida de minutos, por isso precisa ser convertido em minutos para que faça sentido na função matemática.

            Console.WriteLine("Valor do estacionamento: R$ " + PAG.ToString("F2"));

            Console.ReadKey();

            #endregion

        }
    }
}
