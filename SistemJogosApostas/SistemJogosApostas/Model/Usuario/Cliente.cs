using LojaDeSorteios.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeSorteios.Model.Usuario
{
    internal class Cliente
    {

        private int _idade;
        private string _nome;
        private string _senha;
        //Agora a lista para os clientes!
        private static List<Cliente> _listaCliente = new();


        //ADD cliente
        public void Iserir()
        {
            _listaCliente.Add(this);

        }

        public string Senha
        {
            get => _senha;
            set => _senha = value;
        }

        public void Mostrar()
        {
            TelaLoginCadastro tela = new();
            foreach (Cliente cliente in _listaCliente)
            {
                Console.WriteLine("Nome: " + cliente.Nome + " Idade: " + cliente.Idade);
            }
            Console.WriteLine();
            tela.Mostrar(1,false);
        }

        //Autenticação
        public void Autenticacao(string nome , string senha)
        {
           
            
               Cliente cliente1 = new();
                cliente1.Nome = "adm";
                cliente1.Senha = "153684497";
                _listaCliente.Add(cliente1);
            
            foreach (Cliente cliente in _listaCliente)
            {
                Console.WriteLine("\n\nUsuario: " + cliente.Nome);

                if (nome.Equals(cliente.Nome)  && senha.Equals(cliente.Senha) )
                {
                    
                    TelaDoJogo jogo = new();
                    jogo.MostrarTelaDoJogo(2, cliente.Nome);

                }
                else if(nome!=cliente.Nome || senha!=cliente.Senha)
                {
                    _listaCliente.RemoveAt(0);
                    Console.WriteLine("Usuario ou senha incorretos!");
                    
                    TelaLoginCadastro telaLoginCadastro = new();

                    telaLoginCadastro.Mostrar(3, false);

                }

            }


        }

        //Remove
        public void Remove()
        {
            TelaLoginCadastro tela = new();
            int id = 1;
            foreach (Cliente cliente in _listaCliente)
            {
                Console.WriteLine("[id: " + id + " Nome: " + cliente.Nome + " Idade: " + cliente.Idade + "]");
                id++;
            }
            Console.WriteLine();
            Console.WriteLine("Qual deseja Remover?");
            int escolha = int.Parse(Console.ReadLine());

            Cliente cliente1 = _listaCliente[escolha - 1];


            Console.WriteLine("Cliente " + cliente1.Nome + " Removido Com Sucesso!");

            _listaCliente.RemoveAt(escolha - 1);



            tela.Mostrar(1, false);
        }

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

        public Cliente()
        {

            _idade = 0;
            _nome = string.Empty;

        }

        public Cliente(string nome, int idade)
        {
            _idade = idade;
            _nome = nome;

        }



    }
}
