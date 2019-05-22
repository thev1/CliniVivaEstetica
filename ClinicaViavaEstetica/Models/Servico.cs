using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.Models
{
    public class Servico
    {
        public Guid Id { get; set; }
        public string Desidnacao { get; set; }
        public virtual Agenda Agenda { get; set; }

        public bool isValid()
        {
            return false;
        }
    }
}