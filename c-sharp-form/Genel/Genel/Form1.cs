using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

            button1.TabStop = false;
            button2.TabStop = false;
            button3.TabStop = false;
            button4.TabStop = false;
            button5.TabStop = false;
            button6.TabStop = false;
            button7.TabStop = false;
            button8.TabStop = false;
            button9.TabStop = false;
            button10.TabStop = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBoxOrnek1 form=new CheckBoxOrnek1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            RadioButtonOrnek1 form = new RadioButtonOrnek1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RadioButtonOrnek2 form = new RadioButtonOrnek2();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListBox form =new ListBox();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Combobox form = new Combobox();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Timer form = new Timer();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProgressBar form = new ProgressBar();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PictureBox form = new PictureBox();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Toplama form = new Toplama();
            form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VeriListeleme form = new VeriListeleme();
            form.Show();
        }
    }
}
