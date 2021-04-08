using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.ContadorPalabras
{
    /// <summary>
    /// Realizar un software que solicite al usuario que ingrese un párrafo por teclado y el software
    /// cuente la cantidad de ocurrencias de cada palabra.Asimismo, deberá indicar la cantidad de
    /// palabras distintas que existen en el párrafo ingresado por el usuario
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, int> diccionario = new Dictionary <string, int>();

            int contador = 0;

            Console.WriteLine("Ingrese un párrafo: ");

            string[] parrafo = Console.ReadLine().Split(' ');


            foreach (string palabra in parrafo)
            {
                 foreach (string palabrarepetida in parrafo)
                {
                   if (palabra.Equals(palabrarepetida))
                  {
                     contador++;
                  }
                }
                
                if (diccionario.Count == 0)
                {
                    diccionario.Add(palabra, contador);
                }
                else
                {
                    bool repetido = false;

                    for (int i = 0; i < diccionario.Count; i++)
                    {
                        if (diccionario.ElementAt(i).Key.Equals(palabra) && diccionario.ElementAt(i).Value.Equals(contador))
                        {
                            repetido = true;
                            break;
                        }
                    }
                    if (repetido == false)
                    {
                        diccionario.Add(palabra, contador);
                    }
                }
                contador = 0;
            }

            Console.WriteLine("Contenido del diccionario: ");
            
            foreach (KeyValuePair<string, int> elemento in diccionario)
            {
                Console.WriteLine(elemento.Key + " " + elemento.Value);
                contador++;
            }

            Console.WriteLine("Tamaño del diccionario: " + contador);

            Console.WriteLine("Presione enter para salir . . ");

            Console.Read();
        }
    }
}
