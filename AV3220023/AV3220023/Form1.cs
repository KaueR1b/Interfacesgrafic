using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV3220023
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        onibus on = new onibus();
        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assento" + on.Assento + "Ano" + on.Ano + "Placa" + on.Placa + "Preço" + on.Preco);
        }

        private void btnreaj_Click(object sender, EventArgs e)
        {
            on.reajustar(double.Parse(txtpreco.Text));
        }
    }
}
