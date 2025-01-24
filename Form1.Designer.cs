namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            imagesListBox = new ListBox();
            favorites = new ListBox();
            addFavorites = new Button();
            pictureBox1 = new PictureBox();
            Removebutton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imagesListBox
            // 
            imagesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            imagesListBox.FormattingEnabled = true;
            imagesListBox.ItemHeight = 25;
            imagesListBox.Location = new Point(12, 12);
            imagesListBox.Name = "imagesListBox";
            imagesListBox.Size = new Size(479, 129);
            imagesListBox.TabIndex = 0;
            imagesListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // favorites
            // 
            favorites.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            favorites.FormattingEnabled = true;
            favorites.ItemHeight = 25;
            favorites.Location = new Point(12, 210);
            favorites.Name = "favorites";
            favorites.Size = new Size(479, 129);
            favorites.TabIndex = 1;
            favorites.SelectedIndexChanged += favorites_SelectedIndexChanged;
            // 
            // addFavorites
            // 
            addFavorites.Location = new Point(12, 158);
            addFavorites.Name = "addFavorites";
            addFavorites.Size = new Size(223, 34);
            addFavorites.TabIndex = 2;
            addFavorites.Text = "Add to favorites";
            addFavorites.UseVisualStyleBackColor = true;
            addFavorites.Click += addFavorites_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 375);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(479, 464);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Removebutton1
            // 
            Removebutton1.Location = new Point(278, 158);
            Removebutton1.Name = "Removebutton1";
            Removebutton1.Size = new Size(213, 34);
            Removebutton1.TabIndex = 4;
            Removebutton1.Text = "Remove from favorites";
            Removebutton1.UseVisualStyleBackColor = true;
            Removebutton1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 851);
            Controls.Add(Removebutton1);
            Controls.Add(pictureBox1);
            Controls.Add(addFavorites);
            Controls.Add(favorites);
            Controls.Add(imagesListBox);
            Name = "Form1";
            Text = "Image visualizer ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox imagesListBox;
        private ListBox favorites;
        private Button addFavorites;
        private PictureBox pictureBox1;
        private Button Removebutton1;
    }
}
