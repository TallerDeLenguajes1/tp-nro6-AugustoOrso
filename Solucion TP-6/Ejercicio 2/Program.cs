using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, opcion, result;

            Console.Write("Ingrese el primer valor:");
            a = Convert.ToInt32( Console.ReadLine());
            Console.Write("Ingrese el segundo valor:");
            b = Convert.ToInt32(Console.ReadLine());

            do {
                Console.Write("¿Que operacion desea realizar?");
                Console.WriteLine();
                Console.Write("1.- SUMA");
                Console.WriteLine();
                Console.Write("2.- RESTA");
                Console.WriteLine();
                Console.Write("3.- MULTIPLICACION");
                Console.WriteLine();
                Console.Write("4.- DIVISION");
                Console.WriteLine();
                Console.WriteLine("opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());
                 

            
            opcion = Convert.ToInt32(Console.ReadLine());
            }


            Console.ReadKey();

          
             
        }
            static public int Calculadora(int a, int b, int opcion) {
            int result;
            switch (opcion)
            {
                case 1:
                    result = a + b;
                    break;
                case 2:
                    result = a - b;
                    break;

                case 3:
                    result = a * b;
                    break;

                default:
                    result = a / b;
                    break;
            }

            Console.WriteLine();
            Console.Write("El resultado de la operacion elegida es:");
            Console.Write(result);
        }

    }
}
