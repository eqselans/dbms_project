using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
	public partial class Ana : Form
	{
		public Ana()
		{
			InitializeComponent();
		}
		NpgsqlConnection conn = new NpgsqlConnection(" SERVER - DATABASE BAGLANTISI SAGLANDI");


		private void Ana_Load(object sender, EventArgs e)
		{

		}

		private void btnUrun_Click(object sender, EventArgs e)
		{
			conn.Open();

			string sorgu = "SELECT\r\n \"Ürünler\".\"ÜrünID\" , \"Ürünler\".\"ÜrünAdı\" AS \"Ürün Adı\",\r\n   " +
				" \"Kategoriler\".\"KategoriAdı\" AS \"Kategori Adı\",\r\n    \"Ürünler\".\"Fiyat\",\r\n    " +
				"\"Ürünler\".\"StokMiktarı\"\r\nFROM\r\n    \"Ürünler\"\r\nJOIN\r\n    \"Kategoriler\" ON \"Ürünler\".\"KategoriID\" = " +
				"\"Kategoriler\".\"KategoriID\" ORDER BY \"ÜrünID\" ASC;";
			NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, conn);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];

			conn.Close();
		}

		private void btnKategoriEkle_Click(object sender, EventArgs e)
		{
			conn.Open();
			textBox5.Enabled = true;

			if (textBox5.Text == String.Empty)
			{
				MessageBox.Show("Lütfen tüm kutuları doldurun", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			}
			else
			{
				NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO \"Kategoiler\"(\"ÜrünAdı\")\r\nVALUES (@p1);", conn);
				command1.Parameters.AddWithValue("@p1", textBox5.Text);
				command1.ExecuteNonQuery();
			}

			conn.Close();
		}

		private void btnUrunEkle_Click(object sender, EventArgs e)
		{	
			conn.Open();
			textBox1.Enabled = true;
			textBox2.Enabled = true;
			textBox3.Enabled = true;
			textBox4.Enabled = true;

			if (textBox1.Text == String.Empty || textBox2.Text == String.Empty || textBox3.Text == String.Empty || textBox4.Text == String.Empty)
			{
				MessageBox.Show("Lütfen tüm kutuları doldurun", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			}
			else
			{
				NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO \"Ürünler\"(\"ÜrünAdı\",\"KategoriID\",\"Fiyat\",\"StokMiktarı\")\r\nVALUES (@p1, @p2, @p3, @p4);", conn);
				command1.Parameters.AddWithValue("@p1", textBox1.Text);	
				command1.Parameters.AddWithValue("@p2", Convert.ToInt16(textBox2.Text));
				command1.Parameters.AddWithValue("@p3", int.Parse(textBox3.Text));
				command1.Parameters.AddWithValue("@p4", Convert.ToInt16(textBox4.Text));
				command1.ExecuteNonQuery();

			}
			conn.Close();

		}

		private void btnKategoriGoster_Click(object sender, EventArgs e)
		{
			conn.Open();
			string sorgu = "SELECT * FROM public.\"Kategoriler\"\r\nORDER BY \"KategoriID\" ASC ";
			NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, conn);
			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			conn.Close();
		}

		private void btnMusteriGoster_Click(object sender, EventArgs e)
		{
			conn.Open();
			string sorgu = "SELECT \"kişi\".ad, \"kişi\".soyad, \"kişi\".email, \"Müşteriler\".telefon\r\nFROM public.\"kişi\"\r\nJOIN public.\"Müşteriler\" ON \"kişi\".\"kişi_id\" = \"Müşteriler\".\"kişi_id\"";
			NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(sorgu, conn);
			DataSet dataSet = new DataSet();
			npgsqlDataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];
			conn.Close();
		}

		private void btnMusteriEkle_Click(object sender, EventArgs e)
		{
			txtMüsteriAd.Enabled = true;
			txtMüsteriSoyad.Enabled = true;
			txtMusteriMail.Enabled = true;
			txtMusteriTel.Enabled = true;
			conn.Open();

			if (txtMüsteriAd.Text == String.Empty || txtMüsteriSoyad.Text == String.Empty || txtMusteriMail.Text == String.Empty || txtMusteriTel.Text == String.Empty)
			{
				MessageBox.Show("Lütfen tüm kutuları doldurun", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					NpgsqlCommand command1 = new NpgsqlCommand("INSERT INTO public.\"kişi\" (ad, soyad, email) VALUES (@p1, @p2, @p3) RETURNING \"kişi_id\";", conn);
					command1.Parameters.AddWithValue("@p1", txtMüsteriAd.Text);
					command1.Parameters.AddWithValue("@p2", txtMüsteriSoyad.Text);
					command1.Parameters.AddWithValue("@p3", txtMusteriMail.Text);

					var kişiId = command1.ExecuteScalar();

					NpgsqlCommand command2 = new NpgsqlCommand("INSERT INTO public.\"Müşteriler\" (telefon, \"kişi_id\") VALUES (@p4, @p5);", conn);
					command2.Parameters.AddWithValue("@p4", txtMusteriTel.Text);
					command2.Parameters.AddWithValue("@p5", kişiId);

					// İkinci sorguyu çalıştır
					command2.ExecuteNonQuery();
				}
				catch (PostgresException ex)
				{
					MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
				}
			}
			conn.Close();

		}

		private int selectedRowIndex = -1;

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				selectedRowIndex = e.RowIndex;

				// Seçilen satırdaki verileri TextBox'lara aktar
				textBox1.Text = dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString();
				textBox2.Text = dataGridView1.Rows[selectedRowIndex].Cells[2].Value.ToString();
				textBox3.Text = dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString();
				textBox4.Text = dataGridView1.Rows[selectedRowIndex].Cells[4].Value.ToString();
			}
		}

		private void btnUrunGuncelle_Click(object sender, EventArgs e)
		{
			if (selectedRowIndex >= 0)
			{
				conn.Open();

				// Seçilen satırdaki ÜrünID değerini al
				int urunID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

				// Güncelleme sorgusu
				NpgsqlCommand npgsqlCommand = new NpgsqlCommand("UPDATE public.\"Ürünler\"\r\nSET\r\n    \"ÜrünAdı\" = @p1,\r\n    \"Fiyat\" = @p2,\r\n    \"StokMiktarı\" = @p3\r\nWHERE \"ÜrünID\" = @p4", conn);

				npgsqlCommand.Parameters.AddWithValue("@p1", textBox1.Text);
				npgsqlCommand.Parameters.AddWithValue("@p2", int.Parse(textBox3.Text));
				npgsqlCommand.Parameters.AddWithValue("@p3", Convert.ToInt32(textBox4.Text));
				npgsqlCommand.Parameters.AddWithValue("@p4", urunID);

				npgsqlCommand.ExecuteNonQuery();

				conn.Close();

				// Güncelleme işlemi tamamlandığında TextBox'ları temizle
				ClearTextBoxes();
			}
		}

		private void ClearTextBoxes()
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			selectedRowIndex = -1;
		}

		private void Ana_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnUrunSil_Click(object sender, EventArgs e)
		{
			if (selectedRowIndex >= 0)
			{
				DialogResult result = MessageBox.Show("Seçilen satırı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					conn.Open();

					// Seçilen satırdaki ÜrünID değerini al
					int urunID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

					// Silme sorgusu
					NpgsqlCommand npgsqlCommand = new NpgsqlCommand("DELETE FROM public.\"Ürünler\" WHERE \"ÜrünID\" = @p1", conn);
					npgsqlCommand.Parameters.AddWithValue("@p1", urunID);

					npgsqlCommand.ExecuteNonQuery();

					conn.Close();

					btnUrun_Click(sender, e);

					MessageBox.Show("Seçilen satır başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void txtAra_TextChanged(object sender, EventArgs e)
		{
			conn.Open();
			NpgsqlCommand npgsqlCommand = new NpgsqlCommand("SELECT * FROM \"Ürünler\" WHERE LOWER(\"ÜrünAdı\") LIKE LOWER(@p1) ORDER BY \"ÜrünID\" ASC", conn);
			npgsqlCommand.Parameters.AddWithValue("@p1", txtAra.Text + "%");

			NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter();
			dataAdapter.SelectCommand = npgsqlCommand;

			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			conn.Close();
		}

		private void txtAra_Enter(object sender, EventArgs e)
		{
			if (txtAra.Text == "Ürün Adıyla Ara")
			{
				txtAra.Text = "";
			}
		}

		private void txtAra_Leave(object sender, EventArgs e)
		{
            if (txtAra.Text == "")
            {
				txtAra.Text = "Ürün Adıyla Ara";

			}
        }
	}

}
