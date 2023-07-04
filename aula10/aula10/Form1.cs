using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlaluno.Visible = false;
            pnlprof.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxprof_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxprof.Checked)
            {
                pnlaluno.Visible = false;
                cbxaluno.Checked = false;
                pnlprof.Visible = true;
            }

        }

        private void cbxaluno_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxprof.Checked)
            {
                pnlprof.Visible = false;
                cbxprof.Checked = false;
                pnlaluno.Visible = true;
            }
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (cbxaluno.Checked)
            {
                Aluno aluno = new Aluno(txtnome.Text, txtcpf.Text, txtendereco.Text, txttel.Text, txtra.Text, txtcurso.Text, txtturma.Text);
            }
            else (cbxprof.Checked){
                Professor professor = new Professor(txtnome.Text, txtcpf.Text, txtendereco.Text, txttel.Text, txtaula.Text, txtgrad.text);
            }
        }
    }
}
