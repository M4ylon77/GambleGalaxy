using LojaDeSorteios.Controller.Administrativo;
using SistemJogosApostas.Model.Adm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemJogosApostas.View.Adm
{
    internal class TelaLoginAdm
    {
        public void Mostrar()
        {
          
            AdmController cLienteControllerAdm = new();


            Console.WriteLine("[Acesso Administrativo]");
            Console.WriteLine("Informe User:");
            string user = Console.ReadLine();
            Console.WriteLine("Informe passowrd:");
            string password = Console.ReadLine();

            AdmModel adm = new(user,password,user);

            cLienteControllerAdm.Autenticação(adm);

        }
    }
}
