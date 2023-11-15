using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using MaterialSkin.Controls;

namespace Deneme
{
	public partial class GirisFormu : MaterialForm
	{
		public GirisFormu()
		{
			InitializeComponent();
		}
		NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=deneme; user ID=postgres; password=672854");

		private void btnGiris_Click(object sender, EventArgs e)
		{

			conn.Open();
			NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.\"Kullanici\"\r\n WHERE \"KullaniciAdi\"\r\n=@username AND \"Sifre\"\r\n=@password", conn);
			cmd.Parameters.AddWithValue("username", txtKullaniciAdi.Text);
			cmd.Parameters.AddWithValue("password", txtSifre.Text);

			int i = Convert.ToInt32(cmd.ExecuteScalar());
			if (i > 0)
			{
				MessageBox.Show("Hoþgeldin", "Hoþgeldin", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}


		}



		//private void btnListele_Click(object sender, EventArgs e)
		//{
		//	string sorgu = "SELECT * FROM public.\"Bilgisayar\"\r\n";
		//	NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, conn);
		//	DataSet ds = new DataSet();
		//	dataAdapter.Fill(ds);
		//	dataGridView1.DataSource = ds.Tables[0];
		//}

		//private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		//{
		//	Form2 form2 = new Form2();
		//	form2.Show();
		//}
	}
}