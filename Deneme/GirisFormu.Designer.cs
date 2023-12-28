namespace Deneme
{
	partial class GirisFormu
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			txtKullaniciAdi = new TextBox();
			label3 = new Label();
			txtSifre = new TextBox();
			btnGiris = new Button();
			label4 = new Label();
			materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(-32, 67);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(558, 447);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = SystemColors.Control;
			label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(19, 401);
			label1.Name = "label1";
			label1.Size = new Size(483, 38);
			label1.TabIndex = 1;
			label1.Text = "BYTELAND OTOMASYON SİSTEMİ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = SystemColors.Control;
			label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(43, 489);
			label2.Name = "label2";
			label2.Size = new Size(115, 25);
			label2.TabIndex = 2;
			label2.Text = "Kullanıcı Adı";
			// 
			// txtKullaniciAdi
			// 
			txtKullaniciAdi.Location = new Point(184, 486);
			txtKullaniciAdi.Name = "txtKullaniciAdi";
			txtKullaniciAdi.Size = new Size(280, 31);
			txtKullaniciAdi.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = SystemColors.Control;
			label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(43, 543);
			label3.Name = "label3";
			label3.Size = new Size(50, 25);
			label3.TabIndex = 2;
			label3.Text = "Şifre";
			// 
			// txtSifre
			// 
			txtSifre.Location = new Point(184, 540);
			txtSifre.Name = "txtSifre";
			txtSifre.PasswordChar = '*';
			txtSifre.Size = new Size(280, 31);
			txtSifre.TabIndex = 1;
			// 
			// btnGiris
			// 
			btnGiris.Cursor = Cursors.Hand;
			btnGiris.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnGiris.Location = new Point(43, 646);
			btnGiris.Name = "btnGiris";
			btnGiris.Size = new Size(421, 46);
			btnGiris.TabIndex = 2;
			btnGiris.Text = "GİRİŞ YAP";
			btnGiris.UseVisualStyleBackColor = true;
			btnGiris.Click += btnGiris_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = SystemColors.AppWorkspace;
			label4.Location = new Point(6, 710);
			label4.Name = "label4";
			label4.Size = new Size(214, 25);
			label4.TabIndex = 3;
			label4.Text = "Bu bir KONAMI ürünüdür.";
			label4.Click += label4_Click;
			// 
			// materialCheckbox1
			// 
			materialCheckbox1.AutoSize = true;
			materialCheckbox1.Depth = 0;
			materialCheckbox1.Location = new Point(463, 538);
			materialCheckbox1.Margin = new Padding(0);
			materialCheckbox1.MouseLocation = new Point(-1, -1);
			materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
			materialCheckbox1.Name = "materialCheckbox1";
			materialCheckbox1.ReadOnly = false;
			materialCheckbox1.Ripple = true;
			materialCheckbox1.Size = new Size(35, 37);
			materialCheckbox1.TabIndex = 4;
			materialCheckbox1.UseVisualStyleBackColor = false;
			materialCheckbox1.CheckedChanged += materialCheckbox1_CheckedChanged_1;
			// 
			// GirisFormu
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(514, 754);
			Controls.Add(materialCheckbox1);
			Controls.Add(label4);
			Controls.Add(btnGiris);
			Controls.Add(txtSifre);
			Controls.Add(txtKullaniciAdi);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "GirisFormu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "BYTELAND OTOMASYON SİSTEMİ - GİRİŞ";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private TextBox txtKullaniciAdi;
		private Label label3;
		private TextBox txtSifre;
		private Button btnGiris;
		private Label label4;
		private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
	}
}