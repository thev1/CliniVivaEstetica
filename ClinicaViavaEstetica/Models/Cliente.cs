using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        [DisplayName("Nome de Cliente")]
        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public string Nome { get; set; }
        [DisplayName("Sobre Nome")]
        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public string SobreNome { get; set; }
        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Este é um campo obrigatório")]
        public string Documento { get; set; }
        public virtual IList<Agenda> Agendas { get; set; }
        public virtual Utilizador Utilizador { get; set; }
    }
}