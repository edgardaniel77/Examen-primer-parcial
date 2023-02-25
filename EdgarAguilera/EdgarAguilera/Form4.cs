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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       
        private void Form4_Load(object sender, EventArgs e)
        {
            MostrarNumeros();
        }
        private void MostrarNumeros()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add($"{i}: Edgar Aguilera");
                }
                else if (i % 3 == 0)
                {
                    listBox1.Items.Add($"{i}: Edgar");
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add($"{i}: Aguilera");
                }
                else
                {
                    listBox1.Items.Add(i);
                }
            }

        }

        
    } 
}
