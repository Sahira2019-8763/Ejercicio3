using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite un número para verificar si es multiplo e 4 o de 5");
            numero = Convert.ToByte(Console.ReadLine());

            if (numero % 4 == 0)
            {
                Console.WriteLine("El número es múltiplo de 4");
            } else if (numero % 5 == 0)
            {
                Console.WriteLine("El número es múltiplo de 5");
            } else
            {
                Console.WriteLine("El número no es múltiplo de 4 ni de 5!");
            }
            Console.Read();







        }
    }
}
