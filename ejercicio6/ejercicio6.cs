using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            double res;

            Console.WriteLine("Digite un número para saber el resultado de su división");
            num1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Digite otro número");
            num2 = Convert.ToByte(Console.ReadLine());

            if(num2==0)
            {
                Console.WriteLine("ERROR! No se puede dividir entre cero");
            } else
            {
                res = num1 / num2;
                
                Console.WriteLine("El resultado de dividir " + num1 + " entre " + num2 + " es: " + res);
            }

            Console.Read();
        }
    }
}
