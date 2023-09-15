using LojaDeSorteios.Controller.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeSorteios.View.UI
{
    internal class TelaUsuarioJogo
    {
        public void PlayerEmJogo()
        {
            Console.WriteLine("Qual time você deseja apostar?");
            Console.WriteLine("\n[1]-Corinthians" +
                "[2]-São Paulo" +
                "[3]-Palmeiras" +
                "[4]-Voltar/Encerrar");
            int escolhaTime = int.Parse(Console.ReadLine());    

            switch (escolhaTime)
            {
                case 1:
                    Console.WriteLine("Seu time é Corinthians!!");

                    Console.WriteLine("qual o Valor da sua Aposta: ");
                    Double valor = Double.Parse(Console.ReadLine());


                    Apostar(valor, escolhaTime);        

                    break;
                case 2:

                    Console.WriteLine("Seu time é São Paulo!!");

                    Console.WriteLine("qual o Valor da sua Aposta: ");
                    valor = Double.Parse(Console.ReadLine());

                    Apostar(valor, escolhaTime);


                    break;
                case 3:


                    Console.WriteLine("Seu time é Palmeiras!!");

                    Console.WriteLine("qual o Valor da sua Aposta: ");
                    valor = Double.Parse(Console.ReadLine());

                    Apostar(valor, escolhaTime);

                    break;
                 case 4:

                    TelaDoJogo telaDoJogo = new TelaDoJogo();

                    telaDoJogo.MostrarTelaDoJogo(2,"");

                    break;
                }

            

        }
   
        void Apostar(Double valor, int time)
        {
            GameController game = new();

            game.Funcionalidade(valor, time);

        }

    }
   
}
