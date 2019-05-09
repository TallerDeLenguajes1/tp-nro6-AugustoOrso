using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_6_Orso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            int a, r, invertido;

            Console.Write("Ingrese el numero a invertir:");
           
            a = Convert.ToInt32(Console.ReadLine()); // Conversor a int
        
            Console.Write(a);  //Muestro el numero ingresado
            Console.WriteLine();

            if (a <= 0)     //  Si es menor o igual a 0 no lo invierte
            {
                Console.Write("El numero no se puede invertir");
            }
            else
            {
                invertido = 0;
                while (a != 0)      //  Invierto el numero
                {
                    r = a % 10;
                    a = a / 10;
                    invertido = invertido * 10 + r;
                }
                Console.Write("El numero invertido es:");
                Console.Write(invertido);      //Muestro el numero invertido
                Console.ReadKey();
            }           
        }
    }
}
