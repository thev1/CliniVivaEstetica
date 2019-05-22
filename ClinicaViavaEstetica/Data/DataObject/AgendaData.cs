using ClinicaViavaEstetica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.Data.DataObject
{
    public class AgendaData
    {
        private static List<Agenda> Lista = new List<Agenda>();

        public static bool Add(Agenda Agenda)
        {
            Agenda.Id = Guid.NewGuid();
            Lista.Add(Agenda);
            return true;
        }

        public static void Delete(Agenda Agenda)
        {
            Lista.RemoveAll(c => c.Id == Agenda.Id);
        }

        public static Agenda Get(string id)
        {
            return Lista.FirstOrDefault(x => x.Id.ToString() == id);
        }

        public static void Update(Agenda Agenda)
        {
            var currentAgenda = Get(Agenda.Id.ToString());
            if (Get(currentAgenda.Id.ToString()) != null)
            {
                currentAgenda.Id = Agenda.Id;
                currentAgenda.Descricao = Agenda.Descricao;
                currentAgenda.Estado = Agenda.Estado;
            }
        }

        public static IList<Agenda> GetAll()
        {
            return Lista;
        }

    }
}