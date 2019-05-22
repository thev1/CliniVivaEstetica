using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaViavaEstetica.Models.ViewModel
{
    public class AgendaViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Estado { get; set; }
        public DateTime DataMarcacao { get; set; }
        public Guid selectedId { get; set; }
        public IEnumerable<SelectListItem> Options { get; set; }

    }
}