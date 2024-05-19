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
            /*
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
        */
            /*
             * Dias de la semana:
             * Objetivo: Desarrollar un programa que, dado un numero del 1 al 7,
             * muestre el dia correspondiente de la semana.
             * Producto esperado: Un programa que solicita al usuario un numero del 1 al 7 
             * y muestra el dia de la semana correspondiente.
            */
            int numeroDia;
            Console.WriteLine("Ingrese un numero del 1 al 7");
            numeroDia = int.Parse(Console.ReadLine());

            switch (numeroDia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Numero incorrecto");
                    break;
            }
            Console.ReadLine();
        }

    }
}
