namespace Deneme
{
	partial class Ana
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana));
			btnUrun = new Button();
			pictureBox1 = new PictureBox();
			label4 = new Label();
			dataGridView1 = new DataGridView();
			btnKategoriEkle = new Button();
			txtAra = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			btnUrunEkle = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label5 = new Label();
			btnKategoriGoster = new Button();
			textBox5 = new TextBox();
			label6 = new Label();
			btnMusteriGoster = new Button();
			btnMusteriEkle = new Button();
			txtMüsteriAd = new TextBox();
			txtMüsteriSoyad = new TextBox();
			txtMusteriMail = new TextBox();
			txtMusteriTel = new TextBox();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			btnUrunGuncelle = new Button();
			btnUrunSil = new Button();
			textBox1 = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// btnUrun
			// 
			btnUrun.Location = new Point(12, 448);
			btnUrun.Name = "btnUrun";
			btnUrun.Size = new Size(242, 49);
			btnUrun.TabIndex = 0;
			btnUrun.Text = "Ürünlerin Gösterimi";
			btnUrun.UseVisualStyleBackColor = true;
			btnUrun.Click += btnUrun_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(11, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(509, 420);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = SystemColors.AppWorkspace;
			label4.Location = new Point(12, 757);
			label4.Name = "label4";
			label4.Size = new Size(224, 25);
			label4.TabIndex = 4;
			label4.Text = "Bu bir EA Yazılım ürünüdür.";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(580, 21);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.RowTemplate.Height = 33;
			dataGridView1.Size = new Size(969, 383);
			dataGridView1.TabIndex = 5;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// btnKategoriEkle
			// 
			btnKategoriEkle.Location = new Point(283, 503);
			btnKategoriEkle.Name = "btnKategoriEkle";
			btnKategoriEkle.Size = new Size(237, 53);
			btnKategoriEkle.TabIndex = 6;
			btnKategoriEkle.Text = "Kategori Ekle";
			btnKategoriEkle.UseVisualStyleBackColor = true;
			btnKategoriEkle.Click += btnKategoriEkle_Click;
			// 
			// txtAra
			// 
			txtAra.Location = new Point(12, 688);
			txtAra.Name = "txtAra";
			txtAra.Size = new Size(508, 31);
			txtAra.TabIndex = 7;
			txtAra.Text = "Ürün Adıyla Ara";
			txtAra.TextAlign = HorizontalAlignment.Center;
			txtAra.TextChanged += txtAra_TextChanged;
			txtAra.Enter += txtAra_Enter;
			txtAra.Leave += txtAra_Leave;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(921, 448);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(150, 31);
			textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(1077, 448);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(150, 31);
			textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(1233, 448);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(150, 31);
			textBox4.TabIndex = 7;
			// 
			// btnUrunEkle
			// 
			btnUrunEkle.Location = new Point(12, 503);
			btnUrunEkle.Name = "btnUrunEkle";
			btnUrunEkle.Size = new Size(242, 53);
			btnUrunEkle.TabIndex = 8;
			btnUrunEkle.Text = "Ürün Ekle";
			btnUrunEkle.UseVisualStyleBackColor = true;
			btnUrunEkle.Click += btnUrunEkle_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(765, 412);
			label1.Name = "label1";
			label1.Size = new Size(82, 25);
			label1.TabIndex = 9;
			label1.Text = "Ürün Adı";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(921, 412);
			label2.Name = "label2";
			label2.Size = new Size(101, 25);
			label2.TabIndex = 9;
			label2.Text = "Kategori ID";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(1077, 412);
			label3.Name = "label3";
			label3.Size = new Size(96, 25);
			label3.TabIndex = 9;
			label3.Text = "Ürün Fiyatı";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(1233, 412);
			label5.Name = "label5";
			label5.Size = new Size(149, 25);
			label5.TabIndex = 9;
			label5.Text = "Ürün Stok Miktarı";
			// 
			// btnKategoriGoster
			// 
			btnKategoriGoster.Location = new Point(283, 448);
			btnKategoriGoster.Name = "btnKategoriGoster";
			btnKategoriGoster.Size = new Size(237, 49);
			btnKategoriGoster.TabIndex = 6;
			btnKategoriGoster.Text = "Kategori Gösterimi";
			btnKategoriGoster.UseVisualStyleBackColor = true;
			btnKategoriGoster.Click += btnKategoriGoster_Click;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(765, 528);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(150, 31);
			textBox5.TabIndex = 7;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(765, 492);
			label6.Name = "label6";
			label6.Size = new Size(110, 25);
			label6.TabIndex = 9;
			label6.Text = "Kategori Adı";
			// 
			// btnMusteriGoster
			// 
			btnMusteriGoster.Location = new Point(283, 562);
			btnMusteriGoster.Name = "btnMusteriGoster";
			btnMusteriGoster.Size = new Size(237, 49);
			btnMusteriGoster.TabIndex = 0;
			btnMusteriGoster.Text = "Müşterilerin Gösterimi";
			btnMusteriGoster.UseVisualStyleBackColor = true;
			btnMusteriGoster.Click += btnMusteriGoster_Click;
			// 
			// btnMusteriEkle
			// 
			btnMusteriEkle.Location = new Point(283, 615);
			btnMusteriEkle.Name = "btnMusteriEkle";
			btnMusteriEkle.Size = new Size(237, 53);
			btnMusteriEkle.TabIndex = 8;
			btnMusteriEkle.Text = "Müşteri Ekle";
			btnMusteriEkle.UseVisualStyleBackColor = true;
			btnMusteriEkle.Click += btnMusteriEkle_Click;
			// 
			// txtMüsteriAd
			// 
			txtMüsteriAd.Location = new Point(765, 610);
			txtMüsteriAd.Name = "txtMüsteriAd";
			txtMüsteriAd.Size = new Size(150, 31);
			txtMüsteriAd.TabIndex = 7;
			// 
			// txtMüsteriSoyad
			// 
			txtMüsteriSoyad.Location = new Point(921, 610);
			txtMüsteriSoyad.Name = "txtMüsteriSoyad";
			txtMüsteriSoyad.Size = new Size(150, 31);
			txtMüsteriSoyad.TabIndex = 7;
			// 
			// txtMusteriMail
			// 
			txtMusteriMail.Location = new Point(1077, 610);
			txtMusteriMail.Name = "txtMusteriMail";
			txtMusteriMail.Size = new Size(150, 31);
			txtMusteriMail.TabIndex = 7;
			// 
			// txtMusteriTel
			// 
			txtMusteriTel.Location = new Point(1233, 610);
			txtMusteriTel.Name = "txtMusteriTel";
			txtMusteriTel.Size = new Size(150, 31);
			txtMusteriTel.TabIndex = 7;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(765, 574);
			label7.Name = "label7";
			label7.Size = new Size(103, 25);
			label7.TabIndex = 9;
			label7.Text = "Müşteri Adı";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(921, 574);
			label8.Name = "label8";
			label8.Size = new Size(126, 25);
			label8.TabIndex = 9;
			label8.Text = "Müşteri Soyad";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(1233, 574);
			label9.Name = "label9";
			label9.Size = new Size(132, 25);
			label9.TabIndex = 9;
			label9.Text = "Müşteri Telefon";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(1077, 574);
			label10.Name = "label10";
			label10.Size = new Size(109, 25);
			label10.TabIndex = 9;
			label10.Text = "Müşteri Mail";
			// 
			// btnUrunGuncelle
			// 
			btnUrunGuncelle.Location = new Point(12, 562);
			btnUrunGuncelle.Name = "btnUrunGuncelle";
			btnUrunGuncelle.Size = new Size(242, 49);
			btnUrunGuncelle.TabIndex = 0;
			btnUrunGuncelle.Text = "Ürünlerin Güncellenmesi";
			btnUrunGuncelle.UseVisualStyleBackColor = true;
			btnUrunGuncelle.Click += btnUrunGuncelle_Click;
			// 
			// btnUrunSil
			// 
			btnUrunSil.Location = new Point(12, 617);
			btnUrunSil.Name = "btnUrunSil";
			btnUrunSil.Size = new Size(242, 49);
			btnUrunSil.TabIndex = 0;
			btnUrunSil.Text = "Ürün Silme";
			btnUrunSil.UseVisualStyleBackColor = true;
			btnUrunSil.Click += btnUrunSil_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(765, 448);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(150, 31);
			textBox1.TabIndex = 7;
			// 
			// Ana
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1561, 791);
			Controls.Add(label10);
			Controls.Add(label5);
			Controls.Add(label9);
			Controls.Add(label3);
			Controls.Add(label8);
			Controls.Add(label2);
			Controls.Add(label6);
			Controls.Add(label7);
			Controls.Add(label1);
			Controls.Add(btnMusteriEkle);
			Controls.Add(txtMusteriTel);
			Controls.Add(btnUrunEkle);
			Controls.Add(txtMusteriMail);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(txtMüsteriSoyad);
			Controls.Add(textBox5);
			Controls.Add(txtMüsteriAd);
			Controls.Add(textBox1);
			Controls.Add(textBox2);
			Controls.Add(txtAra);
			Controls.Add(btnKategoriGoster);
			Controls.Add(btnKategoriEkle);
			Controls.Add(dataGridView1);
			Controls.Add(label4);
			Controls.Add(pictureBox1);
			Controls.Add(btnMusteriGoster);
			Controls.Add(btnUrunSil);
			Controls.Add(btnUrunGuncelle);
			Controls.Add(btnUrun);
			Name = "Ana";
			Text = "Ana";
			FormClosing += Ana_FormClosing;
			Load += Ana_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnUrun;
		private PictureBox pictureBox1;
		private Label label4;
		private DataGridView dataGridView1;
		private Button btnKategoriEkle;
		private TextBox txtAra;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private Button btnUrunEkle;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label5;
		private Button btnKategoriGoster;
		private TextBox textBox5;
		private Label label6;
		private Button btnMusteriGoster;
		private Button btnMusteriEkle;
		private TextBox txtMüsteriAd;
		private TextBox txtMüsteriSoyad;
		private TextBox txtMusteriMail;
		private TextBox txtMusteriTel;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Button btnUrunGuncelle;
		private Button btnUrunSil;
		private TextBox textBox1;
	}
}