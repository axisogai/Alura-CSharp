using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            float pontoFlutuante = 3.14f;   // aqui!

            double salario = 1270.50;
            int valor = (int)salario;
            Console.WriteLine(salario);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);

            Console.ReadLine();

        }
    }
}
