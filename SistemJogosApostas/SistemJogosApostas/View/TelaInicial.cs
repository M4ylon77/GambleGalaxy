using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDeSorteios.Model;
using LojaDeSorteios.View;
using LojaDeSorteios;

namespace LojaDeSorteios.View
{
    internal class TelaInicial
    {
        public void Mostrar() {

            Console.WriteLine("[1]-" +
                "[2]-" +
                "[3]-");

            TelaLoginCadastro tela = new TelaLoginCadastro();

          //  tela.Mostrar(5);



        }

    }
}
