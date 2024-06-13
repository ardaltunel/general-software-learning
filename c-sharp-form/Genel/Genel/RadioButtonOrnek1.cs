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
    public partial class RadioButtonOrnek1 : Form
    {
        public RadioButtonOrnek1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked ) 
            {
                MessageBox.Show("1.Seçenek Seçildi");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("2.Seçenek Seçildi");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("3.Seçenek Seçildi");
            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show("4.Seçenek Seçildi");
            }
            else
            {
                MessageBox.Show("Hiçbir Seçenek Seçilmedi");
            }
        }

        private void RadioButtonOrnek1_Load(object sender, EventArgs e)
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
    }
}
