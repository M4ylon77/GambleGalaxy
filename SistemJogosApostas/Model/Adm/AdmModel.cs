using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemJogosApostas.Model.Adm
{
    internal class AdmModel
    {
        private string _nome;
        private string _user;
        private string _password;

        public string Senha
        {
            get => _password;
            set => _password = value;
        }

        public string Nome
        {
            get => _nome;
            set => _nome = value;

        }

        public string User
        {
            get => _user;     
            set => _user = value;
        }

        public AdmModel()
        {

        }
        public AdmModel(string nome, string password, string user) 
        {
            _password = password;
            _nome = nome;
            _user = user;
        }



    }
}
