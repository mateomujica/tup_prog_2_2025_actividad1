using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{
    internal class Cilindro
    {
        Circulo[] Tapas = new Circulo[2];
        RectanguloDesarrollado Lado;
        public Cilindro(double radio, double altura)
        {
            Lado = new RectanguloDesarrollado(radio, altura);
            Tapas[0] = new Circulo(radio);
            Tapas[1] = new Circulo(radio);
        }

        public  double CalcularArea()
        {
            return (2 * Tapas[0].CalcularArea()) + (Lado.CalcularArea());
        }

        public double CalcularVolumen()
        {
            return Tapas[0].CalcularArea() * Lado.Largo;
        }

        public string Describir()
        {
            string json = $@"{{
                        ""Tipo"":""Cilindro"",
                        ""Tapas"":
                        
                        {{
                        ""Tipo"":""Circulo"",
                        ""Radio"":""{Tapas[0].Radio:f2}"",
                        ""Area"":""{Tapas[0].CalcularArea():f2}"",
                        }},

                        {{
                        ""Tipo"":""Circulo"",
                        ""Radio"":""{Tapas[1].Radio:f2}"",
                        ""Area"":""{Tapas[1].CalcularArea():f2}"",
                        }},
                        
                        ""Lado"":
                        
                        {{
                        ""Tipo"":""Rectangulo Desarrollado"",
                        ""Ancho"":""{Lado.Ancho:f2}"",
                        ""Altura"":""{Lado.Largo:f2}"",
                        ""Area"":""{Lado.CalcularArea():f2}"",
                        }},
                        
                        ""Area"":""{CalcularArea():f2}"",
                        ""Volumen"":""{CalcularVolumen():f2}"",
                        }}";
                          
            
        }
    }
}


        
       
    
 