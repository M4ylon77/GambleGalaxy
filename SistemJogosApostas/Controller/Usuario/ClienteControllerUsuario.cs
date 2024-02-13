using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using LojaDeSorteios.View;
using LojaDeSorteios.Model.Usuario;
using LojaDeSorteios.View.UI;

namespace LojaDeSorteios.Controller
{
    internal class ClienteControllerUsuario
    {
            ClienteModel cliente = new();
            TelaLoginCadastro tela = new();
             public static List<ClienteModel> listaCliente = new();
        TelaCadastroLogin telaCadastroLogin = new();
        public void AddCliente(Boolean convidado,ClienteModel cliente)
            {
            if (convidado == false)
            {                
                listaCliente.Add(cliente);

                Console.WriteLine("Cliente " + cliente.Nome + " cadastrado com sucesso!");

                tela.Mostrar(1, false);
        
            }else if(convidado ==  true)
            {
                ClienteModel convidados = new ClienteModel("Convidado",0,"0");
                listaCliente.Add(convidados);

                Console.WriteLine("\n[Acessando como " + convidados.Nome + "]");

                tela.Mostrar(1, true);

            }

        }
        public void Autenticacao(string nome, string senha)
        {
            if (listaCliente.Count == 0)
            {
                listaCliente.Add(cliente);
                Console.WriteLine("\n\n==Usuario Não existe==");
                listaCliente.Remove(cliente);

 

                telaCadastroLogin.Mostrar(3, false);

            }
            else
            {
                foreach (ClienteModel clientes in listaCliente)
                {
                    if (nome.Equals(clientes.Nome) && senha.Equals(clientes.Senha))
                    {

                        TelaDoJogo teladojogo = new();

                        teladojogo.MostrarTelaDoJogo(2, nome, null,1);

                    }
                    else
                    {
                        Console.WriteLine("troxa");

                        telaCadastroLogin.Mostrar(2, false);
                    }

                }
            }

        }


    }
  
}

