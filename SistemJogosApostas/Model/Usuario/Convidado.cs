using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemJogosApostas.Model.Usuario
{
    internal class Convidado
    {
        private Double _moneyTraine;

        private static List<Convidado> _convidadoList = new();

        public void listar()
        {
            foreach (Convidado convidado in _convidadoList)
            {
                Console.WriteLine(convidado._moneyTraine);
            }
        }
        public void AddList(Convidado convidado)
        {
            _convidadoList.Add(convidado);
        }

        public Double MoneyTraine
        {
            get => _moneyTraine;
            set => _moneyTraine = value;
        }

    }
}
