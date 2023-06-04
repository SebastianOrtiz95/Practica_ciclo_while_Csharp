using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar una lista de números que corta cuando se
            //ingresa un cero y luego mostrar: la cantidad de números primos, la cantidad de
            //números pares, la cantidad de positivos y la cantidad de negativos.

            int n1,contNeg=0,contPos=0,contPrimos=0,contPares=0;
            Console.WriteLine("ingrese un numero");
            n1=int.Parse(Console.ReadLine());
            while (n1!=0)
            {
                if (n1>0)
                {
                    contPos++;  
                }
                else
                {
                    contNeg++;
                }
                if (n1%2==0)
                {
                    contPares++;
                }

                int cont = 0;
                for (int  x = 1; x<=n1; x++)
                {
                    if (n1%x==0)
                    {
                        cont++;
                    }
                }
                if (cont==2)
                {
                    contPrimos++;
                }

                n1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("cantidad de pares: " + contPares);
            Console.WriteLine("cantidad de negativos: " + contNeg);
            Console.WriteLine("cantidad de positivos: " + contPos);
            Console.WriteLine("cantidad de primos: " + contPrimos);
            Console.ReadKey();
        }
    }
}
