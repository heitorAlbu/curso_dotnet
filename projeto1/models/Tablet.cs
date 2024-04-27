using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{


    public class Tablet : DispositivoEletronico
    {
        public string TamanhoTela { get; set; }
        public int CapacidadeBateria { get; set; }


        public Tablet(string tamanhoTela, string marca, string modelo, string ano) : base(marca, modelo, ano)
        {
            this.TamanhoTela = tamanhoTela;
        }


        public override int VerificarBateria()
        {
            return (base.VerificarBateria() / 100) * 100;
        }
        public override string ObterDescricao()
        {
            return this.TamanhoTela;
        }


        public override void Desligar()
        {
            Console.WriteLine("Desligou!!!");
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligou!!!");
        }
    }
}