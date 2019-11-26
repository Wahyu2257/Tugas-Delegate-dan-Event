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
    public partial class Form2 : Form
    {
        // event handler
        public delegate void KalkulasiEventHandler(int index, int a, int b);

        public event KalkulasiEventHandler SyehKalkulasi;

        public Form2()
        {
            InitializeComponent();
            cbOperasi.Items.Add("Penjumlahan");
            cbOperasi.Items.Add("Pengurangan");
            cbOperasi.Items.Add("Perkalian");
            cbOperasi.Items.Add("Pembagian");
            cbOperasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOperasi.SelectedIndex = 0;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int NilaiA = int.Parse(txtNilaiA.Text);
            int NilaiB = int.Parse(txtNilaiB.Text);

            if (cbOperasi.SelectedIndex == 0)
            {
                SyehKalkulasi(0, NilaiA, NilaiB);
            }
            else if (cbOperasi.SelectedIndex == 1)
            {
                SyehKalkulasi(1, NilaiA, NilaiB);
            }
             else if (cbOperasi.SelectedIndex == 2)
            {
                SyehKalkulasi(2, NilaiA, NilaiB);
            }
             else 
            {
                SyehKalkulasi(3, NilaiA, NilaiB);
            }
        }
    }
}
