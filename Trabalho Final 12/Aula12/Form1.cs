using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlTemporario.Visible = false;
            pnlIndeterminado.Visible = false;
            pnlOutro.Visible = false;
            pnlDiretoria.Visible = false;

        }

        Funcionario f1 = new Funcionario();

        Administrativo a1 = new Administrativo();

        Docente d1 = new Docente();

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            f1.Nome = txtNome.Text;
            f1.Cpf = mskCpf.Text;
            f1.Salario = double.Parse(txtSalario.Text);
            MessageBox.Show(f1.imprime());
            MessageBox.Show(f1.CalcularSalario().ToString("n2"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            d1.N_aula = int.Parse(txtNaula.Text);
            d1.Valor_aula = int.Parse(txtVaula.Text);
            MessageBox.Show(d1.CalcularSalario().ToString("n2"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d1.N_aula = int.Parse(txtNaula.Text);
            d1.Valor_aula = int.Parse(txtVaula.Text);
            MessageBox.Show(d1.CalcularSalario().ToString("n2"));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxTemporario_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxTemporario.Checked)
            {
                pnlIndeterminado.Visible = false;
                cbxIndeterminado.Checked = false;
                pnlTemporario.Visible = true;
            }
        }

        private void cbxIndeterminado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTemporario.Checked)
            {
                pnlTemporario.Visible = false;
                cbxTemporario.Checked = false;
                pnlIndeterminado.Visible = true;
            }
            
        }

        private void cbxOutro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDiretoria.Checked)
            {
                pnlDiretoria.Visible = false;
                cbxDiretoria.Checked = false;
                pnlOutro.Visible = true;
            }

        }

        private void cbxDiretoria_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxOutro.Checked)
            {
                pnlOutro.Visible = false;
                cbxOutro.Checked = false;
                pnlDiretoria.Visible = true;
            }
        }

        private void btnDiretoria_Click(object sender, EventArgs e)
        {
            /*
                  public string  OutroParticipacao_lucro { get; set; }
                  public string DiretoriaParticipacao_lucro { get; set; }
             */
           a1.DiretoriaParticipacao_lucro = int.Parse(txtDiretoria.Text);
            MessageBox.Show(d1.CalcularSalario().ToString("n2"));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOutro_Click(object sender, EventArgs e)
        {
            a1.OutroParticipacao_lucro = int.Parse(txtOutro.Text);
            MessageBox.Show(d1.CalcularSalario().ToString("n2"));
        }

        private void pnlDiretoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlOutro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
