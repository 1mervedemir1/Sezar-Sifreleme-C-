using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtAnahtarSayi.Select();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtAnahtarSayi.Text != "" && txtYaziSifre.Text != "")
            {
                try
                {
                    Sezar_sifreleme sezar = new Sezar_sifreleme(byte.Parse(txtAnahtarSayi.Text), txtYaziSifre.Text);
                    txtSifrelenenYazi.Text = sezar.Sifrele();
                }
                catch
                {
                    MessageBox.Show("Anahtar sayı 0-255 aralığında olmalıdır");
                }
            }
            else
            {
                MessageBox.Show("Boş bıraktınız");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtAnahtarSayi.Clear();
            txtYaziSifre.Clear();
            txtSifrelenenYazi.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtAnahtarSayi.Text != "" && txtYaziSifre.Text != "")
            {
                try
                {
                    Sezar_sifreleme sezar1 = new Sezar_sifreleme(byte.Parse(txtAnahtarSayi.Text), txtSifrelenenYazi.Text);
                    txtDesifreYazi.Text = sezar1.DesifreEt();
                }
                catch
                {
                    MessageBox.Show("Anahtar sayı 0-255 aralığında olmalıdır");
                }
            }
            else
            {
                MessageBox.Show("Boş bıraktınız");
            }
        }
        private void Temizle_Click(object sender, EventArgs e)
        {
           txtDesifreYazi.Clear();
        }
    }
}
