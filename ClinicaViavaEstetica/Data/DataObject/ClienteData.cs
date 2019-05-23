using ClinicaViavaEstetica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaViavaEstetica.Data.DataObject
{
    public class ClienteData
    {
        private static List<Cliente> Lista = new List<Cliente>();

        public static bool Add(Cliente cliente)
        {
            Lista.Add(cliente);
            return true;
        }

        public static void Delete(Cliente cliente)
        {
            Lista.RemoveAll(c => c.Id == cliente.Id);
        }

        public static Cliente Get(string id)
        {
            return Lista.FirstOrDefault(x => x.Id.ToString() == id);
        }

        public static Cliente GetByUserNamePassword(Utilizador utilizador)
        {
            LoadDefault();
            Cliente cliente = Lista.FirstOrDefault(x => x.Utilizador.UserName == utilizador.UserName && x.Utilizador.Password == utilizador.Password);
            return cliente;
        }

        public static bool Update(Cliente cliente)
        {
            var currentCliente = Get(cliente.Id.ToString());
            if (Get(currentCliente.Id.ToString()) != null)
            {
                currentCliente.Nome = cliente.Nome;
                currentCliente.SobreNome = cliente.SobreNome;
                currentCliente.Documento = cliente.Documento;
                currentCliente.Celular = cliente.Celular;
            }

            return true;
        }

        public static IList<Cliente> GetAll()
        {
            return Lista;
        }

        public static IList<Cliente> LoadDefault()
        {
            Cliente cliente1 = new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = "Valdanio",
                SobreNome = "Jessico",
                Celular = "2934435536",
                Documento =  "0002346657la065",
                Utilizador = new Utilizador()
                {
                    Id = Guid.NewGuid(),
                    UserName  = "admin",
                    Password = "admin",

                }
            };

            var cliente2 = new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = "Carlos",
                SobreNome = "Quingles",
                Celular = "2934435577",
                Documento = "0001116657la065",
                Utilizador = new Utilizador()
                {
                    Id = Guid.NewGuid(),
                    UserName  = "carlos.quingles",
                    Password = "12345678",

                }
            };

            var cliente3 = new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = "Anacleto",
                SobreNome = "Mimoso",
                Celular = "2934432226",
                Documento = "0002776657la065",
                Utilizador = new Utilizador()
                {
                    Id = Guid.NewGuid(),
                    UserName  = "anacleto.mimoso",
                    Password = "12345678",
                    
                }
            };

            var cliente4 = new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = "Bongo",
                SobreNome = "Caihso",
                Celular = "2934435536",
                Documento = "000234888la065",
                Utilizador = new Utilizador()
                {
                    Id = Guid.NewGuid(),
                    UserName  = "bongo.caihso",
                    Password = "12345678",

                }
            };


            Lista.Add(cliente1);
            Lista.Add(cliente2);
            Lista.Add(cliente3);
            Lista.Add(cliente4);

            return Lista;
        }
    }
}