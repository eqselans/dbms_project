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
namespace Deneme
{
	public partial class GirisFormu : Form
	{
		public GirisFormu()
		{
			InitializeComponent();
		}
		NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432; Database=Db_byteland; user ID=postgres; password=672854");

		private void btnGiris_Click(object sender, EventArgs e)
		{

			conn.Open();


			NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.\"Kullanici\"\r\n WHERE \"kullaniciAdi\"\r\n=@username AND \"kullaniciSifre\"\r\n=@password", conn);
			cmd.Parameters.AddWithValue("username", "emrhn");
			cmd.Parameters.AddWithValue("password", "672854");

			int i = Convert.ToInt32(cmd.ExecuteScalar());
			if (i > 0)
			{
				MessageBox.Show("Hoþgeldin", "Hoþgeldin", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Ana ana = new Ana();
				ana.Show();
				this.Hide();
			}
		}

		private void materialCheckbox1_CheckedChanged_1(object sender, EventArgs e)
		{
			if (txtSifre.PasswordChar == '*')
			{
				txtSifre.PasswordChar = '\0';
			}
			else
			{
				txtSifre.PasswordChar = '*';
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{

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