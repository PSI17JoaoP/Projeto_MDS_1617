﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MDS
{
    public class Consultas
    {
        private string paciente;
        private string data;
        private string hora;
        private string medico;



        public string Paciente
        {
            get
            {
                return paciente;
            }

            set
            {
                paciente = value;
            }
        }

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

        public string Medico
        {
            get
            {
                return medico;
            }

            set
            {
                medico = value;
            }
        }


        public Consultas(string nomePaciente, string dataConsulta, string horaConsulta, string nomeMedico)
        {
            Paciente = nomePaciente;
            Data = dataConsulta;
            Hora = horaConsulta;
            Medico = nomeMedico;
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
