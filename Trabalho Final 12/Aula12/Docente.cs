using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Docente : Funcionario
    {
        public string Temporario { get; set; }
        public string Indeterminado { get; set; }
        public int N_aula { get; set; }
        public int Valor_aula { get; set; }



        public double CalcularSalario()
        {

            return (this.Salario + this.Valor_aula * this.N_aula);
        }

    }

}
