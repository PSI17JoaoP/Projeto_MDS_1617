using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    class Consulta
    {
        public int IdTipoSintoma { get; set; }
        public int IdMarcacao { get; set; }
        public string DescricaoSintomas { get; set; }
        public string MedicamentosTratamentos { get; set; }

        public Consulta(int idtiposintoma, int idmarcacao, string descricaosintomas, string medicamentostratamentos)
        {
            IdTipoSintoma = idtiposintoma;
            IdMarcacao = idmarcacao;
            DescricaoSintomas = descricaosintomas;
            MedicamentosTratamentos = medicamentostratamentos;
        }

        public override string ToString()
        {
            return IdTipoSintoma + " - " + IdMarcacao + " - " + DescricaoSintomas + " - " + MedicamentosTratamentos;
        }
    }
}
