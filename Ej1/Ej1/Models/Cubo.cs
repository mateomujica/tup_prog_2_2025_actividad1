using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Ej1.Models
{
    internal class Cubo
    {
        public Cuadrado[] caras = new Cuadrado[6];

        public Cubo(double lado)
        {
            for (int i = 0; i < 6; i++)
            {
                caras[i] = new Cuadrado(lado);
            }
        }

        public double CalcularArea()
        {
            return caras[0].calcularArea() * 6;
        }

        public double CalcularVolumen()
        {
            return caras[0].calcularArea() * caras[0].Largo;
        }

        public string Describir()
        {
            string json = $@"{{
                ""Figura"": ""Cubo"",
                ""Lado"": {caras[0].Largo},
                ""Área"": {this.CalcularArea()},
                ""Volumen"": {this.CalcularVolumen()}
            }}";
            return json;
        }
    }
}
