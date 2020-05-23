using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, num;
            Console.WriteLine("Digite un número:");
            numero = Convert.ToByte(Console.ReadLine());

            if (numero%10==0)
            {
                Console.WriteLine("El número es múltiplo de 10");
                Console.WriteLine("                 ");
                Console.WriteLine("Favor digite otro número para saber si también es múltiplo de 10");
                num = Convert.ToByte(Console.ReadLine());
                if(num%10==0)
                {
                    Console.WriteLine("Este número también es múltiplo de 10");
                } else
                {
                    Console.WriteLine("Este número no es múltiplo de 10");
                }
            } else
            {
                Console.WriteLine("Este número no es múltiplo de 10");
            }

            Console.Read();



        }
    }
}
