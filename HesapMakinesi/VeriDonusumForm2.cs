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
    public partial class VeriDonusumForm2 : Form
    {
        private string gecerliGiris = "";

        public VeriDonusumForm2()
        {
            InitializeComponent();
            ComboBoxlariBaslat();
        }

        private void ComboBoxlariBaslat()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void btnRakam_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtGiris.Text += btn.Text;
            GirisEkraniniGuncelle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtGiris.Text = "";
            txtSonuc.Text = "";
            GirisEkraniniGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text.Length > 0)
                txtGiris.Text = txtGiris.Text.Substring(0, txtGiris.Text.Length - 1);
            GirisEkraniniGuncelle();
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            string birim1 = comboBox1.SelectedItem.ToString();
            string birim2 = comboBox2.SelectedItem.ToString();

            if (!double.TryParse(txtGiris.Text, out double miktar))
            {
                MessageBox.Show("Geçerli bir sayı giriniz.");
                return;
            }

            double sonuc = Donustur(miktar, birim1, birim2);
            txtSonuc.Text = sonuc.ToString();
        }

        private void GirisEkraniniGuncelle()
        {
            txtGiris.Text = txtGiris.Text;
        }

        private double Donustur(double miktar, string birim1, string birim2)
        {
            double byteOrani = 1;
            double kilobyteOrani = 1024;
            double megabyteOrani = Math.Pow(1024, 2);
            double gigabyteOrani = Math.Pow(1024, 3);
            double terabyteOrani = Math.Pow(1024, 4);

            double byteDeger = miktar;
            switch (birim1)
            {
                case "Kilobyte":
                    byteDeger = miktar * kilobyteOrani;
                    break;
                case "Megabyte":
                    byteDeger = miktar * megabyteOrani;
                    break;
                case "Gigabyte":
                    byteDeger = miktar * gigabyteOrani;
                    break;
                case "Terabyte":
                    byteDeger = miktar * terabyteOrani;
                    break;
                default:
                    break;
            }

            double sonuc = 0;

            switch (birim2)
            {
                case "Byte":
                    sonuc = byteDeger / byteOrani;
                    break;
                case "Kilobyte":
                    sonuc = byteDeger / kilobyteOrani;
                    break;
                case "Megabyte":
                    sonuc = byteDeger / megabyteOrani;
                    break;
                case "Gigabyte":
                    sonuc = byteDeger / gigabyteOrani;
                    break;
                case "Terabyte":
                    sonuc = byteDeger / terabyteOrani;
                    break;
                default:
                    break;
            }
            return sonuc;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedForm = comboBox3.SelectedItem.ToString();
            FormGecis.ShowForm(selectedForm);
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
  

