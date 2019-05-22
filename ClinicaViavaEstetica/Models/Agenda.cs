using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.Models
{
    public class Agenda
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Estado { get; set; }
        public DateTime DataMarcacao { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Servico Servico { get; set; }

        public void isValid()
        {

        }
    }
}