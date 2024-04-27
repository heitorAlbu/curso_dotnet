using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{
    public abstract class DispositivoEletronico
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private string AnoDeFabricacao { get; set; }

        public DispositivoEletronico(string marca, string modelo, string ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.AnoDeFabricacao = ano;
        }

        public abstract void Ligar();
        public abstract void Desligar();

        public virtual string ObterDescricao()
        {
            return this.Marca + this.Modelo;
        }


        public virtual int VerificarBateria()
        {

            return 1;
        }
    }
}