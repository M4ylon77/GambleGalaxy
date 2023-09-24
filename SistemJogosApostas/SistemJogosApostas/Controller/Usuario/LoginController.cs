using LojaDeSorteios.View;
using LojaDeSorteios.Controller;
using LojaDeSorteios.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDeSorteios.Model.Usuario;
using System.Diagnostics;

namespace LojaDeSorteios.Controller.Usuario
{
    internal class LoginController
    {
        public void Logando(string nome, string senha) 
        {
            ClienteControllerUsuario clienteControllerUsuario = new();

            int min = 0;
            /// int ida = 100;
            /// int volta = 0;
            string status = "Carregando...";

            do
            {


                Console.SetCursorPosition(0, Console.CursorTop); // Define a posição do cursor na coluna 0

                // Formate a saída com espaços em branco para garantir que números anteriores sejam apagados
                string output = $"{status}{min}%";
                Console.Write(output.PadRight(Console.WindowWidth));

                if (min >= 50 && min < 80)
                {
                    status = "Quase lá...";
                }
                else if (min > 98)
                {
                    status = "Carregamento Completo...";
                }

                min++;

                //Vai e vem de uma maneira inteligente ! 
                // if (min < ida)
                //{
                //    min++;

                // }else if(min > volta)
                // {//  min --;
                //  ida = 0;
                //  if (min == 0)
                //   {
                //     ida = 100;
                //}
                // }



                Thread.Sleep(50);

            } while (min <= 100);

            
            clienteControllerUsuario.Autenticacao(nome, senha);

        }

    }
}
