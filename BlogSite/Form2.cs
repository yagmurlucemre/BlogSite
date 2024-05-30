using BlogSite.Context;
using BlogSite.Entities;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        BlogDbContext _db = new BlogDbContext();

        private void txtKullaniciAdi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullaniciAdi2.Text;
            string sifre = txtSifre2.Text;
            string sifreTekrari = txtSifreTekrari.Text;

            if (kullanici == null || kullanici == "")
            {
                label4.Text = "Lütfen bu alanı doldurunuz !";
            }
            if (sifre == null || sifre == "")
            {
                label4.Text = "Lütfen bu alanı doldurunuz !";
            }
            if (sifre != sifreTekrari)
            {
                label4.Text = "Şifreler eş değil.Lütfen kontrol ediniz !";
            }
            var username = _db.Users.FirstOrDefault(a => a.UserName == txtKullaniciAdi2.Text);
            if (username != null)
            {
                label4.Text = "Bu kullanıcı önceden mevcut.Lütfen başka bir kullanıcı adı seçiniz !";
            }
            User user = new User()
            {
                UserName = txtKullaniciAdi2.Text,
                Password = txtSifre2.Text
                
            };
            _db.Users.Add(user);
            _db.SaveChanges();
            label4.Text = "Kullanıcı kaydı başarılı";


        }
    }
}
