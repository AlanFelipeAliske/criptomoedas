using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criptomoedas
{
    internal class Moeda
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public Moeda(string codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public Moeda()
        {
            Codigo = "teste";
            Nome = "BRL";
        }

        public void ImprimeMoeda(string codigo, string nome)
        {
            Console.WriteLine("Impressão moeda {0}, {1}", this.Codigo, nome);
        }
        
    }
}
