using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCapital_Enter(object sender, EventArgs e)
        {
            if (txtCapital.Text=="CAPITAL")
            {
                txtCapital.Text = "";
                txtCapital.ForeColor = Color.LightGray;
            }
        }

        private void txtCapital_Leave(object sender, EventArgs e)
        {
            if(txtCapital.Text=="")
            {
                txtCapital.Text = "CAPITAL";
                txtCapital.ForeColor = Color.DimGray;
            }
        }

        private void txtTiempo_Enter(object sender, EventArgs e)
        {
            if (txtTiempo.Text == "TIEMPO")
            {
                txtTiempo.Text = "";
                txtTiempo.ForeColor = Color.LightGray;
            }
        }

        private void txtTiempo_Leave(object sender, EventArgs e)
        {
            if (txtTiempo.Text == "")
                txtTiempo.Text = "TIEMPO";
            txtTiempo.ForeColor = Color.DimGray;
            {

            }
        }

        private void txtTasa_Enter(object sender, EventArgs e)
        {
            if(txtTasa.Text=="TASA")
            {
                txtTasa.Text = "";
                txtTasa.ForeColor = Color.LightGray;
            }
        }

        private void txtTasa_Leave(object sender, EventArgs e)
        {
            if(txtTasa.Text=="")
            {
                txtTasa.Text = "TASA";
                txtTasa.ForeColor = Color.DimGray;

            }
        }

        private void txtInteres_Enter(object sender, EventArgs e)
        {
            if (txtInteres.Text == "INTERES")
            {
                txtInteres.Text="";
                txtInteres.ForeColor = Color.LightGray;
            }
        }

        private void txtInteres_Leave(object sender, EventArgs e)
        {
            if (txtInteres.Text=="")
            {
                txtInteres.Text = "INTERES";
                txtInteres.ForeColor = Color.DimGray;
            }
        }

        private void txtMonto_Enter(object sender, EventArgs e)
        {
            if(txtMonto.Text=="MONTO")
            {
                txtMonto.Text = "";
                txtMonto.ForeColor = Color.DimGray;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double capital, r, t;
            double interes, monto;

            capital = double.Parse(txtCapital.Text);
            r = double.Parse(txtTasa.Text);
            t = double.Parse(txtTiempo.Text);

            //Proceso de datos 

            monto = Math.Pow((1 + r), t) * capital;
            interes = monto - capital;

            //salida de informacion o datos
            txtMonto.Text = Convert.ToString(monto);
            txtInteres.Text = Convert.ToString(interes);


            



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCapital.Text = "";
            txtTiempo.Text = "";
            txtTasa.Text = "";
            txtInteres.Text = "";
            txtMonto.Text = "";
        }

        private void txtCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTiempo.Focus();
            }
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTasa.Focus();
            }

        }

        private void txtTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCalcular.PerformClick();
                btnCancelar.Focus();
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          

        }


    }
}
