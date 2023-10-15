using LojaDeSorteios.Controller.Usuario;
using LojaDeSorteios.Model.Aplicacao;
using LojaDeSorteios.Model.Usuario;
using LojaDeSorteios.View.UI;
using SistemJogosApostas.Model.Usuario;
using SistemJogosApostas.View.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeSorteios.View
{
    internal class TelaDoJogo
    {
      
        public void MostrarTelaDoJogo(int valorJogo, string nome, Convidado convidad1, int num)
        {
            if (valorJogo == 1)
            {
                

                    Console.WriteLine("\n\nInforme Usuario e Senha Para Logar!\n");

                    Console.WriteLine("Informe seu nome: ");
                    string Cnome = Console.ReadLine();

                    Console.WriteLine("Informe senha: ");
                    string senha = Console.ReadLine();

                    LoginController login = new();
                    login.Logando(Cnome,senha);

                

            }else if (valorJogo == 2)
            {
                
                if(nome.Equals(""))
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
                        TelaConvidadoJogo telaUsuario = new();

                        Console.WriteLine("\n==Bem vindo " + jogo.Player.Nome + " a apostas de esportes!==");

                        if (num == 1)
                        {
                            TelaUsuarioJogo telaUsuarioJogo = new();

                            telaUsuarioJogo.PlayerEmJogo(0,0);                            

                        }
                        else
                        {
                            
                            telaUsuario.PlayerEmJogo(1, 0);
                        }

                        break;
                    case 2:


                        break;
                }


            }
            if (valorJogo == 3) 
            {
                TelaDoJogo jogo = new();

                jogo.MostrarTelaDoJogo(2, "",null,0);
            }
        }

    }
}
