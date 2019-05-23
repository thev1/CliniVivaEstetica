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
    public class ClienteRepository : IClienteRepository
    {
        private Mock<IClienteRepository> _Mock;

        public ClienteRepository()
        {
            _Mock = new Mock<IClienteRepository>();
        }

        public Cliente autenticate(Utilizador objecto)
        {
            _Mock.Setup(x => x.autenticate(objecto))
                .Returns(ClienteData.GetByUserNamePassword(objecto));

            return _Mock.Object.autenticate(objecto);
        }

        public void Delete(Cliente objecto)
        {
            throw new NotImplementedException();
        }

        public Cliente get(string Id)
        {
            _Mock.Setup(x => x.get(Id))
                .Returns(ClienteData.Get(Id));

            return _Mock.Object.get(Id);
        }

        public bool Insert(Cliente objecto)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> List()
        {
            _Mock.Setup(x => x.List())
                .Returns(ClienteData.GetAll());

            return _Mock.Object.List();
        }


        public bool Update(Cliente objecto)
        {
            _Mock.Setup(x => x.Update(objecto))
                  .Returns(ClienteData.Update(objecto));

            return _Mock.Object.Update(objecto);
        }
    }
}