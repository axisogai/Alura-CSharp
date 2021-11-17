using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Conversoes e Outros Tipos Numericos");

            double salario;
            salario = 1200.50;

            //O int é um tipo de variável que suporta valores até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // O long é uma variável de 64 bits
            long idade; 
            idade = 13000000000;
            Console.WriteLine(idade);

            //O short é um tipo de variável de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine(); 

        }
    }
}
