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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void kitapGirdisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜyelikKaydı kaydol = new ÜyelikKaydı() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            KitapGirdisi kitapGirdisi = new KitapGirdisi() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(kitapGirdisi);
            kitapGirdisi.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            var uyelik = new UyelikGirisi();
            uyelik.Show();
        }

        private void persoelKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapGirdisi kitapGirdisi = new KitapGirdisi() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÜyelikKaydı kaydol = new ÜyelikKaydı() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Clear();
            this.pContainer.Controls.Add(kaydol);
            kaydol.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyelikGirisi uyelik = new UyelikGirisi();
            uyelik.Show();

            this.Hide();
        }
    }
}
