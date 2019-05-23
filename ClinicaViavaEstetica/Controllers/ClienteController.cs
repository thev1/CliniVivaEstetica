using ClinicaViavaEstetica.Data.Interfaces;
using ClinicaViavaEstetica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaViavaEstetica.Controllers
{
    public class ClienteController : Controller
    {

        private IClienteRepository _ClienteRepository;

        public ClienteController(IClienteRepository e)
        {
            _ClienteRepository = e;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            List<SelectListItem> Options;
            Options = this._ClienteRepository.List().Select(a =>
                                  new SelectListItem
                                  {
                                      Value = a.Id.ToString(),
                                      Text = a.Nome
                                  }).ToList();

            return View(this._ClienteRepository.List());
        }

        // GET: Cliente/Details/5
        public ActionResult Details()
        {
            return View(this._ClienteRepository.get(Session["id"].ToString()));
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                // TODO: Add insert logic here
                _ClienteRepository.Insert(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit
        public ActionResult Edit()
        {
            return View(this._ClienteRepository.get(Session["id"].ToString()));
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            try
            {
                // TODO: Add update logic here
                this._ClienteRepository.Update(cliente);
                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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
