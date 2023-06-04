using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que muestre los números del 1 al 100 de 5 en 5.Ejemplo:
            //0, 5, 10, 15, 20....100.Usando While.
            int x = 0;
            while (x<101)
            {
                if (x%5==0)
                {
                    Console.WriteLine(x);
                }
                x++;    
            }
            Console.ReadKey();
        }
    }
}
