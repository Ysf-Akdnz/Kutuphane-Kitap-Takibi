using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using KitapGirdisi.KitapTablosu;

namespace KitapGirdisi
{
    public partial class ÜyelikKaydı : Form
    {
        public ÜyelikKaydı()
        {
            InitializeComponent();
        }

        public void kaydol(TextBox kullaniciadi, TextBox sifre, TextBox sifretekrar, GroupBox grup)
        {
            if (sifre.Text == sifretekrar.Text)
            {
                KitapTablosu.kitaplarEntities ent = new KitapTablosu.kitaplarEntities();
                var kayit = new Login { KullaniciAdi = kullaniciadi.Text, Sifre = sifre.Text, YoneticiMi = true };

                ent.Login.Add(kayit);
                ent.SaveChanges();

                MessageBox.Show("Üye Kaydoldu!!");

                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Hata");
            }
        }
        
        private void btn_kydt_Click(object sender, EventArgs e)
        {
            kaydol(text_kllncı, text_sfr, textsfrtkrr, Grup);
        }
        private void ÜyelikKaydı_Load(object sender, EventArgs e) 
        {

        }

        private void Grup_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
