using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaViavaEstetica.Data.Interfaces
{
    public interface IRepository<T>
    {
        IList<T> List();

        bool Insert(T objecto);

        void Delete(T objecto);

        void Update(T objecto);

        T get(string Id);
    }
}
