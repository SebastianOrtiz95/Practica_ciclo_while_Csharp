using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una lista de números que corta cuando se
            //ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.

            int menor=0, segMenor=0,n1;
            bool banMenor = false,banSegMenor=false;
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            while (n1!=0)
            {
                if (banMenor==false)
                {
                    menor = n1;
                    segMenor = 0;
                    banMenor = true;
                }
                else
                {
                    if (n1<menor)
                    {
                        segMenor=menor;
                        menor = n1;
                    }
                    else
                    {
                        if (banSegMenor==false)
                        {
                            segMenor = n1;
                            banSegMenor = true;
                        }
                        else
                        {
                          if (n1<segMenor)
                          {
                            segMenor = n1;
                          }

                        }
                    }
                }
               
                n1 = int.Parse(Console.ReadLine());
            }
            if (menor!=0 && segMenor!=0)
            {
              Console.WriteLine("el menor de los numeros fue " + menor);
              Console.WriteLine("el segundo menor fue " + segMenor);

            }
            else
            {
                Console.WriteLine("solo se ingreso un numero minimo debe ingresar dos");
            }
            Console.ReadLine();
        }
    }
}
