using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        void FrmCalculator_Hitung(int index, int a, int b)
        {
            var operasi = new Hitung();

            if(index == 0)
            {
                lsthasil.Items.Add(string.Format("Hasil Penjumlahan : {0} + {1} = {2}", a, b, operasi.Jumlahkan(a, b)));
            }
            else if(index == 1)
            {
                lsthasil.Items.Add(string.Format("Hasil Pengurangan : {0} - {1} = {2}", a, b, operasi.Kurangkan(a, b)));
            }
            else if (index == 2)
            {
                lsthasil.Items.Add(string.Format("Hasil Perkalian : {0} * {1} = {2}", a, b, operasi.Kalikan(a, b)));
            }
            else
            {
                lsthasil.Items.Add(string.Format("Hasil Pembagian : {0} / {1} = {2}", a, b, operasi.Bagikan(a, b)));
            }

        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();

            myForm.SyehKalkulasi += FrmCalculator_Hitung;
            myForm.ShowDialog();
        }

        private void lsthasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
