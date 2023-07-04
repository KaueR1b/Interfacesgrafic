using System;
using System.Collections.Generic;
using System.Text;

namespace AV3220023
{
    class onibus : veiculo, Ionibus
    {
        public string Assento { get; set; }
        public int Preco { get; set; }

        public void Exibir(double valor)
        {
        }

        public double reajustar()
        {
            return this.Preco * 1.02;
        }
    }
}
