﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;  // Compila!
            Console.WriteLine(valor);

            valor = (char)(valor + 1);   // Compila!
            Console.WriteLine(valor);

            string palavra = "alura cursos online de tecnologia " + 2020;
            Console.WriteLine(palavra);



            Console.ReadLine();


        }
    }
}
