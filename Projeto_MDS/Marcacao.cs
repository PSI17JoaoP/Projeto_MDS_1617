﻿using System;
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
        public Pacientes Paciente { get; set; }
        public Medicos Medico { get; set; }



        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                if (ValidaData(value))
                {
                    data = value;
                }
                else
                {
                    throw new Exception("Data inválida");
                }
                
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

        public Marcacao(Pacientes paciente, string dataConsulta, string horaConsulta, Medicos medico)
        {
            Paciente = paciente;
            Data = dataConsulta;
            Hora = horaConsulta;
            Medico = medico;
        }

        public bool ValidaData(string data)
        {
            bool result = false;


            DateTime date = DateTime.Parse(data);
            if (DateTime.Compare(date, DateTime.Today) >= 0)
            {
                result = true;
            }

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

        public bool VerificarDisponibilidadeMedica(string medico, string data, string hora)
        {
            bool result = false;

            if (Medico.Nome == medico && Data == data && Hora == hora)
            {
                result = true;
            }

            return result;
        }

    }
}
