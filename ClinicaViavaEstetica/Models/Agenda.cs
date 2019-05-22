using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.Models
{
    public class Agenda
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public string Descricao { get; set; }
        public bool Estado { get; set; } = true;
        [DisplayName("Data de Marcação")]
        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public DateTime DataMarcacao { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Servico Servico { get; set; }

        public void isValid()
        {

        }
    }
}