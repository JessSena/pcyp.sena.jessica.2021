using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    public abstract class Figura
    {
        /// <summary>
        /// La clase Figura actúa como padre de las clases Cuadrado, Rectángulo y Triángulo.
        /// Todas ellas heredaran su atributo lados y sobreescribirán sus métodos para
        /// calcular Perímetro y Área.
        /// </summary>
        

        protected List<int>lados { get; set; }

        public abstract double calcularPerimetro();
        public abstract double calcularArea();
    }
}
