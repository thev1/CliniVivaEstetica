using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaViavaEstetica.Models.ViewModel
{
    public class ClienteViewModel
    {
        List<SelectListItem> Options { get; set; }

        public List<SelectListItem> setOptions(List<Cliente> lista)
        {
            this.Options = lista.Select(a =>
                                  new SelectListItem
                                  {
                                      Value = a.Id.ToString(),
                                      Text = a.Nome
                                  }).ToList();
            return Options;
        }
    }
}