using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Marcacao
    {   
        private string data;
        private string hora;
        public string Paciente { get; set; }
        public string Medico { get; set; }



        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public string Hora
        {
            get
            {
                return hora;
            }

            set
            {
                if (ValidaHora(value))
                {
                    hora = value;
                }
                else
                {
                    throw new Exception("Hora inválida");
                }

            }
        }

        public Marcacao(string paciente, string dataConsulta, string horaConsulta, string medico)
        {
            Paciente = paciente;
            Data = dataConsulta;
            Hora = horaConsulta;
            Medico = medico;
        }

        public bool ValidaData(string data)
        {
            bool result = false;





            return result;
        }

        public bool ValidaHora(string hora)
        {
            bool result = false;

            int horas = Convert.ToInt32(hora.Substring(0, 2));
            int minutos = Convert.ToInt32(hora.Substring(3));

            if ((horas > 0 && horas < 24) && (minutos >= 0 && minutos < 60))
            {
                result = true;
            }

            return result;
        }

    }
}
