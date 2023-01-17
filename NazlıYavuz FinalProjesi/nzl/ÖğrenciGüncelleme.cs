﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace nzl
{
    public partial class ÖğrenciGüncelleme : System.Windows.Forms.Form
    {
        public ÖğrenciGüncelleme()
        {
            InitializeComponent();
        }
        context dbislem = new context();
        ogrenci veriler = new ogrenci();
        private void guncelle_Load(object sender, EventArgs e)
        {
            {
                var za = from i in dbislem.ogrenciveri
                         select i;
                dataGridView1.DataSource = za.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idal = Convert.ToInt32(textBox1.Text);
            var idsorgu = dbislem.ogrenciveri.Find(idal);
            textBox2.Text = idsorgu.AdSoyad;
            textBox3.Text = idsorgu.KayitTarih;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idal = Convert.ToInt32(textBox1.Text);
            var idsorgula = dbislem.ogrenciveri.Find(idal);
            idsorgula.AdSoyad = textBox2.Text;
            idsorgula.KayitTarih = textBox3.Text;
            idsorgula.OgrenciNo = Convert.ToInt32(textBox4.Text);
            idsorgula.DTarih =textBox5.Text;
            idsorgula.Bolum = textBox6.Text;
            dbislem.SaveChanges();
            var za = from i in dbislem.ogrenciveri
                     select i;
            dataGridView1.DataSource = za.ToList();
        
    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int idal = Convert.ToInt32(textBox1.Text);
            var idsorgula = dbislem.ogrenciveri.Find(idal);
            textBox2.Text = idsorgula.AdSoyad;
            textBox3.Text = idsorgula.KayitTarih;
            textBox4.Text = idsorgula.OgrenciNo.ToString();
            textBox5.Text = idsorgula.DTarih;
            textBox6.Text = idsorgula.Bolum;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
