using ClinicaViavaEstetica.Data.DataObject;
using ClinicaViavaEstetica.Data.Interfaces;
using ClinicaViavaEstetica.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.Data.Repository
{
    public class AgendaRepository : IAgendaRepository
    {
        private Mock<IRepository<Agenda>> _Mock;

        public AgendaRepository()
        {
            _Mock = new Mock<IRepository<Agenda>>();
        }

        public void Delete(Agenda objecto)
        {
            throw new NotImplementedException();
        }

        public bool Cancelar(Agenda objecto)
        {
            return AgendaData.Cancelar(objecto);
        }

        public Agenda get(string Id)
        {
            _Mock.Setup(x => x.get(Id))
                .Returns(AgendaData.Get(Id));

            return _Mock.Object.get(Id);
        }

        public bool Insert(Agenda objecto)
        {
            _Mock.Setup(x => x.Insert(objecto))
          .Returns(AgendaData.Add(objecto));

            _Mock.Object.Insert(objecto);

            return true;
        }

        public IList<Agenda> List()
        {
            _Mock.Setup(x => x.List())
                .Returns(AgendaData.GetAll());

            return _Mock.Object.List();
        }

        public bool Update(Agenda objecto)
        {
             _Mock.Setup(x => x.Update(objecto))
                  .Returns(AgendaData.Update(objecto));

             return _Mock.Object.Update(objecto);
        }
    }
}