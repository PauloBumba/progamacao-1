using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Utils
{
    public class Bootstrapper
    {
        public static void ChargeClients()
        {
            var c1 = new Client
            {
                Id = 1,
                FirstName = "Wesllen",
                LastName = "Da Cruz",
                CPF = "000.000.000-00",
                Email = "wesllenf11@gmail.com"
            };
            DataSet.Clients.Add(c1);

            DataSet.Clients.Add(
                new Client
                {
                    Id = 2,
                    FirstName = "Jorge",
                    LastName = "Sampaoli",
                    CPF = "000.000.000-01",
                    Email = "sampaoli@gmail.com"
                }
            );

            DataSet.Clients.Add(
                new Client
                {
                    Id = 3,
                    FirstName = "Flávio",
                    LastName = "Caça Rato",
                    CPF = "000.000.000-02",
                    Email = "cacarato@gmail.com"
                }
            );
        }
    }
}