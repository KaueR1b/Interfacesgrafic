using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace aula11
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }
        Form tela;
        private void button1_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new Form2
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,

            };
            pnltelas.Controls.Add(tela);
            tela.Show();
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
