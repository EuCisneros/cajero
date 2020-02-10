using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnretirar_Click(object sender, EventArgs e)
        {

            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            double cantidad = double.Parse(txtcantidad.Text);
            sbyte n = 0;
            string respuesta = "Respuesta: \n";
            foreach(double denominacion in denominaciones){
                while (denominacion <= Math.Round(cantidad,2)) {
                    n++;
                    cantidad -= denominacion;

                }
                if (n > 0)
                {
                    respuesta += n + (denominacion > 1 ? "Billetes " : "Monedas ") + denominacion + "\n";
                }
                n = 0;
            }
            lblrespuesta.Text = respuesta;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncobrar_Click(object sender, EventArgs e)
        {

            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            double pagar = double.Parse(txtpagar.Text);
            double efectivo = double.Parse(txtefectivo.Text);
            double proce = efectivo - pagar;

            lblvuelto.Text = "Vuelto: $" + proce;

        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnumero.Text);
            int cont = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }

            }
            if (cont == 2)
            {
                lblresp.Text = n + " Es Primo";
            }
            else
            {
                lblresp.Text = n + " No es Primo";
            }
        
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            int a, b, lim, i, aux;
            lim = int.Parse(txtNUM.Text);
            string resfibo = "";
            a = 1;
            b = 1;
            for (i = 0; i < lim; i++)
            {
                aux = a;
                a = b;
                b = aux + a;
                resfibo += "La suma de  " + a + " + " + aux + " es " + b + "\n";
                lblrfi.Text = "" + resfibo;
            }
    }
}