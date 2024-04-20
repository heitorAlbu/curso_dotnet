using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{
    public class Contador
    {

        public int Valor { get; set; }

        public Contador()
        {

        }

        public void Incrementar()
        {
            this.Valor = this.Valor + 1;
        }
        public void Decrementar()
        {
            this.Valor = this.Valor - 1;
        }

    }
}