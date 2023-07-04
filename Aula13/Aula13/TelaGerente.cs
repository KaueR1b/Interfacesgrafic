using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula13
{
    public partial class TelaGerente : Form
    {
        public TelaGerente()
        {
            InitializeComponent();
        }

        private void btncalcula_Click(object sender, EventArgs e)
        {
            Gerente salario1 = new Gerente();
                salario1.Salario = double.Parse(txtsalario.Text);
            lblsalario.Text = salario1.Calcula.ToString();
                
        }
    }
}
