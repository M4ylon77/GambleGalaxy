using LojaDeSorteios.Controller;
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
    internal class TelaLoginCadastro
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

             

                TelaDoJogo telaDoJogo = new();

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
                            Adicionar();
                       

                }else if (convidado == true) 
                {
                    AdicionarConvidado();
                }
            }
            #endregion
            else
            {


                Console.WriteLine("\nDeseja continuar ou voltar e se Cadastrar!" +
                    "\n[1]-Continuar tentando || [2]-voltar e realizar Cadastro");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:

                        TelaLoginCadastro telaLoginContinuar = new TelaLoginCadastro();
                        telaLoginContinuar.Mostrar(1, false);

                        break;
                    case 2:
                        TelaLoginCadastro telaLoginCadastro = new();
                        telaLoginCadastro.Mostrar(2 , false);

                        break;
            }

            }

        }

        #region Functions chamadas
        void Adicionar()
        {
            Controller.ClienteControllerUsuario clienteControllerUsuario = new();
            clienteControllerUsuario.AddCliente(false);

        }
        void AdicionarConvidado()
        {
            Controller.ClienteControllerUsuario clienteControllerUsuario = new();
            clienteControllerUsuario.AddCliente(true);

        }
        //Functions para a Camada adm
        void Lista()
        {
            CLienteControllerAdm cliente = new();
            cliente.ListaCliente();

        }


        void AdicionarAdm()
        {
            CLienteControllerAdm cliente = new();
            cliente.AddCliente();

        }
        void Remover()
        {
           CLienteControllerAdm cliente = new();
            cliente.Remover();

        }

        #endregion
    }
}
