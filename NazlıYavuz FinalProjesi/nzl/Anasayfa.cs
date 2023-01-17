using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nzl
{
    public partial class Anasayfa : System.Windows.Forms.Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÖğrenciEkleme gösterbakalım = new ÖğrenciEkleme();
            gösterbakalım.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YönetimEkle gösterbakalım = new YönetimEkle();
            gösterbakalım.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DersEkle gösterbakalım = new DersEkle();
            gösterbakalım.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ÖğrenciDersEkleme gösterbakalım = new ÖğrenciDersEkleme();
            gösterbakalım.ShowDialog();
        }

		private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ÖğrenciEkleme gösterbakalım = new ÖğrenciEkleme();
			gösterbakalım.ShowDialog();
		}

		private void ogrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ÖğrenciListele gösterbakalım = new ÖğrenciListele();
			gösterbakalım.ShowDialog();
		}

		private void ogrenciGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ÖğrenciGüncelleme gösterbakalım = new ÖğrenciGüncelleme();
			gösterbakalım.ShowDialog();
		}

		private void yonetımEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			YönetimEkle guncelleform = new YönetimEkle();
			guncelleform.ShowDialog();
		}

		private void yonetimGünecelleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			YönetimiGüncelle guncelleform = new YönetimiGüncelle();
			guncelleform.ShowDialog();
		}

		private void dersEkeleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DersEkle guncelleform = new DersEkle();
			guncelleform.ShowDialog();
		}

		private void dersGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DersleriGüncelle guncelleform = new DersleriGüncelle();
			guncelleform.ShowDialog();
		}

		private void ogrencıDersEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ÖğrenciDersEkleme guncelleform = new ÖğrenciDersEkleme();
			guncelleform.ShowDialog();
		}

		private void yonetimListeleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			YönetimListele guncelleform = new YönetimListele();
			guncelleform.ShowDialog();
		}

		private void dersListeleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DersListele guncelleform = new DersListele();
			guncelleform.ShowDialog();
		}

		private void ogrenciToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
