using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    //classe funcionario e propriedades
    class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public string imprime()
        {
            return ("Nome: "+this.Nome+ "\nCPF: "+this.Cpf + "Salário: " + this.Salario);
        }

        //metodo calcular salario com desconto de 9% salario
        public double CalcularSalario()
        {
            return (this.Salario *  0.9);
        }
    }
}
