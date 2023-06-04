using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel
            //aclaratorio si el mismo es primo o no es primo.

            int n1,x=1,cont=0;
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            while (x<=n1)
            {
                if (n1%x==0)
                {
                   cont++;
                }
                x++;
            }
            if (cont==2)
            {
                Console.WriteLine("el numero es primo");
            }
            else
            {
                Console.WriteLine("no es primo");
            }
            Console.ReadKey();
        }
    }
}
