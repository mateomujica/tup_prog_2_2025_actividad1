using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    internal class Cuadrado
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public Cuadrado(double lado)
        {
            Ancho = lado;
            Largo = lado;

        }

        public double calcularArea()
        {
            return Largo * Ancho;
        }

        public string Describir()
        {
            string json = $@"{{
                   ""Tipo"": Cuadrado, 
                   ""Largo"": 3, 
                   ""Ancho"": 3,
                   ""Area"": 9
            }}";
            return json; 
        }
    }
}
