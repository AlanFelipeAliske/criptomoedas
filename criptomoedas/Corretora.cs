using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criptomoedas
{
    internal class Corretora
    {
        public int CodigoCorretora { get; set; }
        public string NomeCorretora { get; set; }

        public Corretora(int codigoCorretora, string nomeCorretora)
        {
            CodigoCorretora = codigoCorretora;
            NomeCorretora = nomeCorretora;
        }
        public void ImprimeCorretora()
        {
            Console.WriteLine("Imprime codigo corretora {0}, {1}", this.CodigoCorretora, NomeCorretora);
        }
        public void InsereCarteira()
        {

        }

    }
}
