using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    public class Triangulo : Figura
    {
        /// <summary>
        /// La clase Triangulo hereda de la clase Figura, sobreescribe sus métodos 
        /// y aplica los cálculos necesarios para obtener su Perímetro y Área.
        /// </summary>


        //constructor
        public Triangulo(List<int> lados)
        {
            this.lados = lados;
        }

        //sobreescritura de métodos para calcular área y perímetro
        public override double calcularPerimetro()
        {
            double resultado = lados[0] + lados[1] + lados[2];
            return resultado;
        }

        public override double calcularArea()
        {
            double resultado = 0.5*(lados[0] + lados[1] + lados[2]);
            return resultado;
        }
    }
}
