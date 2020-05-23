using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, mult;

            Console.WriteLine("Digite un número para saber el resultado de su proucto:");
            num1 = Convert.ToByte(Console.ReadLine());

            if (num1==0)
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }
            else {
                Console.WriteLine("Digite otro número");
                num2 = Convert.ToByte(Console.ReadLine());

                mult = num1 * num2;
                Console.WriteLine("El producto de ambos números es: " + mult);
                    }
            Console.Read();
        }
    }
}
