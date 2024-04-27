using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{


    public class Smartphone : DispositivoEletronico
    {
        public string SistemaOperacional { get; set; }

        public int CapacidadeBateria { get; set; }

        public Smartphone(string sistemaOperacional, string marca, string modelo, string ano) : base(marca, modelo, ano)
        {
            this.SistemaOperacional = sistemaOperacional;
        }
        public override int VerificarBateria()
        {
            return (base.VerificarBateria() / 100) * 100;
        }
        public override string ObterDescricao()
        {
            return base.ObterDescricao();
        }
        public override void Desligar()
        {
            Console.WriteLine("desligou!");
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligou!");
        }
    }
}