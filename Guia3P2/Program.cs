using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia3P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Calculadora basica:
             * Objetivo: Crear una calculadora simple que pueda sumar, restar, multiplicar o dividir dos numeros.
             * Producto esperado: Un programa que solicita al usuario dos numeros y una operacion, luego muestra el 
             * resultado de la operacion.
            */
            Console.WriteLine("Ingrese el primer numero:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Elige la operacion:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Producto");
            Console.WriteLine("4. Division");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"La suma es: {numero1 + numero2}");
                    break;
                case 2:
                    Console.WriteLine($"La resta es: {numero1 - numero2}");
                    break;
                case 3:
                    Console.WriteLine($"El producto es: {numero1 * numero2}");
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        Console.WriteLine($"La division es: {numero1 / numero2}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;    
            }

            Console.ReadLine();            
        }
    }
}
