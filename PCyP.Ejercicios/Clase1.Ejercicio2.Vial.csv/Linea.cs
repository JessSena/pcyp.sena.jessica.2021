using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio2.Vial.csv
{
    class Linea
    {
        //atributos
        private int numHoja { get; set; }
        private string tipoObj { get; set; }
        private long idTramo { get; set; }
        private string tipoCamino { get; set; }
        private int longitud { get; set; }

        //constructores
        public Linea()
        {
            numHoja = 0;
            tipoObj = null;
            idTramo = 0;
            tipoCamino = null;
            longitud = 0;
        }

        public Linea(int nHoja, string tObj, long idT, string tCamino, int longd)
        {
            numHoja = nHoja;
            tipoObj = tObj;
            idTramo = idT;
            tipoCamino = tCamino;
            longitud = longd;
        }

        //método para imprimir los campos de la línea.
        public void imprimir()
        {
            Console.WriteLine("Número de hoja: {0}\tTipo de objeto: {1},\tIdentificador de Tramo: {2},\tTipo de Camino: {3},\tLongitud: {4}", 
                numHoja, tipoObj, idTramo, tipoCamino, longitud);
           
        }
    }
}
