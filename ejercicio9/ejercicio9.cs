﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, n3;

            Console.WriteLine("Digite un número");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite otro número");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite otro número");
            n3 = Convert.ToDouble(Console.ReadLine());


            if((n1>n2) && (n2>n3))
            {
                Console.WriteLine("el mayor es " + n1);

            } else if ((n1 < n2) && (n2 > n3))
            {
                Console.WriteLine("El mayor es " + n2);
            } else
            {
                Console.WriteLine("El mayor es " + n3);
            }
            Console.Read();


        }
    }
}
