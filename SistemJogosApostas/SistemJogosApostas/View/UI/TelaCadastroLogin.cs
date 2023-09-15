using LojaDeSorteios.Controller;
using LojaDeSorteios.Model.Usuario;
using LojaDeSorteios.Controller.Administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDeSorteios.Controller.Administrativo;
using System.Diagnostics;

namespace LojaDeSorteios.View
{
    internal class TelaCadastroLogin
    {
        
        public void Mostrar(int valor, Boolean convidado)
        {
            #region Cadastrado !!
            if (valor == 1)
            {
                   int min = 0;
            do
                {
                        Console.SetCursorPosition(0, Console.CursorTop); // Define a posição do cursor na coluna 0
                    // Formate a saída com espaços em branco para garantir que números anteriores sejam apagados
                         string output = $"Carregando...{min}%";
                         Console.Write(output.PadRight(Console.WindowWidth));

                         min++;
                      
                     Thread.Sleep(2);


                } while (min<=100);

                     TelaDeLogin telaDoJogo = new();

                if (convidado == true)
                {
                    telaDoJogo.MostrarTelaDoJogo(3, null);
                }
                else if(convidado == false)
                {
                    telaDoJogo.MostrarTelaDoJogo(1, null);
                }
                

            }
            #endregion

            #region Não Cadastrado!
            else if (valor == 2)
            {
                if (convidado == false)
                {
                    Console.WriteLine("Informe seu nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe senha: ");
                    string senha = Console.ReadLine();

                    Console.WriteLine("Informe sua Idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    ClienteModel cliente = new ClienteModel(nome,idade,senha);

                    Adicionar(cliente);

                }else if (convidado == true) 
                {

                    ClienteModel convidados = new(null, 0, null);

                    AdicionarConvidado(convidados);
                }
            }
        

            else
            {


                Console.WriteLine("\nDeseja continuar ou voltar e se Cadastrar!" +
                    "\n[1]-Continuar tentando || [2]-voltar e realizar Cadastro");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:

                        TelaCadastroLogin telaLoginContinuar = new TelaCadastroLogin();
                        telaLoginContinuar.Mostrar(1, false);

                        break;
                    case 2:
                        TelaCadastroLogin telaLoginCadastro = new();
                        telaLoginCadastro.Mostrar(2 , false);

                        break;
            }

            }

        }
        #endregion

        #region Functions chamadas
        void Adicionar(ClienteModel cliente)
        {
            Controller.ClienteControllerUsuario clienteControllerUsuario = new();
            clienteControllerUsuario.AddCliente(false, cliente);

        }
        void AdicionarConvidado(ClienteModel cliente)
        {
            Controller.ClienteControllerUsuario clienteControllerUsuario = new();
            clienteControllerUsuario.AddCliente(true,cliente);

        }
        //Functions para a Camada adm
        void Lista()
        {
            AdmController cliente = new();
            cliente.ListaCliente();

        }


        void AdicionarAdm()
        {
            AdmController cliente = new();
            cliente.AddCliente();

        }
        void Remover()
        {
           AdmController cliente = new();
            cliente.Remover();

        }

        #endregion
    }
}
