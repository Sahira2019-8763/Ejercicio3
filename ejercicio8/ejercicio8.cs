using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2;

            Console.WriteLine("Digite un número");
            n1 = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Digite otro número");
            n2 = Convert.ToSByte(Console.ReadLine());

            if ((n1>0) && (n2 > 0))
            {
                Console.WriteLine("Ambos números son positivos");
            } else if ((n1<0) && (n2>0))
            {
                Console.WriteLine("Uno de los números es positivo");
            } else if ((n1>0) && (n2<0))
            {
                Console.WriteLine("Uno de los números es positivo");
            }  
            else
            {
                Console.WriteLine("Ninguno de los números es positivo");
            }
            Console.Read();
           
        }
    }
}
