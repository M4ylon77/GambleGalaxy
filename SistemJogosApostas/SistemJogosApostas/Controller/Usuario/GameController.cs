using LojaDeSorteios.View.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeSorteios.Controller.Usuario
{
    internal class GameController
    {
        //criar uma funçãozinha para otimizar o codigo ! meu querido ! 

        private  List<string> _listTime = new();
       
        public void Funcionalidade(Double valor , int time)
        {
            Console.Clear();    

            _listTime.Add("Corinthians");
            _listTime.Add("São Paulo");
            _listTime.Add("Palmeiras");

            Random random = new Random();

                

            int golsMeuTime;
            int golsAdversario;

            golsMeuTime = random.Next(minValue: 0, maxValue:5);
            golsAdversario = random.Next(minValue: 0, maxValue: 5);


            switch (time)
            {
                case 1:
                    _listTime.Remove("Corinthians");
                    int eTime = random.Next(0, _listTime.Count);
                    var timeEscolhido = _listTime[eTime];
                    Console.WriteLine("Corinthians VS " + timeEscolhido);

                    Console.WriteLine("Corinthians fez: " +  golsMeuTime + " gols " + timeEscolhido + " fez: " +  golsAdversario + " gols\n");

                    Voltar();


                    break;

                case 2:

                    _listTime.Remove("São Paulo");
                    int sTime = random.Next(0, _listTime.Count);
                    var timeEscolhido2 = _listTime[sTime];
                    Console.WriteLine("São Paulo VS " + timeEscolhido2);

                    Console.WriteLine("São Paulo fez: " + golsMeuTime + " gols " + timeEscolhido2 + " fez: " + golsAdversario + " gols");

                    Voltar();

                    break;

                case 3:

                    _listTime.Remove("Palmeiras");
                    int pTime = random.Next(0, _listTime.Count);
                    var timeEscolhido3 = _listTime[pTime];
                    Console.WriteLine("Palmeiras VS " + timeEscolhido3);
                    Console.WriteLine("Palmeiras fez: " + golsMeuTime + " gols " + timeEscolhido3 + " fez: " + golsAdversario + " gols");

                    Voltar();


                    break;
            }

            


        }
        void Voltar()
        {

            TelaUsuarioJogo telaUsuario = new();

            telaUsuario.PlayerEmJogo();


        }
    }

}
