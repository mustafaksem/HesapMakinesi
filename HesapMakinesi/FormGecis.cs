using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    internal class FormGecis
    {
        private static Form currentForm;
        public static void ShowForm(string formName)
        {
            Form form = null;

            switch (formName)
            {
                case "Tarih hesabı":
                    form = new Form2();
                    break;
                case "Uzunluk hesabı":
                    form = new Form3();
                    break;
                case "Veri hesabı":
                    form = new VeriDonusumForm2();
                    break;
                case "Hesap Makinesi":
                    form = new Form1();
                    break;
                default:

                    MessageBox.Show("Geçerli bir form seçilmedi!");
                    return;
            }

            if (currentForm != null)
                currentForm.Close();

            currentForm = form;
            currentForm.Show();
        }
    }
}