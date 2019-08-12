using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pokemon_33581
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblPokemonB_Click(object sender, EventArgs e)
        {

        }

        private void lblAtqueQuant_Click(object sender, EventArgs e)
        {

        }

        private void bntResultado_Click(object sender, EventArgs e)
        {
            double A, D, L, P;

            try
            {
                A = double.Parse(txtAtaque.Text);
                D = double.Parse(txtDefesa.Text);
                L = double.Parse(txtLevel.Text);
                P = double.Parse(txtPoder.Text);
            }
            catch (Exception)
            {
                Message.Show("Digite Apenas Numeros");
                return;
            }


        }
    }
}
