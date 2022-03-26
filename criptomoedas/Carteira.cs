using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criptomoedas
{
    internal class Carteira
    {
        public string Endereco { get; set; }

        public Carteira(string endereco)
        {
            Endereco = endereco;
        }

        public void InsereItemCarteira()
        {

        }
        public void ImprimeCarteira()
        {
            Console.WriteLine("Imprime carteira {0}", this.Endereco);
        }
        public void Deposita()
        {

        }
        public void Saca()
        {

        }
    }
}
