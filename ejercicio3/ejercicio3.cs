using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
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

            if (num1%num2==0)
            {
                Console.WriteLine("El primer número es múltiplo del segundo");
            } else
            {
                Console.WriteLine("El primer número no es múltiplo del segundo");
            }
            Console.Read();

        }

    }
}
