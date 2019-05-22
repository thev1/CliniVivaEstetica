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
    public class ServicoRepository: IServicoRepository
    {
        private Mock<IServicoRepository> _Mock;

        public ServicoRepository()
        {
            _Mock = new Mock<IServicoRepository>();
        }

        public void Delete(Servico objecto)
        {
            throw new NotImplementedException();
        }

        public Servico get(string Id)
        {
            _Mock.Setup(x => x.get(Id))
                .Returns(ServiceData.Get(Id));

            return _Mock.Object.get(Id);
        }

        public bool Insert(Servico objecto)
        {
            throw new NotImplementedException();
        }

        public IList<Servico> List()
        {
            _Mock.Setup(x => x.List())
                  .Returns(ServiceData.GetAll());

            return _Mock.Object.List();
        }

        public void Update(Servico objecto)
        {
            throw new NotImplementedException();
        }
    }
}