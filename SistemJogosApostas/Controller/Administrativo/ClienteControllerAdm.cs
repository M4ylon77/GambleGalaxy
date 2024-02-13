using LojaDeSorteios.Model.Usuario;
using LojaDeSorteios.View;

namespace LojaDeSorteios.Controller.Administrativo
{
    internal class CLienteControllerAdm
    {
        ClienteModel cliente = new();
        TelaLoginCadastro tela = new();
        ClienteControllerUsuario cli = new();


        public void AddCliente()
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            cliente.Nome = nome;
            cliente.Idade = idade;
            cli.AddCliente(false,cliente);

            Console.WriteLine("Cliente " + cliente.Nome + " cadastrado com sucesso!");

            tela.Mostrar(0, false);

        }
     
    }
}

