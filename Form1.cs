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

            //Ler arquivo favorito
            string path = ObterNomeArquivoConfiguracao();

            if (File.Exists(path))
            {

                var reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                    string arquivo = reader.ReadLine();
                    favorites.Items.Add(arquivo);
                }
                reader.Close();
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagesListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private string ObterNomeArquivoConfiguracao()
        {
            var pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "imagensConfig.txt";
            string path = Path.Combine(pasta, arquivo);
            return path;
        }
        private void addFavorites_Click(object sender, EventArgs e)
        {
            favorites.Items.Add(imagesListBox.Text);
            GravarConfig();
        }

        private void GravarConfig()
        {
            string path = ObterNomeArquivoConfiguracao();
            var writer = new StreamWriter(path);
            foreach (string arquivo in favorites.Items)
            {
                writer.WriteLine(arquivo);

            }
            writer.Close();
        }

        private void favorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = favorites.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (favorites.SelectedItem != null)
            {
                string ItemSelecionado = favorites.SelectedItem.ToString();
                favorites.Items.Remove(ItemSelecionado);
                GravarConfig();
            }
        }
    }
}
