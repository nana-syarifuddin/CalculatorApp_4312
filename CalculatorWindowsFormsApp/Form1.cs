using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorMachine;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnHitung_Click_1(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text); // casting
            var b = Convert.ToInt32(txtNilaiB.Text); // casting
            var cal = new Calculator();

            if (cmbOperasi.SelectedItem.ToString() == "Penambahan")
            {
                txtHasil.Text = Convert.ToString(cal.Penambahan(a, b));
            }
            else if (cmbOperasi.SelectedItem.ToString() == "Pengurangan")
            {
                txtHasil.Text = Convert.ToString(cal.Pengurangan(a, b));
            }
            else if (cmbOperasi.SelectedItem.ToString() == "Perkalian")
            {
                txtHasil.Text = Convert.ToString(cal.Perkalian(a, b));
            }
            else if (cmbOperasi.SelectedItem.ToString() == "Pembagian")
            {
                txtHasil.Text = Convert.ToString(Calculator.Pembagian(a, b));
            }
            else if (cmbOperasi.SelectedItem.ToString() == "Pangkat")
            {
                txtHasil.Text = Convert.ToString(cal.Pangkat(a, b));
            }
            else if (cmbOperasi.SelectedItem.ToString() == "Module")
            {
                txtHasil.Text = Convert.ToString(Calculator.Modulo(a, b));
            }
        }
    }
}
