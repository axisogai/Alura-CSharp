using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

            double valorInvestido = 1000;

            //int contadorMes = 1; contadorMes <= 12; contadorMes=contadorMes+1
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                //valorInvestido = valorInvestido * 1.0036;
                valorInvestido *= 1.0036;

                Console.WriteLine("Após " + contadorMes +
                " meses, você terá R$" + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
