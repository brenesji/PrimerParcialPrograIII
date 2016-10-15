using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograTresParcialUno
{
    public class DiagonalDifference
    {
        public int Matrix(string StringToConvert)
        {
            int resultado = 0; // este es el resultado final
            int SumaDiagonal = 0; //suma de la primera diagonal
            int SumaOtraDiagonal = 0; //suma de la otra diagonal
            int row = 0; int column = 0; //creo ls variables de filas y columnas

            int tamano=0; //para realizar el tamano del vector
            string[] filas = StringToConvert.Split(' '); //comienzo a hacer un arreglo de filas quitando los espacios

            foreach (string line in filas) // recorro cada linea en el arreglo filas
            {
                if (line != "|") //delimito que llegue hasta el pipeline
                {
                    tamano++; // comienzo a contar los numero que hay para hacer el tamano del vector
                }
                else
                {
                    break;
                }

            }

            int[,] vector = new int[tamano, tamano]; // una vez que tengo la cantidad de numero puedo asignarle el tamano al vector
            
            string[] newfilas = StringToConvert.Split(' '); //me preparo para volver a recorrer el string y quitar espacios

            foreach (string line in newfilas) // recorro cada linea una vez mas
            {
                if (line != "|")  //delimito hasta pipeline
                {
                    vector[row, column] = Int32.Parse(line); //comienzo a convertir a entero cada valor y lo posiciono en el arreglo
                    column++; //sumo para irme cambiando de campo en la columna
                    // Console.WriteLine(line);
                }
                else
                {
                    column = 0;
                    row++; //sumo para irme cambiando de campo en la fila

                }

            }

            //empieza la suma de las diagonales

            for (int i = 0; i < tamano; i++) //comienzo a recorrer el vector para sumarlo, el largo es el tamano que le di
            {
                SumaDiagonal = SumaDiagonal + vector[i, i]; //va sumando los valores q se encuentran en su respectivo campo

                if (i != tamano)  //si i es diferente del tamabno asignado tons va sumando

                    SumaOtraDiagonal = SumaOtraDiagonal + vector[i, 2 - i]; //va sumando los valores q se encuentran en su respectivo campo mientras i sea diferente del tamano

            }

            resultado = SumaDiagonal - SumaOtraDiagonal;

            return resultado;


        }
    }
}
