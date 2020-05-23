using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Digite un número");
            num1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite otro número");
            num2 = Convert.ToByte(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El primer número es mayor");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Los números " + "" + num1 + "" + " y " + "" + num2 + "" + " Son iguales!");

            }
            else
            {
                Console.WriteLine("El segundo número es mayor");
            }

            Console.Read();
        }
    }
}
