using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genel
{
    public partial class PictureBox : Form
    {
        private void PictureBox_Load(object sender, EventArgs e)
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

        private readonly string[] imageUrls = new string[]
        {
            "https://freepngimg.com/thumb/cherry/12-2-cherry-png-hd-thumb.png",
            "https://png.pngtree.com/png-clipart/20220802/ourmid/pngtree-lemon-png-images-with-transparent-background-png-image_6095484.png",
            "https://pngfre.com/wp-content/uploads/orange-poster.png"
        };

        private readonly Random random = new Random();
        private static readonly HttpClient client = new HttpClient();

        public PictureBox()
        {
            InitializeComponent();
        }

        private async void LoadImageButton_Click(object sender, EventArgs e)
        {
            string imageUrl = imageUrls[random.Next(imageUrls.Length)];
            Image image = await FetchImageFromUrlAsync(imageUrl);

            if (image != null)
            {
                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show($"Failed to load image from {imageUrl}");
            }
        }

        private async Task<Image> FetchImageFromUrlAsync(string url)
        {
            try
            {
                byte[] imageBytes = await client.GetByteArrayAsync(url);
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching image from {url}: {ex.Message}");
                return null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
