namespace YurtKayitSistemi
{
    partial class FrmOgrKyt
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKyt));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOgrAd = new System.Windows.Forms.TextBox();
            this.TxtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTxtBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.MskOgrTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskTxtDogum = new System.Windows.Forms.MaskedTextBox();
            this.ComboBolum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.RichVeliAdres = new System.Windows.Forms.RichTextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.ComboOdaNo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBoxVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtOgrAd
            // 
            this.TxtOgrAd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtOgrAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtOgrAd.Location = new System.Drawing.Point(253, 15);
            this.TxtOgrAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtOgrAd.Name = "TxtOgrAd";
            this.TxtOgrAd.Size = new System.Drawing.Size(454, 27);
            this.TxtOgrAd.TabIndex = 1;
            // 
            // TxtOgrSoyad
            // 
            this.TxtOgrSoyad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtOgrSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtOgrSoyad.Location = new System.Drawing.Point(253, 52);
            this.TxtOgrSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtOgrSoyad.Name = "TxtOgrSoyad";
            this.TxtOgrSoyad.Size = new System.Drawing.Size(454, 27);
            this.TxtOgrSoyad.TabIndex = 3;
            this.TxtOgrSoyad.TextChanged += new System.EventHandler(this.TxtOgrSoyad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "T.C.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bölüm";
            // 
            // MskTxtBoxTC
            // 
            this.MskTxtBoxTC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MskTxtBoxTC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MskTxtBoxTC.Location = new System.Drawing.Point(253, 89);
            this.MskTxtBoxTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MskTxtBoxTC.Mask = "00000000000";
            this.MskTxtBoxTC.Name = "MskTxtBoxTC";
            this.MskTxtBoxTC.Size = new System.Drawing.Size(454, 27);
            this.MskTxtBoxTC.TabIndex = 12;
            this.MskTxtBoxTC.ValidatingType = typeof(int);
            // 
            // MskOgrTelefon
            // 
            this.MskOgrTelefon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MskOgrTelefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MskOgrTelefon.Location = new System.Drawing.Point(253, 126);
            this.MskOgrTelefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MskOgrTelefon.Mask = "(999) 000-0000";
            this.MskOgrTelefon.Name = "MskOgrTelefon";
            this.MskOgrTelefon.Size = new System.Drawing.Size(454, 27);
            this.MskOgrTelefon.TabIndex = 13;
            // 
            // MskTxtDogum
            // 
            this.MskTxtDogum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MskTxtDogum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MskTxtDogum.Location = new System.Drawing.Point(253, 163);
            this.MskTxtDogum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MskTxtDogum.Mask = "00/00/0000";
            this.MskTxtDogum.Name = "MskTxtDogum";
            this.MskTxtDogum.Size = new System.Drawing.Size(454, 27);
            this.MskTxtDogum.TabIndex = 15;
            this.MskTxtDogum.ValidatingType = typeof(System.DateTime);
            // 
            // ComboBolum
            // 
            this.ComboBolum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ComboBolum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboBolum.FormattingEnabled = true;
            this.ComboBolum.Location = new System.Drawing.Point(253, 200);
            this.ComboBolum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBolum.Name = "ComboBolum";
            this.ComboBolum.Size = new System.Drawing.Size(454, 27);
            this.ComboBolum.TabIndex = 16;
            this.ComboBolum.SelectedIndexChanged += new System.EventHandler(this.ComboBolum_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "E-Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Oda No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 344);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Veli Ad Soyad";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(24, 381);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Veli Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(24, 413);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Veli Adres";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // MskVeliTelefon
            // 
            this.MskVeliTelefon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MskVeliTelefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MskVeliTelefon.Location = new System.Drawing.Point(253, 376);
            this.MskVeliTelefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MskVeliTelefon.Mask = "(999) 000-0000";
            this.MskVeliTelefon.Name = "MskVeliTelefon";
            this.MskVeliTelefon.Size = new System.Drawing.Size(454, 27);
            this.MskVeliTelefon.TabIndex = 27;
            // 
            // RichVeliAdres
            // 
            this.RichVeliAdres.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RichVeliAdres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RichVeliAdres.Location = new System.Drawing.Point(253, 413);
            this.RichVeliAdres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RichVeliAdres.Name = "RichVeliAdres";
            this.RichVeliAdres.Size = new System.Drawing.Size(454, 138);
            this.RichVeliAdres.TabIndex = 29;
            this.RichVeliAdres.Text = "";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnKaydet.Location = new System.Drawing.Point(253, 562);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(454, 33);
            this.BtnKaydet.TabIndex = 30;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // ComboOdaNo
            // 
            this.ComboOdaNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ComboOdaNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComboOdaNo.FormattingEnabled = true;
            this.ComboOdaNo.Location = new System.Drawing.Point(253, 273);
            this.ComboOdaNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboOdaNo.Name = "ComboOdaNo";
            this.ComboOdaNo.Size = new System.Drawing.Size(454, 27);
            this.ComboOdaNo.TabIndex = 31;
            this.ComboOdaNo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(13, 586);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 32;
            this.label12.Text = "OgrId";
            this.label12.Visible = false;
            // 
            // TxtBoxVeliAdSoyad
            // 
            this.TxtBoxVeliAdSoyad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtBoxVeliAdSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtBoxVeliAdSoyad.Location = new System.Drawing.Point(253, 341);
            this.TxtBoxVeliAdSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxVeliAdSoyad.Name = "TxtBoxVeliAdSoyad";
            this.TxtBoxVeliAdSoyad.Size = new System.Drawing.Size(454, 27);
            this.TxtBoxVeliAdSoyad.TabIndex = 24;
            this.TxtBoxVeliAdSoyad.TextChanged += new System.EventHandler(this.TxtBoxVeliAdSoyad_TextChanged);
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtBoxEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtBoxEmail.Location = new System.Drawing.Point(253, 238);
            this.TxtBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(454, 27);
            this.TxtBoxEmail.TabIndex = 18;
            // 
            // FrmOgrKyt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(723, 614);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ComboOdaNo);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.RichVeliAdres);
            this.Controls.Add(this.MskVeliTelefon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtBoxVeliAdSoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBolum);
            this.Controls.Add(this.MskTxtDogum);
            this.Controls.Add(this.MskOgrTelefon);
            this.Controls.Add(this.MskTxtBoxTC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOgrSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtOgrAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOgrKyt";
            this.Text = "Öğrenci Kayıt";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOgrAd;
        private System.Windows.Forms.TextBox TxtOgrSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTxtBoxTC;
        private System.Windows.Forms.MaskedTextBox MskOgrTelefon;
        private System.Windows.Forms.MaskedTextBox MskTxtDogum;
        private System.Windows.Forms.ComboBox ComboBolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox MskVeliTelefon;
        private System.Windows.Forms.RichTextBox RichVeliAdres;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.ComboBox ComboOdaNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtBoxVeliAdSoyad;
        private System.Windows.Forms.TextBox TxtBoxEmail;
    }
}

