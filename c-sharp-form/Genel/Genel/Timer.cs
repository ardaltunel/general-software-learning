using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genel
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        int saniye = 0, dakika = 0, saat = 0;
        int tur = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye >= 60)
            {
                saniye = 0;
                dakika++;
            }
            if (dakika >= 60)
            {
                dakika = 0;
                saat++;
            }
            label1.Text = string.Format("{0}:{1}:{2}", saat, dakika, saniye);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            tur++;
            string metin = string.Format("{0}.Tur : {1}", tur, label1.Text);
            ; listBox1.Items.Add(metin);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saniye = 0;
            dakika = 0;
            saat = 0;
            tur = 0;
            label1.Text = string.Format("{0}:{1}:{2}", saat, dakika, saniye);
            listBox1.Items.Clear();

        }

        private void Timer_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Normal;
            this.MaximizeBox = false;

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int x = (screenWidth - formWidth) / 2;
            int y = (screenHeight - formHeight) / 2;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
