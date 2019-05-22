using AutoMapper;
using ClinicaViavaEstetica.Models;
using ClinicaViavaEstetica.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.App_Start
{
    public class MaperConf
    {
        internal static void RegisterComponents()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<AgendaViewModel, Agenda>();
                config.CreateMap<Agenda, AgendaViewModel>();
            });

        }
    }
}