using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosyaekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();

            string dosya_yolu = file.FileName;
            string okunanmetin = "";


            if (File.Exists(dosya_yolu))
            {
                okunanmetin = File.ReadAllText(dosya_yolu);
                txt1.Text = okunanmetin;
            }
            else
            {
                MessageBox.Show(dosya_yolu + "  dosyası bulunamadı...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            string[] metin = txt1.Text.Split(' ');
            string kelime = textBox1.Text;

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == kelime)
                {
                    sayac++;
                }
            }

            label1.Text = sayac.ToString()+"  tane bulundu!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
