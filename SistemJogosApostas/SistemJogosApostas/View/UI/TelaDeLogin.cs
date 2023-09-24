using LojaDeSorteios.Controller.Usuario;
using LojaDeSorteios.Model.Aplicacao;
using LojaDeSorteios.Model.Usuario;
using LojaDeSorteios.View.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeSorteios.View
{
    internal class TelaDeLogin
    {

        public void MostrarTelaDoJogo(int valorJogo, string nome)
        {
            if (valorJogo == 1)
            {
                {

                    Console.WriteLine("\n\nInforme Usuario e Senha Para Logar!\n");


                    Console.WriteLine("Primeiro Nome:");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("Senha:");
                    string senha = Console.ReadLine();

                    int min = 0;
                    /// int ida = 100;
                    /// int volta = 0;
                    string status = "Carregando...";

                    do
                    {

                        Console.SetCursorPosition(0, Console.CursorTop); // Define a posição do cursor na coluna 0
                      // Formate a saída com espaços em branco para garantir que números anteriores sejam apagados
                        string output = $"{status}{min}%";
                        Console.Write(output.PadRight(Console.WindowWidth));


                        if (min >= 50 && min < 80)
                        {
                            status = "Quase lá...";
                        }
                        else if (min > 98)
                        {
                            status = "Carregamento Completo...";
                        }
                        min++;

                        #region Possibilidades a mais

                        //Vai e vem de uma maneira inteligente ! 
                        // if (min < ida)
                        //{
                        //    min++;

                        // }else if(min > volta)
                        // {//  min --;
                        //  ida = 0;
                        //  if (min == 0)
                        //   {
                        //     ida = 100;
                        //}
                        // }


                        #endregion

                        Thread.Sleep(50);

                    } while (min <= 100);


                    LoginController login = new();

                    login.Logando(usuario, senha);
                

            }

            }else if (valorJogo == 2)
            {
                
                if(nome.Equals("s"))
                {
                    Console.WriteLine("Convidado Logado!!");
                }
                   else
                {

                    Console.WriteLine("Logado!!");
                }

                Console.WriteLine("Qual game deseja jogar!" +
                    "[1]-Jogo de Time Aposta! || [2]-### Em Desenvolvimento!### || [3]-Fazer Logout");
                int escolhaJogo = int.Parse(Console.ReadLine());

                switch (escolhaJogo)
                {
                    case 1:

                        ClienteModel cliente = new ClienteModel();
                        cliente.Nome = nome;
                        JogoModel jogo = new JogoModel(cliente);
                        TelaUsuarioJogo telaUsuario = new();

                        Console.WriteLine("\nBem vindo " + jogo.Player.Nome + " A apostas de esportes!");

                        telaUsuario.PlayerEmJogo();
                        

                        break;
                    case 2:


                        break;
                }


            }
            if (valorJogo == 3) 
            {
                TelaDeLogin jogo = new();
                jogo.MostrarTelaDoJogo(2, "s");
            }
        }

    }
}
