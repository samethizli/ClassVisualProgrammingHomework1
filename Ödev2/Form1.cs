using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yazıyaçevir();

        }

        private void yazıyaçevir()
        {
            int sayi = int.Parse(textBox1.Text);
            


            string yuzler_b = "";


            switch ((sayi % 1000) / 100)
            {
                case 1:
                    yuzler_b = "YÜZ";
                    break;
                case 2:
                    yuzler_b = "İKİYÜZ";
                    break;
                case 3:
                    yuzler_b = "ÜÇYÜZ";
                    break;
                case 4:
                    yuzler_b = "DÖRTYÜZ";
                    break;
                case 5:
                    yuzler_b = "BEŞYÜZ";
                    break;
                case 6:
                    yuzler_b = "ALTIYÜZ";
                    break;
                case 7:
                    yuzler_b = "YEDİYÜZ";
                    break;
                case 8:
                    yuzler_b = "SEKİZYÜZ";
                    break;
                case 9:
                    yuzler_b = "DOKUZYÜZ";
                    break;
                case 10:
                    yuzler_b = "BİN";
                    break;
            }


            string onlar_b = "";


            switch ((sayi % 100) / 10)
            {
                case 1:
                    onlar_b = "ON";
                    break;
                case 2:
                    onlar_b = "YİRMİ";
                    break;
                case 3:
                    onlar_b = "OTUZ";
                    break;
                case 4:
                    onlar_b = "KIRK";
                    break;
                case 5:
                    onlar_b = "ELLİ";
                    break;
                case 6:
                    onlar_b = "ALTMIŞ";
                    break;
                case 7:
                    onlar_b = "YETMİŞ";
                    break;
                case 8:
                    onlar_b = "SEKSEN";
                    break;
                case 9:
                    onlar_b = "DOKSAN";
                    break;
                case 10:
                    onlar_b = "YÜZ";
                    break;

            }
            string birler_b = "";

            switch (sayi % 10)
            {
                case 1:
                    birler_b = "BİR";
                    break;
                case 2:
                    birler_b = "İKİ";
                    break;
                case 3:
                    birler_b = "ÜÇ";
                    break;
                case 4:
                    birler_b = "DÖRT";
                    break;
                case 5:
                    birler_b = "BEŞ";
                    break;
                case 6:
                    birler_b = "ALTI";
                    break;
                case 7:
                    birler_b = "YEDİ";
                    break;
                case 8:
                    birler_b = "SEKİZ";
                    break;
                case 9:
                    birler_b = "DOKUZ";
                    break;
                case 10:
                    birler_b = "ON";
                    break;

            }
           
            label4.Text="Sonuç: " +yuzler_b+onlar_b + birler_b;

        }

        private void button1_Click(object sender, EventArgs e)
        {
               topla();
        }

        private void topla()
        {
            int toplam;
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);

            toplam = x + y;
            label4.Text = "Sonuç: " + toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
               çarp();
        }

        private void çarp()
        {
            int toplam;
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);

            toplam = x * y;
            label4.Text = "Sonuç: " + toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            üsal();
        }

        private void üsal()
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);

            double uslusayı = Math.Pow(x,y);

            label4.Text = "Sonuç: " + uslusayı.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            faktoriyel();
        }

        private void faktoriyel()
        {
            int x = Convert.ToInt32(textBox1.Text);
            int faktoriyel = 1;
            for (int i = 1; i <= x; i++)
            {
                faktoriyel *= i;
            }
            label4.Text = "Sonuç: " + faktoriyel.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rastgelesayı();
        }
        
        private void rastgelesayı()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100);
            label4.Text = "Sonuç: " + sayi.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4;
            çizgiçiz(0,0,2000,1085);
        }

        private void çizgiçiz(int s1, int s2, int s3, int s4)
        {
            Graphics grafik = CreateGraphics();
            Pen kalem = new Pen(Color.Red, 5);
            grafik.DrawLine(kalem, s1, s2, s3, s4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(100);
            }
           topla(sayilar);

        }

        private void topla(int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            label4.Text = "Sonuç: " + toplam.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            formurenklendir();
        }

        private void formurenklendir()
        {
            Random rnd = new Random();
            int x = rnd.Next(255);
            int  y = rnd.Next(255);
            int  z = rnd.Next(255);

            this.BackColor = Color.FromArgb(x, y, z);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            formurenklendir(this.BackColor = Color.Orange);
        }

        private void formurenklendir(Color renk)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int taban;
            int üs;
            taban = Convert.ToInt32(textBox1.Text);
            üs = Convert.ToInt32(textBox2.Text);

            int yenisayi = Üsal2(taban, üs);
            label4.Text = "Sonuç: " + yenisayi.ToString();

        }

        private int Üsal2(int taban, int üs)
        {
            int yenisayi = 1;
            for (int i = 1; i <= üs; i++)
            {
                yenisayi *= taban;
            }
            return yenisayi;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
          
          

        }

   
      
    }
}

