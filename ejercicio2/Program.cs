using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para mostrar los números del 10 al 1.No se debe realizar
            //ningún pedido de datos.USANDO WHILE.

            int x = 10;
            while (x>0)
            {
                Console.WriteLine(x);
                x--;
            }
            Console.ReadKey();  
        }
    }
}
