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
    internal class TelaDoJogo
    {

        public void MostrarTelaDoJogo(int valorJogo, string nome)
        {
            if (valorJogo == 1)
            {
                {

                    Console.WriteLine("\n\nInforme Usuario e Senha Para Logar!\n");
                    
                    LoginController login = new();
                    login.Logando();

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

                        Cliente cliente = new Cliente();
                        cliente.Nome = nome;
                        Jogo jogo = new Jogo(cliente);
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
                TelaDoJogo jogo = new();
                jogo.MostrarTelaDoJogo(2, "s");
            }
        }

    }
}
