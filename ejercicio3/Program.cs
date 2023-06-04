using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite la edad de un grupo de personas. El programa
            //deberá pedir edades hasta que se ingrese una edad menor a 18 años.Deberá
            //mostrar por pantalla cuántas personas mayores se registraron.

            int edad,cont=0;
            Console.WriteLine("ingrese edad:");
            edad = int.Parse(Console.ReadLine());
            while (edad>=18)
            {
                edad=int.Parse(Console.ReadLine());
                cont++; 
            }
            if (cont==0)
            {
                Console.WriteLine("no se registraron mayores de edad");
            }
            else
            {
                Console.WriteLine("los mayores a 18 registrados fueron " + cont);
            }
            Console.ReadKey();
        }
    }
}
