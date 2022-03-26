﻿using System;
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
        /*public ItemCarteira()
        {
            Quantidade = quantidade;
        }*/
        public void ObtemCotacaoMoeda()
        {
            Quantidade = this.Quantidade + 1000;
        }
        public void ImprimeItemCarteira()
        {
            ObtemCotacaoMoeda();
            Console.WriteLine("Quantidade: {0}", this.Quantidade);
        }

    
    }

}
