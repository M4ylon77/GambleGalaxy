using LojaDeSorteios.Model.Usuario;
using SistemJogosApostas.View.Adm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeSorteios.View
{
    internal class TelaInicio
    {
        public void MostrarInicio()
        {

            
         

            Console.WriteLine("[€GambleGalaxy€]\nBem vindo já é cadastrado?\n" +
                "[1]-Sim || [2]-Não || [3]-ADM");
            int escolha = int.Parse(Console.ReadLine());
            #region sim
            switch (escolha)
            {
                case 1:
                    TelaLoginCadastro tela = new TelaLoginCadastro();
                    TelaDoJogo telaDoJogo = new TelaDoJogo();

                    telaDoJogo.MostrarTelaDoJogo(1, null,null,0);

                    break;
                #endregion

            #region não
                case 2:
                        Console.WriteLine("[1]-Realizar Cadastro || [2]-Visualizar Jogo como convidado");
                        escolha = int.Parse(Console.ReadLine());    

                    switch(escolha)
                    {
                        case 1:
                            TelaLoginCadastro telaLoginCadastro = new();
                            telaLoginCadastro.Mostrar(2 , false);
                            break;
                        case 2:

                            TelaLoginCadastro telaComoConvidado = new();
                            telaComoConvidado.Mostrar(2,true);

                            break;
                    }
                break;

                case 3:

                    TelaLoginAdm telaloginadm = new();
                    telaloginadm.Mostrar();

                    break;
            }

            #endregion
        }
    }
}
