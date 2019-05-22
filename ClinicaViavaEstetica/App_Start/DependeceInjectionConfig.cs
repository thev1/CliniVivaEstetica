using ClinicaViavaEstetica.Data.Interfaces;
using ClinicaViavaEstetica.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ClinicaViavaEstetica.App_Start
{
    public class DependeceInjectionConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IClienteRepository, ClienteRepository>();
            container.RegisterType<IAgendaRepository, AgendaRepository>();
            container.RegisterType<IServicoRepository, ServicoRepository > ();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}