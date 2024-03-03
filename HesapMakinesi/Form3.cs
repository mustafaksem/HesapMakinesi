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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ComboBoxlariBaslat();
        }
        private string gecerliGiris = "";

        private void ComboBoxlariBaslat()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void btnRakam_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            GirisEkraniniGuncelle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txtSonuc.Text = "";
            GirisEkraniniGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            GirisEkraniniGuncelle();
        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            string birim1 = comboBox1.SelectedItem.ToString();
            string birim2 = comboBox2.SelectedItem.ToString();

            if (!double.TryParse(textBox1.Text, out double miktar))
            {
                //MessageBox.Show("Geçerli bir sayı giriniz.");
                return;
            }

            double sonuc = Donustur(miktar, birim1, birim2);
            txtSonuc.Text = sonuc.ToString();
        }

        private void GirisEkraniniGuncelle()
        {
            textBox1.Text = textBox1.Text;
        }
        private double Donustur(double miktar, string birim1, string birim2)
        {
            double metreOrani = 1;

            switch (birim1)
            {
                case "Inch":
                    miktar *= 0.0254;
                    break;
                case "Kilometre":
                    miktar *= 1000;
                    break;
                case "Santimetre":
                    miktar *= 0.01;
                    break;
                case "Mil":
                    miktar *= 1609.34;
                    break;
                case "Milimetre":
                    miktar *= 0.001;
                    break;
                default:
                    break;
            }

            switch (birim2)
            {
                case "Inch":
                    miktar /= 0.0254;
                    break;
                case "Kilometre":
                    miktar /= 1000;
                    break;
                case "Santimetre":
                    miktar /= 0.01;
                    break;
                case "Mil":
                    miktar /= 1609.34;
                    break;
                case "Milimetre":
                    miktar /= 0.001;
                    break;
                default:
                    break;
            }

            return miktar;
        }

        private void btnNokta_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
                GirisEkraniniGuncelle();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedForm = comboBox4.SelectedItem.ToString();
            FormGecis.ShowForm(selectedForm);
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

