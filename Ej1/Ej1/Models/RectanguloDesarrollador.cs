using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej1.Models
{
    internal class RectanguloDesarrollado
    {
        double largo;
        double ancho; 
        public double Largo { get; set; }
        public double Ancho { get; set; }   
        public RectanguloDesarrollado (double radio,double altura)
        {
            Ancho = 2 * Math.PI * radio;
            Largo = altura;
        }

        public double CalcularArea()
        {
            double area = Ancho * Largo;
            return area;
        }

        public string Describir()
        {
           
            return $"Rectangulo Desarrollado: Largo: {Largo:f2}, Ancho: {Ancho:f2}";

        }
    }
}
