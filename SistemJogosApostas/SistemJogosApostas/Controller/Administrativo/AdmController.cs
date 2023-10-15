using LojaDeSorteios.Model.Usuario;
using LojaDeSorteios.View;
using SistemJogosApostas.Model.Adm;
using SistemJogosApostas.View.Adm;
using System.Security.Cryptography.X509Certificates;

namespace LojaDeSorteios.Controller.Administrativo
{
    internal class AdmController
    {
        ClienteControllerUsuario cliente = new();
        TelaCadastroLogin tela = new();
        TelaLoginAdm telaLoginAdm = new();
        TelaAdministrativa telaAdm = new();
        private static List<AdmModel> _AdmList = new(); 

        //Acesso administrativo para manipulações mais complexas e privadas dos usuarios!
        public void ListaCliente()
        {
            List<ClienteModel> _listCli = new();

            foreach(ClienteModel cliente in _listCli)
            {
                Console.WriteLine("Nome: " + cliente.Nome + "Idade: " + cliente.Idade);
                    
                    }
            

        }

        public void addAdm(AdmModel adm)
        {
            _AdmList.Add(adm);
        }

        public void Autenticação(AdmModel adm)
        {
            AdmModel admModel = new();
            admModel.User = "pr02602";
            admModel.Senha = "ra26me02";
            _AdmList.Add(admModel);

            AdmModel admin = new();

            if(_AdmList.Count == 0)
            {
                _AdmList.Add(admin);
                Console.WriteLine("Adm Não existente!!!");
                _AdmList.Remove(admin);

                
                telaLoginAdm.Mostrar();
            }
            else
            {
                

                foreach (AdmModel adms in _AdmList)
                {
                    if (adms.User.Equals(adm.User) && adms.Senha.Equals(adm.Senha))
                    {
                        Console.WriteLine("\nLogado com sucesso senhor "+ adm.Nome);
                        
                        
                        telaAdm.TelaMostrarAdm();

                    }
                    else
                    {
                        Console.WriteLine("Adm Não existente!!!");

                        
                        telaLoginAdm.Mostrar();
                    }

                }
            }

        }

        public void AddCliente()
        {
            ClienteModel clientes = new();
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();


            Console.WriteLine("Informe sua Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            clientes.Nome = nome;
            clientes.Idade = idade;

            cliente.AddCliente(false,clientes);

            Console.WriteLine("Cliente " + clientes.Nome + " cadastrado com sucesso!");

            tela.Mostrar(0, false);

        }
        public void Remover()
        {
           // cliente.Remover();
        }

    }
}

