using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FrmInputHitung : Form
    {
        public delegate void Link(int operation, int a, int b, int hasil);
        public event Link link;

        public FrmInputHitung()
        {
            InitializeComponent();
        }

        public void btnProses_Click(object sender, EventArgs e)
        {
            string operation = cOperation.SelectedItem.ToString();
            int a = Convert.ToInt32(txtNilaiA.Text);
            int b = Convert.ToInt32(txtNilaiB.Text);
            int hasil = 0;
            switch (cOperation.SelectedIndex)
            {
                case 0:
                    hasil = a + b;
                    break;
                case 1:
                    hasil = a - b;
                    break;
                case 2:
                    hasil = a * b;
                    break;
                case 3:
                    hasil = a / b;
                    break;
                default:
                    hasil = 0;
                    break;
            }
            this.link(cOperation.SelectedIndex, a, b, hasil);
        }
    }
}
