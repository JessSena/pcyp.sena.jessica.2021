using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2.Vial.csv
{

    /// <summary>
    /// Recorrer el archivo vial.csv, tomar cada linea, separar los campos y mostrarlos por pantalla. 
    /// Instanciar un objeto por cada linea  que pueda registrar los campos necesarios y que exponga 
    /// un método imprimir() donde muestre esos valores.
    ///Los campos del archivo CSV son: número-de-hoja,tipo-objeto,identificador-tramo,tipo-camino,longitud
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            string[] documento = File.ReadAllLines("C:/Users/Jessi/Documents/vial.csv");

            Linea actual= new Linea();
            int contador = 0;

            foreach(var linea in documento)
            {
                var campos = linea.Split(',');
                actual = new Linea(int.Parse(campos[0]), campos[1], long.Parse(campos[2]), campos[3], int.Parse(campos[4]));
                actual.imprimir();
                contador++;
            }

            Console.WriteLine("Se han leído: " + contador + " líneas.");
            Console.ReadLine();

        }
    }
}
