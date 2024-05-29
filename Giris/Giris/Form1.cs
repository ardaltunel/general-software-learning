using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            MessageBox.Show(metin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            if (string.IsNullOrEmpty(metin))
            {
                MessageBox.Show("Textbox alanını boş bırakamazsınız");
            }
            else
            {
                label1.Text = metin;
                textBox1.Clear(); //Textbox içerisindeki tüm yazıları siler
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string metin = label1.Text;
            MessageBox.Show(metin);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Windows form uygulamaları içerisinde mesaj kutusu gösterimi için MessageBox class ı içerisindeki Show() metodunu kullanılırız
            MessageBox.Show("Butona Tıklandı", "!! Uyarı !!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
            button5.Text = "Button 5' e Tıkladınız";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Green;
            button6.ForeColor = Color.Blue;
            button6.Text = "Button 6'ya Tıkladınız";
        }
    }
}
