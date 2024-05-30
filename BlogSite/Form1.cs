using BlogSite.Context;
using BlogSite.Entities;

namespace BlogSite
{
    public partial class Form1 : Form
    {
        private readonly BlogDbContext _context;
        public Form1(BlogDbContext context)
        {
            InitializeComponent();
            _context = context;

        }

        private void lnkLblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            var user = _context.Users.FirstOrDefault(x => x.UserName == kullaniciAdi && x.Password == sifre);
            if (user != null)
            {
                MainForm mainForm = new MainForm(_context, user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                lblErrorMessage.Text = "Kullanýcý adý veya þifre hatalý";
            }










        }
    }
}
