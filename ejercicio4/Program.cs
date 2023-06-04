using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite dos números y luego muestre los números
            //entre el menor y el mayor de ellos. Acordate, usando While.

            // lo resolvi de esta forma pero tambien se puede hacer definiendo el menor y el mayor en una variable max y men por ejemplo y luego compararlos en el while.
            int n1 ,n2 ;
            bool aux=false;
            Console.WriteLine("ingrese dos numeros");
            n1=int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            while (n1<n2)
            {
                n1++;
                if (n1<n2)
                {
                    Console.WriteLine(n1);
                }
                aux=true;
            }
           
            while (n2<n1)
            {
                n2++;
                if (n2 < n1)
                {
                 Console.WriteLine(n2);

                }
                aux=true;
            }
            if (aux==false)
            {
                Console.WriteLine("los numeros son iguales");
            }
            Console.ReadKey();
        }
    }
}
