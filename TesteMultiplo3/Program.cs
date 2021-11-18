using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteMultiplo3
{
    class Program
    {
        static void Main(string[] args)
        {

            //A abordagem que utiliza o resto da divisão é:
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }



            Console.ReadLine();

        }
    }
}
