using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{


    public class GerenciadorDeTickets
    {
        public Queue<Ticket> filaAlta { get; set; } = new Queue<Ticket>();
        public Queue<Ticket> filaMedia { get; set; } = new Queue<Ticket>();
        public Queue<Ticket> filaBaixa { get; set; } = new Queue<Ticket>();
        public void AdicionarTicket(Ticket ticket)
        {
            if (ticket.Prioridade == "Baixa")
            {
                this.filaBaixa.Enqueue(ticket);
            }
            else if (ticket.Prioridade == "Media")
            {
                this.filaMedia.Enqueue(ticket);
            }
            else if (ticket.Prioridade == "Alta")
            {
                this.filaAlta.Enqueue(ticket);
            }



        }

        public void ImprimirTickets()
        {
            Console.WriteLine("Tickets Alta: " + this.filaAlta.Count());
            Console.WriteLine("Tickets Media: " + this.filaMedia.Count());
            Console.WriteLine("Tickets Baixa: " + this.filaBaixa.Count());
        }

        public void ResolverTicket()
        {
            if (filaAlta.Count() > 0)
            {
                var incidente = filaAlta.Dequeue();
                Console.WriteLine("Resolvendo Ticket de Alta Prioridade : " + incidente.Descricao);
            }
            else if (filaMedia.Count() > 0)
            {
                var incidente = filaMedia.Dequeue();
                Console.WriteLine("Resolvendo Ticket de Média Prioridade : " + incidente.Descricao);
            }
            else if (filaAlta.Count() == 0 && filaMedia.Count() == 0)
            {
                var incidente = filaBaixa.Dequeue();
                Console.WriteLine("Resolvendo Ticket de Baixa Prioridade : " + incidente.Descricao);
            }

        }
    }



}