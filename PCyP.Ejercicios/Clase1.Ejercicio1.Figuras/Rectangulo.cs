using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    public class Rectangulo : Figura
    {
        /// <summary>
        /// La clase Rectangulo hereda de la clase Figura, sobreescribe sus métodos 
        /// y aplica los cálculos necesarios para obtener su Perímetro y Área.
        /// </summary>


        //constructor
        public Rectangulo(List<int> lados)
        {
            this.lados = lados;
        }

        //sobreescritura de métodos para calcular área y perímetro
        public override double calcularPerimetro()
        {
            double resultado = lados[0]*2 + lados[1]*2 ;
            return resultado;
        }

        public override double calcularArea()
        {
            double resultado = lados[0] * lados[1] ;
            return resultado;
        }
    }
}
