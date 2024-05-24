using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dateTimePickerBaslangic.Value;
            DateTime bitisTarihi = dateTimePickerBitis.Value;

            // Gün farkı
            int gunFarki = (int)(bitisTarihi - baslangicTarihi).TotalDays;
            lblGun.Text = gunFarki.ToString() + " gün";

            // Hafta farkı
            int haftaFarki = gunFarki / 7;
            lblHafta.Text = haftaFarki.ToString() + " hafta";

            // Ay farkı
            int ayFarki = (bitisTarihi.Month - baslangicTarihi.Month) + 12 * (bitisTarihi.Year - baslangicTarihi.Year);
            lblAy.Text = ayFarki.ToString() + " ay";

            // Yıl farkı
            int yilFarki = bitisTarihi.Year - baslangicTarihi.Year;
            lblYil.Text = yilFarki.ToString() + " yıl";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormGecis.ShowForm(comboBox1.SelectedItem.ToString());
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
