using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{
    public class ConsoleGame
    {
        public string Nome { get; set; }
        public int? Quantidade { get; set; }


        public ConsoleGame(string Nome, int? Quantidade)
        {
            this.Nome = Nome;
            this.Quantidade = Quantidade;
        }
    }
}