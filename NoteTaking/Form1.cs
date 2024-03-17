using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Başlık", typeof(string));
            table.Columns.Add("Mesajlar", typeof(string));
            dataGridView1.DataSource= table;

            dataGridView1.Columns["Mesajlar"].Visible = false;
            dataGridView1.Columns["Başlık"].Width = 221;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Başlık ve Mesaj alanları boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            table.Rows.Add(txtTitle.Text,txtMessage.Text);
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = dataGridView1.CurrentCell;

            if (currentCell != null)
            {
                int index = currentCell.RowIndex;

                if (index > -1 && index < table.Rows.Count)
                {
                    txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                    txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
                }               
            }
            else
            {
                MessageBox.Show("Lütfen bir not seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = dataGridView1.CurrentCell;

            if (currentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
            else
            {
                MessageBox.Show("Lütfen bir not seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
