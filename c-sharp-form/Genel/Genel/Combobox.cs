using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Genel
{
    public partial class Combobox : Form
    {
        public Combobox()
        {
            InitializeComponent();
        }

        List<string> sehirler = new List<string>()
        {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Kocaeli",
            "Malatya",
            "Çanakkale",
            "Bilecik",
            "Bursa",
            "Manisa",
            "Trabzon"
        };
        private void Combobox_Ornek3_Load(object sender, EventArgs e)
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


            sehirler.ForEach(asx => comboBox1.Items.Add(asx));

            //foreach (string s in sehirler) 
            //{
            //    comboBox1.Items.Add(s);
            //}
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string metin = txtEkle.Text;
            if (string.IsNullOrEmpty(metin))
            {
                lblBilgi.Text = "Yazı Alanını Boş Bırakmayınız";
                lblBilgi.ForeColor = Color.Red;
                txtEkle.Focus();
            }
            else
            {
                comboBox1.Items.Add(metin);
                txtEkle.Clear();
                lblBilgi.Text = string.Format("'{0}' Değeri Başarı İle Eklenmiştir", metin);
                lblBilgi.ForeColor = Color.Green;
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string sehir = txtDegistir.Text;
            if (comboBox1.SelectedIndex == -1)
            {
                lblBilgi.Text = "Herhangi bir Şehir Bilgisi Seçmediniz";
                lblBilgi.ForeColor = Color.Red;
            }
            else
            {
                if (string.IsNullOrEmpty(sehir))
                {
                    lblBilgi.Text = "Yazı Alanını Boş Bırakmayınız";
                    lblBilgi.ForeColor = Color.Red;
                    txtDegistir.Focus();
                }
                else
                {
                    comboBox1.Items[comboBox1.SelectedIndex] = sehir;
                    comboBox1.SelectedIndex = -1;
                    txtDegistir.Clear();
                    lblBilgi.Text = " ";
                }
            }
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                lblBilgi.Text = "Herhangi bir Şehir Bilgisi Seçmediniz";
                lblBilgi.ForeColor = Color.Red;
            }
            else
            {
                lblBilgi.Text = string.Format("Seçilen Öğe {0} - {1}", comboBox1.SelectedIndex, comboBox1.Text);
                lblBilgi.ForeColor = Color.Blue;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                lblBilgi.Text = "Herhangi bir Şehir Bilgisi Seçmediniz";
                lblBilgi.ForeColor = Color.Red;
            }
            else
            {
                string sehir = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                lblBilgi.Text = string.Format(" '{0} ' Şehri Listeden Çıkarıldı ", sehir);
                lblBilgi.ForeColor = Color.Green;
            }
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            lblBilgi.Text = "Tüm Şehirler Silindi";
            lblBilgi.ForeColor = Color.Pink;
        }
    }
}
