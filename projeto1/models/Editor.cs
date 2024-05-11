using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto1.models
{
    public class Editor
    {
        public List<SessaoDeEdicao>? sessoesAbertas { get; set; }
        public Dictionary<string, SessaoDeEdicao>? sessoesPorId { get; set; }

        public void AbrirSessao(SessaoDeEdicao sessao)
        {


        }

        public void FecharSessao(string id)
        {

        }

        public SessaoDeEdicao ObterSessaoPorId(string id)
        {

            return null;
        }

        public List<SessaoDeEdicao> ListarSesoesAbertas()
        {

            return null;
        }


    }
}