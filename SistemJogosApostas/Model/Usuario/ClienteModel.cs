using LojaDeSorteios.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeSorteios.Model.Usuario
{
    internal class ClienteModel
    {

        private int _idade;
        private string _nome;
        private string _senha;

        //Agora a lista para os clientes!      

        //ADD cliente
      

        public string Senha
        {
            get => _senha;
            set => _senha = value;
        }

      

        //Autenticação
      

        //Remove
      
        public int Idade
        {
            get => _idade;
            set => _idade = value;
        }

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public ClienteModel()
        {

            _idade = 0;
            _nome = string.Empty;
            _senha = string.Empty;

        }

        public ClienteModel(string nome, int idade, string senha)
        {
            _idade = idade;
            _nome = nome;
            _senha = senha;

        }



    }
}
