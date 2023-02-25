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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string[] productos = txtProductos.Text.Split(',');
            string[] precios = txtPrecios.Text.Split(',');

            // Verificar que se haya ingresado la misma cantidad de productos y precios
            if (productos.Length != precios.Length)
            {
                MessageBox.Show("Debe ingresar la misma cantidad de productos y precios");
                return;
            }

            // Calcular el total de la venta
            double totalVenta = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                double precio = double.Parse(precios[i]);
                totalVenta += precio;
            }

            // Aplicar el descuento asíncronamente
            double totalDescuento = await CalcularDescuento(totalVenta);  // Mostrar el resultado al usuario
            listBox1.Items.Add($"Total de la venta: {totalVenta:C}");
            listBox1.Items.Add($"Total con descuento del 15%: {totalDescuento:C}");
        }

        private async Task<double> CalcularDescuento(double totalVenta)
        {
            // Simular un proceso que tarda un segundo
            await Task.Delay(1000);

            // Calcular el descuento del 15% sobre el total de la venta
            double descuento = totalVenta * 0.15;
            double totalDescuento = totalVenta - descuento;

            return totalDescuento;
        }
    }
}
