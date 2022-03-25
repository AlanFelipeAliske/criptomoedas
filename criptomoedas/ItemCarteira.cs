using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criptomoedas
{
    internal class ItemCarteira
    {
        public double Quantidade { get; set; }
    
        public ItemCarteira(double quantidade)
        {
            Quantidade = quantidade;
        }
        public ItemCarteira()
        {
            Quantidade = 100;
        }
        public void ObtemCotacaoMoeda()
        {

        }
        public void ImprimeItemCarteira()
        {
            Console.WriteLine("Quantidade: {0}", this.Quantidade);
        }

    
    }

}
