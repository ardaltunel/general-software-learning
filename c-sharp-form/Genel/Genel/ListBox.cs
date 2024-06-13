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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string metin = txtEkle.Text;
            if (string.IsNullOrEmpty(metin))
            {
                label1.Text = "Metin Alanı Boş Bırakılamaz";
                label1.ForeColor= Color.Red;
                txtEkle.Focus();
            }
            else
            {
                //Listbox içerisine yeni bir öğe ekleme
                //listboxadi.Items.Add(<deger>);
                listBox1.Items.Add(metin);
                txtEkle.Clear();
                label1.Text = "'" + metin + "' değeri başarı ile eklenmiştir";
                label1.ForeColor = Color.Green;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //Seçili olan listbox itemlerının index numarasına ulaşmak için SelectedIndex property sini kullanırız

            int seciliIndex = listBox1.SelectedIndex;

            if (seciliIndex == -1 )
            {
                label1.Text = "Hiçbir Eleman Seçmediniz";
                label1.ForeColor = Color.Red;
            }
            else 
            {
                txtDuzenle.Text = listBox1.Items[seciliIndex].ToString();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int seciliIndex=listBox1.SelectedIndex;
            string metin=txtDuzenle.Text;
            if (string.IsNullOrEmpty(metin))
            {
                label1.Text = "Metin Alanı Boş Bırakılamaz";
                label1.ForeColor = Color.Red;
                txtDuzenle.Focus();
            }
            else
            {
                listBox1.Items[seciliIndex] = metin;
                label1.Text = "Güncelleme İŞlemi Başarılı";
                label1.ForeColor = Color.Green;
                txtDuzenle.Clear();
            }

        }

        private void ListBox_Load(object sender, EventArgs e)
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
