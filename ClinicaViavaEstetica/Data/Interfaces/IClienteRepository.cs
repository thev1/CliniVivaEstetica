using ClinicaViavaEstetica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaViavaEstetica.Data.Interfaces
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        Cliente autenticate(Utilizador objecto);

    }
}
