using AutoMapper;
using ClinicaViavaEstetica.Data.Interfaces;
using ClinicaViavaEstetica.Models;
using ClinicaViavaEstetica.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaViavaEstetica.Controllers
{
    public class AgendaController : Controller
    {
        private IAgendaRepository _AgendaRepository;
        private IServicoRepository _ServicoRepository;
        private IClienteRepository _ClienteRepository;

        public AgendaController(IAgendaRepository AgendaRepository, IServicoRepository ServicoRepository, IClienteRepository ClienteRepository)
        {
            this._AgendaRepository = AgendaRepository;
            this._ServicoRepository = ServicoRepository;
            this._ClienteRepository = ClienteRepository;
        }

        // GET: Agenda
        public ActionResult Index()
        {
            return View(this._AgendaRepository.List());
        }

        // GET: Agenda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        private IEnumerable<SelectListItem> GetRoles()
        {
            var dbUserRoles = this._ServicoRepository.List();
            var roles = dbUserRoles
                        .Select(x =>
                                new SelectListItem
                                {
                                    Value = x.Id.ToString(),
                                    Text = x.Desidnacao
                                });

            return new SelectList(roles, "Value", "Text");
        }
        // GET: Agenda/Create
        public ActionResult Create()
        {
            var model = new AgendaViewModel {
                Options = GetRoles()
            };

            return View(model);
        }

        // POST: Agenda/Create
        [HttpPost]
        public ActionResult Create(AgendaViewModel agendaViewModel)
        {
            try
            {
                

                var Agenda = Mapper.Map<Agenda>(agendaViewModel);
                var date1 = agendaViewModel.DataMarcacao.Day;
                var Cliente = this._ClienteRepository.get(Session["id"].ToString());
                var Servico = this._ServicoRepository.get(agendaViewModel.selectedId.ToString());
                Agenda.Cliente = Cliente;
                Agenda.Servico = Servico;

                this._AgendaRepository.Insert(Agenda);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Agenda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Agenda/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Agenda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Agenda/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
