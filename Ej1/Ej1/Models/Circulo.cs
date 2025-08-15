using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej1.Models
{
    internal class Circulo
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            double area = Math.PI * Math.Pow(Radio, 2);
            return area;
        }

        public string Describir()
        {
           
            return $"Circulo: Radio:{Radio:f2}";
        }
            
    }
}
