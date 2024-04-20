using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{
    public class Termometro
    {
        public double Temperatura { get; set; }
        public double TemperaturaMinima { get; set; }
        public double TemperaturaMaxima { get; set; }
        public bool ForaDaFaixa { get; set; } = false;

        public void AjustarTemperatura(double novaTemperatura)
        {
            if (novaTemperatura > TemperaturaMinima && novaTemperatura < TemperaturaMaxima)
            {
                ForaDaFaixa = false;
                this.Temperatura = novaTemperatura;
            }
            else
            {
                ForaDaFaixa = true;
            }
        }

        public void DefinirFaixaDeTemperatura(double minima, double maxima)
        {
            this.TemperaturaMinima = minima;
            this.TemperaturaMaxima = maxima;

        }

        public void MostrarTemperatura()
        {
            if (ForaDaFaixa)
            {
                Console.WriteLine("Temperatura fora da faixa");

            }
            else
            {
                Console.WriteLine("temperatura atual : " + this.Temperatura);
            }
        }
    }
}