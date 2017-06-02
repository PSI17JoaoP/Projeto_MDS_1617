using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    class TipoSintoma
    {
        public string Nome { get; set; }
        public string Observacoes { get; set; }

        public TipoSintoma(string nome, string observacoes)
        {
            Nome = nome;
            Observacoes = observacoes;
        }

        public override string ToString()
        {
            //return Nome + " - " + Descricao;
            return Nome;


        }
    }
}
