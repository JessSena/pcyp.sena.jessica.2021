using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5.EjercicioMatrices
{/// <summary>
/// Desarrolle un software que dado dos matrices las multiplique. 
/// Recordar realizar la verificación previa para saber si las matrices son multiplicables.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("-----Bienvenido al programa de Multiplicación de matrices-----");

                //pidiendo datos para la primer matriz 
                Console.WriteLine("\n Primer Matriz");

                Console.Write("Ingrese la cantidad de Filas: ");
                int f1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de Columnas: ");
                int c1 = int.Parse(Console.ReadLine());

                //pidiendo datos para la segunda matriz 
                Console.WriteLine("\n Segunda matriz");

                Console.Write("Ingrese la cantidad de Filas: ");
                int f2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de Columnas: ");
                int c2 = int.Parse(Console.ReadLine());

                //Declarando las matrices 

                int[,] primerMatriz = new int[f1 + 1, c1 + 1];
                int[,] segundaMatriz = new int[f2 + 1, c2 + 1];
                int[,] resultado = new int[f1 + 1, c2 + 1];


                //Las columnas de la matriz 1 deben ser igual al número de filas de la matriz 2
                if (c1 == f2)
                {
                    Console.WriteLine(" \n Las matrices son multiplicables");
                    
                    //Rellenando primer matriz
                    Console.WriteLine(" \n Datos Primer Matriz: ");
                    for (int i = 1; i <= f1; i++)
                    {
                        for (int j = 1; j <= c1; j++)
                        {
                            Console.Write("Ingrese Fila: {0} - Columna: {1}: ", i, j);
                            primerMatriz[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    //Rellenando segunda matriz
                    Console.WriteLine("\n Datos Segunda Matriz: ");
                    for (int i = 1; i <= f2; i++)
                    {
                        for (int j = 1; j <= c2; j++)
                        {
                            Console.Write("Ingrese Fila: {0} - Columna: {1}: ", i, j);
                            segundaMatriz[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    //Multiplicando las matrices
                    for (int i = 1; i <= f1; i++)
                    {
                        for (int j = 1; j <= c2; j++)
                        {
                            resultado[i, j] = 0;
                            for (int z = 1; z <= c1; z++)
                            {
                                resultado[i, j] = primerMatriz[i, z] * segundaMatriz[z, j] + resultado[i, j];
                            }
                        }
                    }


                    Console.WriteLine("\n Matriz resultante de la multiplicación de las 2 Matrices: \n");

                    // mostramos el resultado
                    for (int i = 1; i <= f1; i++)
                    {
                        for (int j = 1; j <= c2; j++)
                        {
                            Console.Write("{0} ", resultado[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("\n No se puede multiplicar las matrices " +
                        "\n Columnas primer Matriz : {0} , Filas segunda Matriz : {1} \n Las mismas deben ser iguales ", c1, f2);
                }
                Console.Read();
         }
            
    }
}
