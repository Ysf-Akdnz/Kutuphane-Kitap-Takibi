using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapGirdisi
{
    public partial class KitapGirdisi : Form
    {
        public KitapGirdisi()
        {
            InitializeComponent();
        }
        KitapTablosu.kitaplarEntities ent = new KitapTablosu.kitaplarEntities(); //Veritabanını görmesi için
        private void KitapGirdisi_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Ekle_Click(object sender, EventArgs e) 
        {
            KitapTablosu.Kitaplar ktp = new KitapTablosu.Kitaplar();
            ktp.Kitap_adi = KpAdi.Text;
            ktp.Sayfa_Sayisi = Convert.ToInt16(SSayisi.Text);
            ktp.Cilt_No = Convert.ToInt16(CiltNo.Text);
            ktp.Turu = Tur.Text;
            ktp.Yazar = Yazar.Text;
            ktp.Basim_Tarihi = Convert.ToDateTime(BTarihi.Text);
            ent.Kitaplar.Add(ktp);
            ent.SaveChanges();
            MessageBox.Show("Kitap başarılı bir şekilde kaydedildi!");
            foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";

        }

        private void button_Sil_Click(object sender, EventArgs e) 
        {
            int id = Convert.ToInt16(KtpId.Text);

            KitapTablosu.Kitaplar ktp = ent.Kitaplar.First(f => f.Id == id);
            ent.Kitaplar.Remove(ktp);
            ent.SaveChanges();
            MessageBox.Show("Kitap başarılı bir şekilde silindi!");
            
        }

        private void KitapGirdisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            var uyelik = new UyelikGirisi();
            uyelik.Show();
        }
    }
}
