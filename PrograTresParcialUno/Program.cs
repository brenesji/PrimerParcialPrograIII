using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograTresParcialUno
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*********************************** ");
            Console.WriteLine("Primer Examen Parcial ");
            Console.WriteLine(" ");
            Console.WriteLine("Primera Parte ");
            Console.WriteLine(" ");

            DiagonalDifference resta = new DiagonalDifference();
            string StringToConvert = "11 2 4 | 4 5 6 | 10 8 -12";
            int result = resta.Matrix(StringToConvert);
            Console.WriteLine("El resultado de DiagonalDifference es: " + result);

            Console.WriteLine(" ");
            Console.WriteLine("Segunda  Parte ");
            Console.WriteLine(" ");

            camelCase camel = new camelCase();
            string phrase = "saveChangesInTheEditor"; //creo la frase que a la que le necesito contar las palabras 

            int cantidad = camel.calculate(phrase);
            Console.WriteLine("La cantidad de palabras en metodo camelCase: " + cantidad);
            Console.WriteLine(" ");
            Console.WriteLine("*********************************** ");
            Console.ReadKey(); // salgo hasta que el user digite una tecla
        }
    }
}
