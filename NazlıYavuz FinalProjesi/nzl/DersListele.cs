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
	public partial class DersListele : Form
	{
		context dbislem = new context();
		public DersListele()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var za = from i in dbislem.ogrenciveri
					 select i;
			dataGridView1.DataSource = za.ToList();
		}
	}
}
