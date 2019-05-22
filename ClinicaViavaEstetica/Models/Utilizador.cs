using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.Models
{
    public class Utilizador
    {
        public Guid Id { get; set; }
        [DisplayName("Nome de Utilizador")]
        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public string UserName { get; set; }
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public string Password { get; set; }
        public virtual Agenda Cliente { get; set; }

    }
}