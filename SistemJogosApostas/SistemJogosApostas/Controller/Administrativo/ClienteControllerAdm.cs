using LojaDeSorteios.Model.Usuario;
using LojaDeSorteios.View;

namespace LojaDeSorteios.Controller.Administrativo
{
    internal class CLienteControllerAdm
    {
        Cliente cliente = new();
        TelaLoginCadastro tela = new();
        public void ListaCliente()
        {

            cliente.Mostrar();
        }

        public void AddCliente()
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            cliente.Nome = nome;
            cliente.Idade = idade;
            cliente.Iserir();

            Console.WriteLine("Cliente " + cliente.Nome + " cadastrado com sucesso!");

            tela.Mostrar(0, false);

        }
        public void Remover()
        {
            cliente.Remove();
        }

    }
}

