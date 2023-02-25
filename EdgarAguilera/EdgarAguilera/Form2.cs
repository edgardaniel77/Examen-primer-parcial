using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdgarAguilera
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double monto = 200000.00; // monto inicial del depósito
            double tasa = 0.015; // tasa de interés mensual del 1.5%
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };



            // Calcular el interés mensual para cada mes y agregarlo al ListBox
            for (int i = 0; i < meses.Length; i++)
            {
                double interes = monto * tasa;
                monto += interes;
                listBox1.Items.Add(meses[i] + ": L " + interes.ToString("#,##0.00"));
            }
        }
    }
}
