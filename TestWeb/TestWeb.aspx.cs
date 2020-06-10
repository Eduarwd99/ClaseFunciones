using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class TestWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ProgClaseFunciones.MainClass op = new ProgClaseFunciones.MainClass();
            string num = this.txtNum.Text;
            int x = Convert.ToInt32(num);
            string valor = op.FnParImpar(x);
            this.txtNumR.Text = valor;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ProgClaseFunciones.MainClass op2 = new ProgClaseFunciones.MainClass();
            string mes = this.txtMes.Text;
            int y = Convert.ToInt32(mes);
            string valor2 = op2.FnMeses(y);
            this.txtMesR.Text = valor2;
        }
    }
}