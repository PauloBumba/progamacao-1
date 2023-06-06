using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class ClientView
    {
        private ClientController clientController;

        public ClientView()
        {
            clientController = new ClientController();
            this.Init();
        }

        public void Init()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Você está em Clientes");
            Console.WriteLine("************************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Cliente");
            Console.WriteLine("2 - Listar Cliente");
            Console.WriteLine("3 - Exportar Cliente");
            Console.WriteLine("4 - Importar Cliente");
            Console.WriteLine("");

            int option = 0;

            switch(option)
            {
                case 1:
                    Insert();
                break;

                default:
                break;
            }
        }

        private void Insert()
        {
            Client client = new Client();
            client.Id = clientController.GetNextId();

            Console.WriteLine("Informe o seu primeiro nome:");
            client.FirstName = Console.ReadLine();

            Console.WriteLine("Informe o seu sobrenome:");
            client.LastName = Console.ReadLine();

            Console.WriteLine("Informe o seu CPF:");
            client.CPF = Console.ReadLine();

            Console.WriteLine("Informe o seu email:");
            client.Email = Console.ReadLine();
        }

    }
}