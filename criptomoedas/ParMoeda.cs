using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criptomoedas
{
    internal class ParMoeda
    {
        public Moeda moeda { get; set; }
        public double Valor { get; set; }
        public ParMoeda() { }
        public ParMoeda (double valor, Moeda moeda)
        {
            this.Valor = valor;
            this.moeda = moeda;
        }
        public void ImprimeParMoeda()
        {
            Console.WriteLine("Imprime moeda base:'{0}', e moeda cotacao:'{1}'", this.Valor, this.moeda);
        }

    }
}
