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

namespace KitapGirdisi
{
    public partial class UyelikGirisi : Form
    {
        public UyelikGirisi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //9.gün
        {

        }

        private void btn_grs_Click(object sender, EventArgs e)
        {
            try
            {
                using (KitapTablosu.kitaplarEntities ent = new KitapTablosu.kitaplarEntities())
                {

                    var GirisMi = ent.Login.Any(s => s.YoneticiMi && s.KullaniciAdi == text_kllncı.Text && s.Sifre == text_sfr.Text);

                    if(!GirisMi)
                    {
                        MessageBox.Show("Kullanıcı Adı Yada Şifre Hatalı Girdiniz veya Yönetici giriş yetkiniz bulunmamaktadır."); 
                        return;
                    }
                    // KitapGirdisi kitapGirdisi = new KitapGirdisi();
                    // kitapGirdisi.Show();
                    MainMenu menu = new MainMenu();
                    menu.Show();

                    this.Hide();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Messaj = " + ex.Message); //kodun patlamasında bulunan hatayı gösterir
            }
        }

        private void UyelikGirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
