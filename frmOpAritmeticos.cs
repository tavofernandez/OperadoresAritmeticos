using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Operadores_Aritmeticos
{
    public partial class frmOpAritmeticos : Form
    {
        public frmOpAritmeticos()
        {
            InitializeComponent();
        }

        double numero1, numero2, resultado;

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Suma();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            
        }

        private void Resta()
        {
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);

            resultado = numero1 - numero2;

            lblresultado.Text = resultado.ToString();
        }

        private void Suma()
        {
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);

            resultado = numero1 + numero2;

            lblresultado.Text = resultado.ToString();
        }

        private void frmOpAritmeticos_Load(object sender, EventArgs e)
        {

        }
    }
}
