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
    public partial class Toplama : Form
    {
        public Toplama()
        {
            InitializeComponent();
        }

        private void Toplama_Load(object sender, EventArgs e)
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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0;
            bool sayi1Kontrol, sayi2Kontrol;
            if (string.IsNullOrEmpty(txtSayi1.Text))
            {
                lblSonuc.Text = "1.Sayı Alanını Doldurunuz";
                lblSonuc.ForeColor = Color.Red;
                txtSayi1.Focus(); // belirtilen textbox ın seçili hale getirip , vurguluyor
            }
            else if (string.IsNullOrEmpty(txtSayi2.Text))
            {
                lblSonuc.Text = "2.Sayı Alanını Doldurunuz";
                lblSonuc.ForeColor = Color.Red;
                txtSayi2.Focus();
            }
            else
            {
                try
                {
                    sayi1 = double.Parse(txtSayi1.Text);
                    sayi1Kontrol = true;

                }
                catch
                {
                    lblSonuc.Text = "1.Sayı Alanına Doğru Bir Değer Giriniz";
                    lblSonuc.ForeColor = Color.Red;
                    txtSayi1.Clear();
                    txtSayi1.Focus();
                    sayi1Kontrol = false;


                }

                try
                {
                    sayi2 = double.Parse(txtSayi2.Text);
                    sayi2Kontrol = true;

                }
                catch
                {
                    lblSonuc.Text = "2.Sayı Alanına Doğru Bir Değer Giriniz";
                    lblSonuc.ForeColor = Color.Red;
                    txtSayi2.Clear();
                    txtSayi2.Focus();
                    sayi2Kontrol = false;
                }

                if (sayi1Kontrol && sayi2Kontrol)
                {
                    lblSonuc.Text = "Sonuç = " + (sayi1 + sayi2);
                    lblSonuc.ForeColor = Color.Green;
                }

            }
        }
    }
}