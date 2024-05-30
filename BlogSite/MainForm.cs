using BlogSite.Context;
using BlogSite.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogSite
{
    public partial class MainForm : Form
    {
        private readonly BlogDbContext _db;
        private readonly User _user;
        private readonly string imageDirectory;

        public MainForm(BlogDbContext db, User user)
        {
            InitializeComponent();
            _db = db;
            _user = user;


            imageDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
            LoadPosts();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            string title = txtBaslik.Text;
            string content = rtxtContent.Text;
            string imagePath = pbResim.ImageLocation;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("Başlık ve içerik boş olamaz");
                return;
            }

            string savedImagePath = null;
            if (!string.IsNullOrEmpty(imagePath))
            {
                string extension = Path.GetExtension(imagePath);
                string fileName = Guid.NewGuid().ToString() + extension;
                savedImagePath = Path.Combine(imageDirectory, fileName);
                File.Copy(imagePath, savedImagePath);
            }

            var post = new Post
            {
                Title = title,
                Content = content,
                ImagePath = savedImagePath,
                UserId = _user.UserId,
                CreatedDate = DateTime.Now
            };
            _db.Posts.Add(post);
            _db.SaveChanges();
            LoadPosts();
            //MessageBox.Show("Eklendi");


        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Resim Seç"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbResim.ImageLocation = openFileDialog.FileName;
            }

        }

        private void flpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadPosts()
        {

            var posts = _db.Posts.Include(x => x.User).OrderByDescending(x => x.CreatedDate).ToList();

            foreach (var post in posts)
            {
                Panel pnlItem = new Panel
                {
                    Size = new Size(480, 120),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };
                PictureBox pbPictureToShow = new PictureBox
                {
                    Location = new Point(10, 10),
                    Size = new Size(100, 100),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                pbPictureToShow.Image = Image.FromFile(post.ImagePath);
                Label lblTitle = new Label
                {
                    Text = post.Title,
                    Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold),
                    Location = new Point(120, 10),
                    AutoSize = true
                };
                Label lblContent = new Label
                {
                    Text = post.Content,
                    Location = new Point(120, 40),
                    AutoSize = true
                };
                Label lblUsername = new Label
                {
                    Text = "Ekleyen: " + post.User.UserName,
                    Location = new Point(120, 90),
                    AutoSize = true

                };
                pnlItem.Controls.Add(pbPictureToShow);
                pnlItem.Controls.Add(lblTitle);
                pnlItem.Controls.Add(lblContent);
                pnlItem.Controls.Add(lblUsername);


                flpPanel.AutoScroll = true;
                flpPanel.Controls.Add(pnlItem);



            }
        }
    }
}
