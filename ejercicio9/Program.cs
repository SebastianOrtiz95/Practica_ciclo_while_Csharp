using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la
            //posición en la que fue encontrado cada uno de los mínimos.

            int menor = 0, segMenor = 0, n1,posMenor=1,PosSegMenor=1,x=0;
            bool banMenor = false, banSegMenor = false;
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            while (n1 != 0)
            {
                if (banMenor == false)
                {
                    menor = n1;
                    segMenor = 0;
                    banMenor = true;
                    posMenor = 1;
                }
                else
                {
                    if (n1 < menor)
                    {
                        segMenor = menor;
                        menor = n1;
                        PosSegMenor = menor;
                        posMenor = x + 1;
                    }
                    else
                    {
                        if (banSegMenor == false)
                        {
                            segMenor = n1;
                            banSegMenor = true;
                            PosSegMenor = x + 1;
                        }
                        else
                        {
                            if (n1 < segMenor)
                            {
                                segMenor = n1;
                                PosSegMenor = x + 1;
                            }

                        }
                    }
                }
                x++;
                n1 = int.Parse(Console.ReadLine());
            }
            if (menor != 0 && segMenor != 0)
            {
                Console.WriteLine("el menor de los numeros fue {0} y su posicion fue el {1}° lugar",menor,posMenor);
                Console.WriteLine("el segundo menor fue {0} y su posicion fue el {1}° lugar",segMenor,PosSegMenor);

            }
            else
            {
                Console.WriteLine("solo se ingreso un numero minimo debe ingresar dos");
            }
            Console.ReadLine();
        }
    }
}
