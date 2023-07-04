using System;
using System.Collections.Generic;
using System.Text;

namespace prova
{
    class Onibus : veiculo, Ionibus
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
