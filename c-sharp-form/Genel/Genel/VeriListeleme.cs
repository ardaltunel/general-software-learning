using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Genel
{
    public partial class VeriListeleme : Form
    {
        internal class Calisan
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Bolum { get; set; }
            public DateTime IseBaslamaTarihi { get; set; }
            public decimal Maas { get; set; }

            public Calisan(string ad, string soyad, string bolum, DateTime iseBaslamaTarihi, decimal maas)
            {
                Ad = ad;
                Soyad = soyad;
                Bolum = bolum;
                IseBaslamaTarihi = iseBaslamaTarihi;
                Maas = maas;
            }

            public void BilgiYazdir()
            {
                Console.WriteLine($"Ad: {Ad}");
                Console.WriteLine($"Soyad: {Soyad}");
                Console.WriteLine($"Bölüm: {Bolum}");
                Console.WriteLine($"İşe Başlama Tarihi: {IseBaslamaTarihi.ToShortDateString()}");
                Console.WriteLine($"Maaş: {Maas:C}");
            }

            public int CalismaSuresi()
            {
                return DateTime.Now.Year - IseBaslamaTarihi.Year;
            }

            public void ZamYap(decimal oran)
            {
                Maas += Maas * oran / 100;
            }
        }

        List<Calisan> calisanlar = new List<Calisan>()
        {
            new Calisan("Ahmet", "Çalışkan", "Öğretmen", new DateTime(2015, 3, 1), 5000),
            new Calisan("Esma", "Güzel", "Müdür", new DateTime(2010, 5, 15), 8000),
            new Calisan("Fatih", "Aycı", "Yazılımcı", new DateTime(2018, 11, 23), 7000),
            new Calisan("Aytaç", "Kara", "Teknisyen", new DateTime(2017, 8, 5), 4000),
            new Calisan("Leyla", "Kabakçı", "İnşaat Mühendisi", new DateTime(2019, 2, 20), 6000)
        };

        public VeriListeleme()
        {
            InitializeComponent();
        }

        private void VeriListeleme_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = calisanlar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var siralaListe = calisanlar.OrderBy(x => x.Ad).ToList();
            dataGridView1.DataSource = siralaListe;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçili olan hücrenin satırının bilgisine ulaşalım
            int seciliIndex = e.RowIndex;

            if (seciliIndex != -1)
            {
                string ad = dataGridView1.Rows[seciliIndex].Cells["Ad"].Value.ToString();
                string soyad = dataGridView1.Rows[seciliIndex].Cells["Soyad"].Value.ToString();
                string bolum = dataGridView1.Rows[seciliIndex].Cells["Bolum"].Value.ToString();
                DateTime iseBaslamaTarihi = Convert.ToDateTime(dataGridView1.Rows[seciliIndex].Cells["IseBaslamaTarihi"].Value);
                decimal maas = Convert.ToDecimal(dataGridView1.Rows[seciliIndex].Cells["Maas"].Value);

                label2.Text = string.Format("{0} {1}\nBölüm: {2}\nİşe Başlama Tarihi: {3}\nMaaş: {4:C}", ad, soyad, bolum, iseBaslamaTarihi.ToShortDateString(), maas);
            }
        }
    }
}
