using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para mostrar los números del 1 al 10.No se debe realizar
            //ningún pedido de datos.USANDO WHILE.
            int x=0;
            while (x<10)
            {
                Console.WriteLine(x+1);
                x++;
            }
            Console.ReadKey();
        }
    }
}
