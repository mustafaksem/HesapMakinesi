using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        //    private double sayi1;
        //    private double sayi2;
        //    private string islem;
        //    double sonuc = 1;
        //    public Form1()
        //    {
        //        InitializeComponent();
        //    }

        //    public void RakamButonu_Click(object sender, EventArgs e)
        //    {
        //            Button tiklananButon = (Button)sender;
        //    string rakam = tiklananButon.Text;
        //    rtbEkran.Text += rakam;
        //        }
        //public void btnIslem_Click(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    islem = button.Text;
        //    if (!string.IsNullOrEmpty(rtbEkran.Text))
        //    {
        //        sayi1 = double.Parse(rtbEkran.Text);
        //        rtbEkran.Clear();
        //    }
        //}

        //public void btnEsittir_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(rtbEkran.Text))
        //    {
        //        sayi2 = double.Parse(rtbEkran.Text);
        //        //double sonuc = 1;
        //        switch (islem)
        //        {
        //            case "+":
        //                sonuc = sayi1 + sayi2;
        //                break;
        //            case "-":
        //                sonuc = sayi1 - sayi2;
        //                break;
        //            case "x":
        //                sonuc = sayi1 * sayi2;
        //                break;
        //            case "÷":
        //                if (sayi2 != 0)
        //                    sonuc = sayi1 / sayi2;
        //                else
        //                    rtbEkran.Clear();
        //                break;
        //            case "X^Y":
        //                for (int i = 1; i < sayi2 + 1; i++)
        //                {
        //                    sonuc *= sayi1;
        //                }
        //                break;
        //            case "%":
        //                sonuc = sayi1 * (sayi2 / 100);
        //                break;
        //            case "IxI":
        //                sonuc = MutlakDegerAlma(sayi1);
        //                break;
        //            case "mod":
        //                sonuc = sayi1 % sayi2;
        //                break;
        //            default:
        //                break;
        //        }
        //        rtbEkran.Text = sonuc.ToString();
        //    }
        //}
        //public void btnTemizle_Click(object sender, EventArgs e)
        //    {
        //        rtbEkran.Clear();
        //        sayi1 = 0;
        //        sayi2 = 0;
        //        islem = "";

        //    }

        //    public void btnDelete_Click(object sender, EventArgs e)
        //    {
        //        if (rtbEkran.Text.Length > 0)
        //        {
        //            rtbEkran.Text = rtbEkran.Text.Substring(0, rtbEkran.Text.Length - 1);
        //        }
        //    }

        //    public void btnArtıEksi_Click(object sender, EventArgs e)
        //    {
        //        if (rtbEkran.Text != "")
        //        {
        //            double sayi = double.Parse(rtbEkran.Text);
        //            sayi *= -1;
        //            rtbEkran.Text = sayi.ToString();
        //        }
        //    }

        //    public void btnOndalık_Click(object sender, EventArgs e)
        //    {
        //        if (!rtbEkran.Text.Contains("."))
        //        {
        //            rtbEkran.Text += ",";
        //        }
        //    }
        //    public double MutlakDegerAlma(double sayi)
        //    {
        //        if (sayi < 0)
        //            return -sayi;
        //        return sayi;
        //    }

        //    public void button2_MouseClick(object sender, MouseEventArgs e)
        //    {

        //    }

        //    public void btnFakt_Click(object sender, EventArgs e)
        //    {

        //        if (!string.IsNullOrEmpty(rtbEkran.Text))
        //        {
        //            sayi1 = double.Parse(rtbEkran.Text);
        //            double sonuc = Faktoriyel(sayi1);
        //            rtbEkran.Text = sonuc.ToString();
        //        }
        //    }
        //    private double Faktoriyel(double n)
        //    {
        //        if (n == 0)
        //            return 1;
        //        else
        //            return n * Faktoriyel(n - 1);
        //    }

        private List<double> sayilar = new List<double>();
        private List<string> islemler = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        public void RakamButonu_Click(object sender, EventArgs e)
        {
            Button tiklananButon = (Button)sender;
            string rakam = tiklananButon.Text;
            rtbEkran.Text += rakam;
        }

        public void btnIslem_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string islem = button.Text;

            if (!string.IsNullOrEmpty(rtbEkran.Text))
            {
                double sayi = double.Parse(rtbEkran.Text);
                sayilar.Add(sayi);
                islemler.Add(islem);
                rtbEkran.Clear();
            }
        }

        public void btnEsittir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbEkran.Text))
            {
                double sayi = double.Parse(rtbEkran.Text);
                sayilar.Add(sayi);

                double sonuc = sayilar[0];

                for (int i = 0; i < islemler.Count; i++)
                {
                    switch (islemler[i])
                    {
                        case "+":
                            sonuc += sayilar[i + 1];
                            break;
                        case "-":
                            sonuc -= sayilar[i + 1];
                            break;
                        case "x":
                            sonuc *= sayilar[i + 1];
                            break;
                        case "÷":
                            if (sayilar[i + 1] != 0)
                                sonuc /= sayilar[i + 1];
                            else
                                rtbEkran.Clear();
                            break;
                        case "X^Y":
                            sonuc = Math.Pow(sonuc, sayilar[i + 1]);
                            break;
                        case "%":
                            sonuc *= (sayilar[i + 1] / 100);
                            break;
                        case "IxI":
                            sonuc = MutlakDegerAlma(sonuc);
                            break;
                        case "mod":
                            sonuc %= sayilar[i + 1];
                            break;
                        default:
                            break;
                    }
                }

                rtbEkran.Text = sonuc.ToString();
                sayilar.Clear();
                islemler.Clear();
            }
        }

        public void btnTemizle_Click(object sender, EventArgs e)
        {
            rtbEkran.Clear();
            sayilar.Clear();
            islemler.Clear();
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            if (rtbEkran.Text.Length > 0)
            {
                rtbEkran.Text = rtbEkran.Text.Substring(0, rtbEkran.Text.Length - 1);
            }
        }

        public void btnArtıEksi_Click(object sender, EventArgs e)
        {
            if (rtbEkran.Text != "")
            {
                double sayi = double.Parse(rtbEkran.Text);
                sayi *= -1;
                rtbEkran.Text = sayi.ToString();
            }
        }

        public void btnOndalık_Click(object sender, EventArgs e)
        {
            if (!rtbEkran.Text.Contains("."))
            {
                rtbEkran.Text += ",";
            }
        }

        public double MutlakDegerAlma(double sayi)
        {
            if (sayi < 0)
                return -sayi;
            return sayi;
        }


        public void btnFakt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbEkran.Text))
            {
                double sayi = double.Parse(rtbEkran.Text);
                double sonuc = Faktoriyel(sayi);
                rtbEkran.Text = sonuc.ToString();
            }
        }

        private double Faktoriyel(double n)
        {
            if (n == 0)
                return 1;
            else
                return n * Faktoriyel(n - 1);
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    FormGecis.ShowForm(comboBox1.SelectedItem.ToString());
        //}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ComboBox'tan seçilen form adını alın
            string selectedForm = comboBox1.SelectedItem.ToString();

            // Seçilen forma geçiş yapın
            FormGecis.ShowForm(selectedForm);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
