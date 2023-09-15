using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using LojaDeSorteios.View;
using LojaDeSorteios.Model.Usuario;

namespace LojaDeSorteios.Controller
{
    internal class ClienteControllerUsuario
    {
            Cliente cliente = new();
            TelaLoginCadastro tela = new();

           public void AddCliente(Boolean convidado)
            {
            if (convidado == false)
            {

                Console.WriteLine("Informe seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe senha: ");
                string senha = Console.ReadLine();

                Console.WriteLine("Informe sua Idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine();

                cliente.Nome = nome;
                cliente.Idade = idade;
                cliente.Senha = senha;
                cliente.Iserir();

                Console.WriteLine("Cliente " + cliente.Nome + " cadastrado com sucesso!");

                tela.Mostrar(1, false);
        
            }else if(convidado ==  true)
            {
                Cliente convidados = new Cliente("Convidado",0);
                cliente.Iserir();

                Console.WriteLine("\n[Acessando como " + convidados.Nome + "]");

                tela.Mostrar(1, true);

            }

        }
        public void Remover()
        {
            cliente.Remove();
        }

        }
    }

