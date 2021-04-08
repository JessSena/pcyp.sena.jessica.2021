using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Lista
{
    /// <summary>
    /// Dado dos vectores:
    /// 
    /// Realice las siguientes operaciones:
    /// a.Armar dos listas, una con los valores del vector “colors” y otra con los valores del
    /// vector “removeColors”.
    /// b.Mostrar la lista de colores por pantalla.
    /// c.De la lista de colores eliminar los colores listados en la otra lista(removeColors).
    /// d.Volver a mostrar la lista de colores por pantalla.
    /// </summary>
    class Program
    {
        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };

        static void Main(string[] args)
        {
            List<string> colores = new List<string>();
            List<string> coloresAremover = new List<string>();

            // punto a 
            foreach (var color in colors)
            {
                colores.Add(color);
            }

            foreach (var color in removeColors)
            {
                coloresAremover.Add(color);
            }

            //punto b 
            mostrarLista(colores);

            //punto c
            eliminarColores(colores, coloresAremover);

            //punto d
            Console.WriteLine("Lista después de llamar a remueve colores: ");
            mostrarLista(colores);

            Console.Read();
        }

         
        private static void mostrarLista(List<string> lista)
        {
            foreach (var item in lista)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("Tamaño:" +lista.Count);         
        }

        
        private static void eliminarColores(List<string> original, List<string> eliminar)
        {
            for (int contador = 0; contador < eliminar.Count; contador++)
            {
                original.Remove(eliminar[contador]);
            }
        }


    }
}
   





