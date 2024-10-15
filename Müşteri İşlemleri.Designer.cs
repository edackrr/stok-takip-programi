namespace Stok_takip_programı
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbBoxMusteriler = new System.Windows.Forms.GroupBox();
            this.grdMusteriler = new System.Windows.Forms.DataGridView();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirmaAdı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grbBoxMusteriler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBoxMusteriler
            // 
            this.grbBoxMusteriler.Controls.Add(this.grdMusteriler);
            this.grbBoxMusteriler.Controls.Add(this.btnYeni);
            this.grbBoxMusteriler.Controls.Add(this.btnGüncelle);
            this.grbBoxMusteriler.Controls.Add(this.btnSil);
            this.grbBoxMusteriler.Controls.Add(this.btnEkle);
            this.grbBoxMusteriler.Controls.Add(this.mskTelefon);
            this.grbBoxMusteriler.Controls.Add(this.label5);
            this.grbBoxMusteriler.Controls.Add(this.txtMail);
            this.grbBoxMusteriler.Controls.Add(this.label4);
            this.grbBoxMusteriler.Controls.Add(this.txtAdres);
            this.grbBoxMusteriler.Controls.Add(this.label3);
            this.grbBoxMusteriler.Controls.Add(this.txtFirmaAdı);
            this.grbBoxMusteriler.Controls.Add(this.label2);
            this.grbBoxMusteriler.Controls.Add(this.txtAdSoyad);
            this.grbBoxMusteriler.Controls.Add(this.label1);
            this.grbBoxMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbBoxMusteriler.Location = new System.Drawing.Point(12, 12);
            this.grbBoxMusteriler.Name = "grbBoxMusteriler";
            this.grbBoxMusteriler.Size = new System.Drawing.Size(898, 344);
            this.grbBoxMusteriler.TabIndex = 1;
            this.grbBoxMusteriler.TabStop = false;
            this.grbBoxMusteriler.Text = "Bilgi Girişi";
            // 
            // grdMusteriler
            // 
            this.grdMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMusteriler.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMusteriler.Location = new System.Drawing.Point(15, 213);
            this.grdMusteriler.MultiSelect = false;
            this.grdMusteriler.Name = "grdMusteriler";
            this.grdMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMusteriler.Size = new System.Drawing.Size(860, 115);
            this.grdMusteriler.TabIndex = 14;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(121, 106);
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(168, 26);
            this.mskTelefon.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon Adı:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(366, 109);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(144, 26);
            this.txtMail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mail:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(731, 47);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(144, 82);
            this.txtAdres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres:";
            // 
            // txtFirmaAdı
            // 
            this.txtFirmaAdı.Location = new System.Drawing.Point(404, 47);
            this.txtFirmaAdı.Name = "txtFirmaAdı";
            this.txtFirmaAdı.Size = new System.Drawing.Size(168, 26);
            this.txtFirmaAdı.TabIndex = 3;
            this.txtFirmaAdı.TextChanged += new System.EventHandler(this.txtYetkiliAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firma Adı:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(121, 41);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(168, 26);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyadı:";
            // 
            // btnYeni
            // 
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.Location = new System.Drawing.Point(26, 176);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(133, 31);
            this.btnYeni.TabIndex = 13;
            this.btnYeni.Text = "Yeni Ekle";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Image = global::Stok_takip_programı.Properties.Resources.circle;
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.Location = new System.Drawing.Point(751, 175);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(124, 31);
            this.btnGüncelle.TabIndex = 12;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSil.Image = global::Stok_takip_programı.Properties.Resources.delete_button;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.Location = new System.Drawing.Point(634, 175);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 31);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::Stok_takip_programı.Properties.Resources.round;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.Location = new System.Drawing.Point(517, 175);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(106, 31);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 368);
            this.Controls.Add(this.grbBoxMusteriler);
            this.Name = "Form1";
            this.Text = "Müşteri İşlemleri";
            this.grbBoxMusteriler.ResumeLayout(false);
            this.grbBoxMusteriler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBoxMusteriler;
        private System.Windows.Forms.DataGridView grdMusteriler;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirmaAdı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
    }
}