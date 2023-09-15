using LojaDeSorteios.Model.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeSorteios.Model.Aplicacao
{
    internal class Jogo
    {
        private ClienteModel _player;

        public ClienteModel Player
        {
            get => _player;
            set => _player = value;

  
        }

        public Jogo()
        {
            _player = null;

        }

       
        public Jogo(ClienteModel player)
        {
            _player = player;

        }




    }

}
