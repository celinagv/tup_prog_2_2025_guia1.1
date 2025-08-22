using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Moto
    {
        public string Marca { get; }
        public int Modelo { get; }  
        public double ValorFabricacion { get; }

        public Moto(string marca, int modelo, double ValorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            this.ValorFabricacion = ValorFabricacion;
        }

        public double CalcularDepreciacionlineal (int añoACalcular, int vidaUtil)
        {
            double depreciacionLineal = -1;
            if (vidaUtil == 0)
            {
                return depreciacionLineal;
            }

            int añosTranscurridos = añoACalcular - Modelo;

            // Evitar que supere la vida útil
            if (añosTranscurridos > vidaUtil)
                añosTranscurridos = vidaUtil;

            else
            {
                depreciacionLineal = ValorFabricacion - (ValorFabricacion * (añoACalcular - Modelo) / vidaUtil);
            }
           
            return depreciacionLineal;
        }

        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            double depreciacionAnual = ValorFabricacion * Math.Pow(1- tasaDepreciacion, añoACalcular - Modelo);

            return depreciacionAnual;
        }

        public string VerDescripcion()
        {
            return $@" Marca: {Marca},
Modelo: {Modelo}, 
Valor de Fabricación:{ValorFabricacion}";
        }
    }
}
