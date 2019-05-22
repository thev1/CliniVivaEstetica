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
        public ActionResult Details(string id)
        {
            return View(this._AgendaRepository.get(id));
        }

        private IEnumerable<SelectListItem> GetOptions()
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
                Options = GetOptions()
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
                var Cliente = this._ClienteRepository.get(Session["id"].ToString());
                var Servico = this._ServicoRepository.get(agendaViewModel.selectedId.ToString());
                Agenda.Cliente = Cliente;
                Agenda.Servico = Servico;
                Servico.Agenda = Agenda;

                this._AgendaRepository.Insert(Agenda);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Agenda/Edit/5
        public ActionResult Edit(string id)
        {
            return View(this._AgendaRepository.get(id));
        }

        // POST: Agenda/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Agenda agenda)
        {
           
                // TODO: Add update logic here
                this._AgendaRepository.Update(agenda);
                return RedirectToAction("Index");
            
        }

        // GET: Agenda/Delete/5
        public ActionResult Delete(string id)
        {
            return View(this._AgendaRepository.get(id));
            return View();
        }

        // POST: Agenda/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, Agenda angenda)
        {
            try
            {
                // TODO: Add delete logic here
                this._AgendaRepository.Cancelar(angenda);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
