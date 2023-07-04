using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prova
{
    public partial class telaonibus : Form
    {
        Onibus on = new Onibus();
        public telaonibus()
        {
            InitializeComponent();
        }

        private void btnreaj_Click(object sender, EventArgs e)
        {
            on.reajustar(double.Parse(txtpreco.Text));

        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assento" + on.Assento + "Ano" + on.Ano + "Placa" + on.Placa + "Preço" + on.Preco) ;
        }
    }
}
