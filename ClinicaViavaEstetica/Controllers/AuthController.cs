using ClinicaViavaEstetica.Data.Interfaces;
using ClinicaViavaEstetica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaViavaEstetica.Controllers
{
    public class AuthController : Controller
    {
        private IClienteRepository _ClienteRepository;

        public AuthController(IClienteRepository ClienteRepository)
        {
            this._ClienteRepository = ClienteRepository;
        }

        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dashboard(Utilizador User)
        {
            Cliente cliente = this._ClienteRepository.autenticate(User);

            if (cliente == null)
            {
                return View("Index", User);
            }

            Session["id"] = cliente.Id.ToString();
            Session["nome"] = cliente.Nome;
            Session["sobrenome"] = cliente.SobreNome;
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Auth");
        }

    }
}
