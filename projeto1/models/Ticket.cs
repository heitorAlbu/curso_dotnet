using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Prioridade { get; set; }

        public Ticket(int Id, string Descricao, string Prioridade)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Prioridade = Prioridade;
        }

    }
}