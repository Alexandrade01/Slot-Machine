using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCaçaNiquel1._1
{
    class Jogador
    {
        private string nome;
        private double saldo = 0;

        public string Nome { get => nome; set => nome = value; }
        public double Saldo { get => saldo; }
        

        public string GanhosPerdas(int value)
        {
            saldo += value;
            return $"R$ {Saldo.ToString("0.00")}";
        }
   
    }
}
