using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.Diccionario
{
    /// <summary>
    /// Implementar un diccionario que contendrá los siguientes valores:
    /// values.Add("Juan", "55423412");
    /// values.Add("Ernesto", "56985623");
    /// values.Add("Mariana", "54787451");
    /// Realice las siguientes operaciones:
    /// a.Revisar en el diccionario si existe un índice llamado “Juan”. En caso de que exista,
    /// mostrar su valor(utilice el método ContainsKey)
    /// b.Revisar en el diccionario si existe un índice llamado “Pedro”. En caso de que exista,
    /// mostrar su valor, si no existe imprimir por pantalla “No contiene la llave” (utilice el
    /// método TryGetValue)
    /// c.Recorrer el diccionario y mostrar todos sus datos(índice y valor).
    /// d.Alterar el valor cuyo índice es “Mariana” por “58251425”. Imprimir el nuevo valor.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo.Dicccionario!");
            Console.Read();
        }
    }
}
