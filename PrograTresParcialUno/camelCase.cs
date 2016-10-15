using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograTresParcialUno
{
    public class camelCase
    {
     public int calculate(string phrase) // el metodo calculate esta recibiendo como parametro el string phrase
        {
            int cant = 1; // creo un contador para ir guardando la cantidad de palabras

            for (int i = 0; i < phrase.Length; i++) //recorro el largo del string con un lenght
            {
                if (char.IsUpper(phrase[i])) // verifico si el caracter es upper case y guardo cada caracter en phrase [i]

                    cant = cant + 1; // le sumo 1 al contador cada vez que encuentre un caracter en mayuscula
            }

            return cant; // el metodo calculate lo que retorna es la cantidad de palabras y eso luego se muestra en main

        }

    }
}
