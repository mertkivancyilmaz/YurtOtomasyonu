namespace YurtKayitSistemi
{
    partial class FrmPersonel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDepartmanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet61 = new YurtKayitSistemi.YurtKayitDataSet6();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtKayitDataSet6 = new YurtKayitSistemi.YurtKayitDataSet6();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtPersonelGorev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPersonelId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personelTableAdapter = new YurtKayitSistemi.YurtKayitDataSet6TableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.personelAdSoyadDataGridViewTextBoxColumn,
            this.personelDepartmanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(33, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 260);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelAdSoyadDataGridViewTextBoxColumn
            // 
            this.personelAdSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelAdSoyad";
            this.personelAdSoyadDataGridViewTextBoxColumn.Name = "personelAdSoyadDataGridViewTextBoxColumn";
            // 
            // personelDepartmanDataGridViewTextBoxColumn
            // 
            this.personelDepartmanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personelDepartmanDataGridViewTextBoxColumn.DataPropertyName = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.HeaderText = "PersonelDepartman";
            this.personelDepartmanDataGridViewTextBoxColumn.Name = "personelDepartmanDataGridViewTextBoxColumn";
            // 
            // personelBindingSource1
            // 
            this.personelBindingSource1.DataMember = "Personel";
            this.personelBindingSource1.DataSource = this.yurtKayitDataSet61;
            // 
            // yurtKayitDataSet61
            // 
            this.yurtKayitDataSet61.DataSetName = "YurtKayitDataSet6";
            this.yurtKayitDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.yurtKayitDataSet6;
            // 
            // yurtKayitDataSet6
            // 
            this.yurtKayitDataSet6.DataSetName = "YurtKayitDataSet6";
            this.yurtKayitDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnSil
            // 
            this.BtnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSil.Location = new System.Drawing.Point(247, 139);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(206, 33);
            this.BtnSil.TabIndex = 45;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuncelle.Location = new System.Drawing.Point(461, 139);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(206, 33);
            this.BtnGuncelle.TabIndex = 44;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtPersonelGorev
            // 
            this.TxtPersonelGorev.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtPersonelGorev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtPersonelGorev.Location = new System.Drawing.Point(178, 100);
            this.TxtPersonelGorev.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtPersonelGorev.Name = "TxtPersonelGorev";
            this.TxtPersonelGorev.Size = new System.Drawing.Size(489, 27);
            this.TxtPersonelGorev.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Personel Görev";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnKaydet.Location = new System.Drawing.Point(33, 139);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(206, 33);
            this.BtnKaydet.TabIndex = 41;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtPersonelAdSoyad
            // 
            this.TxtPersonelAdSoyad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtPersonelAdSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtPersonelAdSoyad.Location = new System.Drawing.Point(178, 57);
            this.TxtPersonelAdSoyad.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtPersonelAdSoyad.Name = "TxtPersonelAdSoyad";
            this.TxtPersonelAdSoyad.Size = new System.Drawing.Size(489, 27);
            this.TxtPersonelAdSoyad.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Personel Ad Soyad";
            // 
            // TxtPersonelId
            // 
            this.TxtPersonelId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtPersonelId.Enabled = false;
            this.TxtPersonelId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtPersonelId.Location = new System.Drawing.Point(178, 16);
            this.TxtPersonelId.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtPersonelId.Name = "TxtPersonelId";
            this.TxtPersonelId.Size = new System.Drawing.Size(489, 27);
            this.TxtPersonelId.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "Personel ID";
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtPersonelGorev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtPersonelAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPersonelId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonel";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtKayitDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtPersonelGorev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtPersonelAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPersonelId;
        private System.Windows.Forms.Label label1;
        private YurtKayitDataSet6 yurtKayitDataSet6;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private YurtKayitDataSet6TableAdapters.PersonelTableAdapter personelTableAdapter;
        private YurtKayitDataSet6 yurtKayitDataSet61;
        private System.Windows.Forms.BindingSource personelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelDepartmanDataGridViewTextBoxColumn;
    }
}