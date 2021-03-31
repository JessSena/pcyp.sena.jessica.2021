﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    public class Cuadrado : Figura
    {
        //constructor
        public Cuadrado(List <int> lados)
        {
            this.lados = lados;
        }

        //sobreescritura de métodos para calcular área y perímetro
        public override double calcularPerimetro()
        {
            double resultado = lados[0]*4;
            return resultado;
        }

        public override double calcularArea()
        {
            double resultado = lados[0] * lados[0];
            return resultado;
        }

        

    }
}
