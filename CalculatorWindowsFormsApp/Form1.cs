using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnHitung_Click_1(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text); // casting
            var b = Convert.ToInt32(txtNilaiB.Text); // casting

            if (cmbOperasi.SelectedItem.ToString() == "Penambahan")
            {
                txtHasil.Text = Convert.ToString(Penambahan(a, b));
            }
            else if (cmbOperasi.SelectedItem.ToString() == "Pengurangan")
            {
                txtHasil.Text = Convert.ToString(Pengurangan(a, b));
            }
            else if (cmbOperasi.SelectedItem.ToString() == "Perkalian")
            {
                txtHasil.Text = Convert.ToString(Perkalian(a, b));
            }
            else if (cmbOperasi.SelectedItem.ToString() == "Pembagian")
            {
                txtHasil.Text = Convert.ToString(Pembagian(a, b));
            }
        }
    }
}
