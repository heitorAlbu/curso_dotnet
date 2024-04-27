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



        public abstract void Ligar();
        public abstract void Desligar();



    }
}