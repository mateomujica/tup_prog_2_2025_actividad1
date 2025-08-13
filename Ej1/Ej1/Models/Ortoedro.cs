using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    internal class Ortoedro
    {
        public Rectangulo[] Laterales = new Rectangulo[4];
        public Rectangulo[] Bases = new Rectangulo[2];



        public Ortoedro(double anchoBase, double ladoComun, double largoLateral)
        {
            Bases[0] = new Rectangulo(anchoBase, ladoComun);
            Bases[1] = new Rectangulo(anchoBase, ladoComun);
            Laterales[0] = new Rectangulo(ladoComun, largoLateral);
            Laterales[1] = new Rectangulo(ladoComun, largoLateral);
            Laterales[2] = new Rectangulo(ladoComun, largoLateral);
            Laterales[3] = new Rectangulo(ladoComun, largoLateral);
        }

        public double CalcularArea()
        {
            double areaBase = Bases[0].CalcularArea();
            double areaLateral = Laterales[1].CalcularArea();
            return areaBase * 2 + areaLateral * 4;

        }

        public double CalcularVolumen()
        {
            double volumen = Bases[0].CalcularArea() * Laterales[0].Largo;
            return volumen;
        }

        //public string Describir()
        //{
        //    double area = CalcularArea();
        //    double volumen = CalcularVolumen();

        //    return $"Area; {area}, Volumen {volumen}";
        //}
        public string Describir()
        {
            string json = $@"{{
                ""Figura"": ""Ortoedro"",
                ""Ancho base"": {Bases[0].Ancho},
                ""Largo base"": {Bases[0].Largo},
                ""Largo lateral"": {Laterales[0].Largo},
                ""Área"": {this.CalcularArea()},
                ""Volumen"": {this.CalcularVolumen()}
            }}";
            return json;

        }

    }
    
}