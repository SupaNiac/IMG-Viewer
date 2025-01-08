namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\windows\web\wallpaper", "*.jpg", SearchOption.AllDirectories);
            imagesListBox.Items.AddRange(arquivos);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagesListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void addFavorites_Click(object sender, EventArgs e)
        {
            favorites.Items.Add(imagesListBox.Text);
        }

        private void favorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = favorites.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
