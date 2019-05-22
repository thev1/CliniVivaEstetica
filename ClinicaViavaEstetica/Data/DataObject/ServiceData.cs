using ClinicaViavaEstetica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.Data.DataObject
{
    public class ServiceData
    {
         private static List<Servico> Lista = new List<Servico>();

        public static bool Add(Servico Servico)
        {
            Lista.Add(Servico);
            return true;
        }

        public static void Delete(Servico Servico)
        {
            Lista.RemoveAll(c => c.Id == Servico.Id);
        }

        public static Servico Get(string id)
        {
            return Lista.FirstOrDefault(x => x.Id.ToString() == id);
        }


        public static void Update(Servico Servico)
        {
           
        }

        public static IList<Servico> GetAll()
        {
            LoadDefaults();
            return Lista;
        }

        public static IList<Servico> LoadDefaults()
        {
            Servico Servico1 = new Servico
            {
                Id = Guid.NewGuid(),
                Desidnacao = "Massagem",
            };

            var Servico2 = new Servico
            {
                Id = Guid.NewGuid(),
                Desidnacao = "Serviço geral",
            };

            Lista.Add(Servico1);
            Lista.Add(Servico2);

            return Lista;
        }
    }
}