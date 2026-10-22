namespace KisiselButceTakip
{
    partial class Form1
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
            txtGelir = new TextBox();
            btnGelirEkle = new Button();
            cmbKategori = new ComboBox();
            txtHarcamaTutari = new TextBox();
            rbZorunlu = new RadioButton();
            rbIstegeBagli = new RadioButton();
            btnHarcamaEkle = new Button();
            btnTemizle = new Button();
            Harcamalar = new ListBox();
            lblToplamGelir = new Label();
            lblToplamGider = new Label();
            lblKalanButce = new Label();
            lblZorunluToplam = new Label();
            lblIstegeBagliToplam = new Label();
            lblDurumMesaji = new Label();
            SuspendLayout();
            // 
            // txtGelir
            // 
            txtGelir.Location = new Point(12, 26);
            txtGelir.Name = "txtGelir";
            txtGelir.Size = new Size(163, 27);
            txtGelir.TabIndex = 0;
            // 
            // btnGelirEkle
            // 
            btnGelirEkle.Location = new Point(188, 24);
            btnGelirEkle.Name = "btnGelirEkle";
            btnGelirEkle.Size = new Size(131, 29);
            btnGelirEkle.TabIndex = 1;
            btnGelirEkle.Text = "Gelir Ekle";
            btnGelirEkle.UseVisualStyleBackColor = true;
            btnGelirEkle.Click += btnGelirEkle_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(344, 110);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(214, 28);
            cmbKategori.TabIndex = 2;
            // 
            // txtHarcamaTutari
            // 
            txtHarcamaTutari.Location = new Point(12, 109);
            txtHarcamaTutari.Name = "txtHarcamaTutari";
            txtHarcamaTutari.Size = new Size(163, 27);
            txtHarcamaTutari.TabIndex = 3;
            // 
            // rbZorunlu
            // 
            rbZorunlu.AutoSize = true;
            rbZorunlu.Location = new Point(12, 153);
            rbZorunlu.Name = "rbZorunlu";
            rbZorunlu.Size = new Size(145, 24);
            rbZorunlu.TabIndex = 4;
            rbZorunlu.TabStop = true;
            rbZorunlu.Text = "Zorunlu Harcama";
            rbZorunlu.UseVisualStyleBackColor = true;
            // 
            // rbIstegeBagli
            // 
            rbIstegeBagli.AutoSize = true;
            rbIstegeBagli.Location = new Point(12, 193);
            rbIstegeBagli.Name = "rbIstegeBagli";
            rbIstegeBagli.Size = new Size(172, 24);
            rbIstegeBagli.TabIndex = 5;
            rbIstegeBagli.TabStop = true;
            rbIstegeBagli.Text = "İsteğe Bağlı Harcama";
            rbIstegeBagli.UseVisualStyleBackColor = true;
            // 
            // btnHarcamaEkle
            // 
            btnHarcamaEkle.Location = new Point(188, 109);
            btnHarcamaEkle.Name = "btnHarcamaEkle";
            btnHarcamaEkle.Size = new Size(131, 29);
            btnHarcamaEkle.TabIndex = 6;
            btnHarcamaEkle.Text = "Harcama Ekle";
            btnHarcamaEkle.UseVisualStyleBackColor = true;
            btnHarcamaEkle.Click += btnHarcamaEkle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(640, 26);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(148, 35);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // Harcamalar
            // 
            Harcamalar.FormattingEnabled = true;
            Harcamalar.Location = new Point(12, 241);
            Harcamalar.Name = "Harcamalar";
            Harcamalar.Size = new Size(285, 164);
            Harcamalar.TabIndex = 8;
            // 
            // lblToplamGelir
            // 
            lblToplamGelir.AutoSize = true;
            lblToplamGelir.Location = new Point(321, 241);
            lblToplamGelir.Name = "lblToplamGelir";
            lblToplamGelir.Size = new Size(103, 20);
            lblToplamGelir.TabIndex = 9;
            lblToplamGelir.Text = "Aylık Gelir: 0 ₺";
            // 
            // lblToplamGider
            // 
            lblToplamGider.AutoSize = true;
            lblToplamGider.Location = new Point(321, 271);
            lblToplamGider.Name = "lblToplamGider";
            lblToplamGider.Size = new Size(126, 20);
            lblToplamGider.TabIndex = 10;
            lblToplamGider.Text = "Toplam Gider: 0 ₺";
            // 
            // lblKalanButce
            // 
            lblKalanButce.AutoSize = true;
            lblKalanButce.Location = new Point(321, 301);
            lblKalanButce.Name = "lblKalanButce";
            lblKalanButce.Size = new Size(114, 20);
            lblKalanButce.TabIndex = 11;
            lblKalanButce.Text = "Kalan Bütçe: 0 ₺";
            // 
            // lblZorunluToplam
            // 
            lblZorunluToplam.AutoSize = true;
            lblZorunluToplam.Location = new Point(321, 332);
            lblZorunluToplam.Name = "lblZorunluToplam";
            lblZorunluToplam.Size = new Size(141, 20);
            lblZorunluToplam.TabIndex = 12;
            lblZorunluToplam.Text = "Toplam Zorunlu: 0 ₺";
            // 
            // lblIstegeBagliToplam
            // 
            lblIstegeBagliToplam.AutoSize = true;
            lblIstegeBagliToplam.Location = new Point(321, 369);
            lblIstegeBagliToplam.Name = "lblIstegeBagliToplam";
            lblIstegeBagliToplam.Size = new Size(168, 20);
            lblIstegeBagliToplam.TabIndex = 13;
            lblIstegeBagliToplam.Text = "Toplam İsteğe Bağlı: 0 ₺";
            
            // 
            // lblDurumMesaji
            // 
            lblDurumMesaji.AutoSize = true;
            lblDurumMesaji.Location = new Point(321, 403);
            lblDurumMesaji.Name = "lblDurumMesaji";
            lblDurumMesaji.Size = new Size(129, 20);
            lblDurumMesaji.TabIndex = 14;
            lblDurumMesaji.Text = "BÜTÇE DURUMU:?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDurumMesaji);
            Controls.Add(lblIstegeBagliToplam);
            Controls.Add(lblZorunluToplam);
            Controls.Add(lblKalanButce);
            Controls.Add(lblToplamGider);
            Controls.Add(lblToplamGelir);
            Controls.Add(Harcamalar);
            Controls.Add(btnTemizle);
            Controls.Add(btnHarcamaEkle);
            Controls.Add(rbIstegeBagli);
            Controls.Add(rbZorunlu);
            Controls.Add(txtHarcamaTutari);
            Controls.Add(cmbKategori);
            Controls.Add(btnGelirEkle);
            Controls.Add(txtGelir);
            Name = "Form1";
            Text = "Bütçe Takip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGelir;
        private Button btnGelirEkle;
        private ComboBox cmbKategori;
        private TextBox txtHarcamaTutari;
        private RadioButton rbZorunlu;
        private RadioButton rbIstegeBagli;
        private Button btnHarcamaEkle;
        private Button btnTemizle;
        private ListBox Harcamalar;
        private Label lblToplamGelir;
        private Label lblToplamGider;
        private Label lblKalanButce;
        private Label lblZorunluToplam;
        private Label lblIstegeBagliToplam;
        private Label lblDurumMesaji;
    }
}
