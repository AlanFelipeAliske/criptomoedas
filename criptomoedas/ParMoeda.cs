using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criptomoedas
{
    internal class ParMoeda
    {
        public double Valor { get; set; }

        public ParMoeda (double valor)
        {
            Valor = valor;
        }
        public void ImprimeParMoeda()
        {
            Console.WriteLine("Imprime par moeda {0}", this.Valor);
        }

    }
}
