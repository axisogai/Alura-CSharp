using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double FatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= FatorRendimento;
                }
                FatorRendimento += 0.0010;

               
            }
            Console.WriteLine("Ao término do investimentovocê terá R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
