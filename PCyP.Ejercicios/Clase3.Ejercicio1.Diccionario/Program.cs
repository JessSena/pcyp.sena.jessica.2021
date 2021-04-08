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
            
            Dictionary<string, string> documentos = new Dictionary<string, string>();
            
            documentos.Add("Juan", "55423412");
            documentos.Add("Ernesto", "56985623");
            documentos.Add("Mariana", "54787451");

                //punto a 

                if (documentos.ContainsKey("Juan"))
                {
                Console.WriteLine("Para:\"Juan\", el valor es: {0}.", documentos["Juan"]);    
                }


                 //punto b

                 string valor = "";

                 if (documentos.TryGetValue("Pedro", out valor))
                 {
                     Console.WriteLine("Para = \"Pedro\", el valor es : {0}.", valor);
                 }

                 else
                 {
                     Console.WriteLine("No contiene la llave.");
                 }


                 //punto c

                 foreach (var persona in documentos)
                    {
                     Console.WriteLine(persona.Key + "," + persona.Value);
                    }
 
                //punto d 

            documentos["Mariana"] = "58251425";
            Console.WriteLine("Nuevo teléfono de Mariana: {0}", documentos["Mariana"]);
            Console.Read();

        }
    }
}
