using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgClaseFunciones.MainClass op = new ProgClaseFunciones.MainClass();
            string num = this.txtNum.Text;
            int x = Convert.ToInt32(num);
            string valor = op.FnParImpar(x);
            this.txtNumR.Text = valor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProgClaseFunciones.MainClass op2 = new ProgClaseFunciones.MainClass();
            string mes = this.txtMes.Text;
            int y = Convert.ToInt32(mes);
            string valor2 = op2.FnMeses(y);
            this.txtMesR.Text = valor2;
        }
    }
}
