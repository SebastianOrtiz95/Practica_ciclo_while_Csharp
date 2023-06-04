using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una lista de números que corta cuando se
            //ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
            //en la que fue ingresado.
            
            double n1,max=0;
            int pos=0,x=0;
            bool banMax = false;
            Console.WriteLine("ingrese un numero");
            n1 = double.Parse(Console.ReadLine());
            while (n1!=0)
            {
                
                if (banMax==false)
                {
                    max= n1;
                    pos = 1;
                    banMax= true;
                }
                else
                {
                   if (n1>max)
                   {
                     max= n1;
                     pos = x + 1;
                   }

                }
                x++;
                n1 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("el mayor numero ingresado fue " + max);
            Console.WriteLine("el numero fue ingresado en el {0}° lugar", pos);
            Console.ReadKey();
        }
    }
}
