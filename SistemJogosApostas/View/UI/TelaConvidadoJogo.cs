using LojaDeSorteios.Controller.Usuario;
using SistemJogosApostas.Model.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LojaDeSorteios.View.UI
{
    internal class TelaConvidadoJogo
    {
        static Convidado convidado = new Convidado();
        Double valors;
        public void PlayerEmJogo(int convidad, Double valorDesc)
        {
            if (convidad == 1)
            {
                
                convidado.MoneyTraine = 5000;
                Console.WriteLine("\nValor Treinero => [" + (valors = convidado.MoneyTraine) + "]\n\n" +
                    "Qual time você deseja apostar?");
                Console.WriteLine("[1]-Corinthians" +
                    "[2]-São Paulo" +
                    "[3]-Palmeiras" +
                    "[4]-Voltar/Encerrar ");
            }
            else
            {
                valors = convidado.MoneyTraine = valorDesc;
                string numeroFormatado = valors.ToString("f2");

                Console.WriteLine("\nValor Treinero => [" + numeroFormatado + "]\n\n"+
                    "Qual time você deseja apostar?");
                Console.WriteLine("[1]-Corinthians" +
                    "[2]-São Paulo" +
                    "[3]-Palmeiras" +
                    "[4]-Voltar/Encerrar " );

            }

            int escolhaTime = int.Parse(Console.ReadLine());

            switch (escolhaTime)
            {
                case 1:
                    Console.WriteLine("Seu time é Corinthians!!");

                    Console.WriteLine("qual o Valor da sua Aposta: ");
                    Double valorAposta = Double.Parse(Console.ReadLine());

                    Apostar(valorAposta, escolhaTime, valors);

                    break;
                case 2:

                    Console.WriteLine("Seu time é São Paulo!!");

                    Console.WriteLine("qual o Valor da sua Aposta: ");
                    valorAposta = Double.Parse(Console.ReadLine());


                    Apostar(valorAposta, escolhaTime, convidado.MoneyTraine);


                    break;
                case 3:


                    Console.WriteLine("Seu time é Palmeiras!!");

                    Console.WriteLine("qual o Valor da sua Aposta: ");
                    valorAposta = Double.Parse(Console.ReadLine());

                    Apostar(valorAposta, escolhaTime, convidado.MoneyTraine);

                    break;
                case 4:

                    TelaDoJogo telaDoJogo = new TelaDoJogo();

                    telaDoJogo.MostrarTelaDoJogo(2, "", null,0);

                    break;
            }



        }

        void Apostar(double valorAposta, int time, Double con)
        {
            GameController game = new();

            game.Funcionalidade(valorAposta, time, con);

        }

    }

}
