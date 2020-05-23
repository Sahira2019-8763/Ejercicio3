using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            double num;

            Console.WriteLine("Digite un número para verificar si es par o impar");
            num = Convert.ToDouble(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }

            Console.Read();
            //Sahira Reyes Meddina 2019-8763
        }
    }
}
