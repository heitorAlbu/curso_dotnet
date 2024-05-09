using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{
    public class SessaoDeEdicao
    {
        public int Id { get; set; }
        public string NomeDoDocumento { get; set; }

        public Stack<Acao> acoesFeitas { get; set; }
        public Stack<Acao> acoesDesfeitas { get; set; }


        public void ExecutarAcao(Acao acao)
        {

        }


        public void Desfazer()
        {


        }

        public void Refazer()
        {


        }

    }
}