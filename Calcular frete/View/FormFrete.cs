using Calcular_frete.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_frete.View
{
    public partial class FormFrete : Form
    {
        Frete frete = new Frete();
        public FormFrete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UF = cBuf.Text;
            decimal v = Convert.ToDecimal(txt_Valor.Text);
            lbl_result.Text = frete.Calcular(UF, v).ToString();
        }
    }
}
