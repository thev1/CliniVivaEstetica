using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Celular { get; set; }
        public string Documento { get; set; }
        public virtual IList<Agenda> Agendas { get; set; }
        public virtual Utilizador Utilizador { get; set; }
    }
}