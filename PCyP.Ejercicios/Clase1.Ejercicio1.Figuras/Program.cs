using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    /// <summary>
    /// Realizar un programa capaz de calcular el área y perímetro de un cuadrado, rectángulo y triángulo. 
    /// Todos los datos necesarios para su funcionamiento se ingresan por teclado.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int sel, lado, bas, alt, l1, l2, l3;

            do
            {
                Console.Clear();
                List<int> datos = new List<int>(); ;

                Console.WriteLine("--------Bienvenido al programa de cálculo de Perímetro y Área de Figuras--------");
                Console.WriteLine("Seleccione una figura: ");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Salir");
                sel = Convert.ToInt32(Console.ReadLine());
                
                switch (sel)
                {
                    case 1:
                        Console.WriteLine("Ingrese el lado del Cuadrado: ");
                        lado = Convert.ToInt32(Console.ReadLine());
                        datos.Add(lado);

                        Cuadrado c = new Cuadrado(datos);

                        Console.WriteLine("El Perímetro del Cuadrado es " + c.calcularPerimetro());
                        Console.WriteLine("El Área del Cuadrado es " + c.calcularArea());
                        //Console.Read();

                        break;
                    case 2:
                        Console.WriteLine("Ingrese la base del Rectángulo: ");
                        bas = Convert.ToInt32(Console.ReadLine());
                        datos.Add(bas);
                        Console.WriteLine("Ingrese la altura del Rectángulo: ");
                        alt = Convert.ToInt32(Console.ReadLine());
                        datos.Add(alt);

                        Rectangulo r = new Rectangulo(datos);

                        Console.WriteLine("El Perímetro del Rectángulo es " + r.calcularPerimetro());
                        Console.WriteLine("El Área del Rectángulo es " + r.calcularArea());
                       // Console.Read();

                        break;
                    case 3:
                        Console.WriteLine("Ingrese el lado 1 del Triángulo: ");
                        l1 = Convert.ToInt32(Console.ReadLine());
                        datos.Add(l1);

                        Console.WriteLine("Ingrese el lado 2 del Triángulo: ");
                        l2 = Convert.ToInt32(Console.ReadLine());
                        datos.Add(l2);

                        Console.WriteLine("Ingrese el lado 3 del Triángulo: ");
                        l3 = Convert.ToInt32(Console.ReadLine());
                        datos.Add(l3);

                        Triangulo t = new Triangulo(datos);

                        Console.WriteLine("El Perímetro del Triángulo es " + t.calcularPerimetro());
                        Console.WriteLine("El Área del Triángulo es " + t.calcularArea());
                       // Console.Read();

                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("La opción ingresada no es correcta.");
                        break;
                }

                Console.ReadKey();
            } while (sel != 4);
        }
    }
}
