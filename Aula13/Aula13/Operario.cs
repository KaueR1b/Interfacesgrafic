using System;
using System.Collections.Generic;
using System.Text;

namespace Aula13
{
    class Operario : Funcionario
    {
        public string Setor { get; set; }
        public override double Calcula => Salario*1.1;
    }
}
