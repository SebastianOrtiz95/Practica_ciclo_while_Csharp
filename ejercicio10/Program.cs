using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una lista de números que corta cuando se
            //ingresa un cero y luego emitir por pantalla el máximo de los números
            //negativos y el mínimo de los números positivos.

            int n1,maxPos=0,minNeg=0;
            bool banMaxPos=false, banMinNeg = false;   
            Console.WriteLine("ingrese un numero");
            n1=int.Parse(Console.ReadLine());
            while (n1!=0)
            {
                if (n1>0)
                {
                    if (banMaxPos==false)
                    {
                        maxPos = n1;
                        banMaxPos = true;
                    }
                    else
                    {
                        if (n1>maxPos)
                        {
                            maxPos = n1;
                            
                        }
                    }
                }
                else
                {
                    if (banMinNeg==false)
                    {

                        minNeg = n1;
                        banMinNeg=true;
                    }
                    else
                    {
                        if (n1<minNeg)
                        {
                            minNeg = n1;
                        }
                    }
                }
                n1 = int.Parse(Console.ReadLine()); 
            }
            if (maxPos!=0)
            {
              Console.WriteLine("el mayor de los positivos: " + maxPos);

            }
            else
            {
                Console.WriteLine("no se ingresaron numeros positivos");
            }
            if (minNeg!=0)
            {
              Console.WriteLine("el menor de los negativos: " + minNeg);

            }
            else
            {
                Console.WriteLine("no se ingresaron numeros negativos");

            }
            Console.ReadKey();
        }
    }
}
