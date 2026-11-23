namespace SUAL_AracKiralama
{
    partial class MusteriForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnKiralamalarim = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pnlKayit = new System.Windows.Forms.Panel();
            this.pnlKayitKart = new System.Windows.Forms.Panel();
            this.lblKayitBaslik = new System.Windows.Forms.Label();
            this.lblKayitAciklama = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.pnlKiralama = new System.Windows.Forms.Panel();
            this.pnlFiltre = new System.Windows.Forms.Panel();
            this.lblFiltreBaslik = new System.Windows.Forms.Label();
            this.lblSehirEtiketi = new System.Windows.Forms.Label();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.lblBaslangicEtiketi = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblBitisEtiketi = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.lblSegmentEtiketi = new System.Windows.Forms.Label();
            this.cmbSegment = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lblSonucSayisi = new System.Windows.Forms.Label();
            this.pnlSonuclar = new System.Windows.Forms.Panel();
            this.lblSonucBaslik = new System.Windows.Forms.Label();
            this.flowAraclar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlKiralamalarim = new System.Windows.Forms.Panel();
            this.lblGecmisBaslik = new System.Windows.Forms.Label();
            this.lvKiralamalar = new System.Windows.Forms.ListView();
            this.pnlHeader.SuspendLayout();
            this.pnlKayit.SuspendLayout();
            this.pnlKayitKart.SuspendLayout();
            this.pnlKiralama.SuspendLayout();
            this.pnlFiltre.SuspendLayout();
            this.pnlSonuclar.SuspendLayout();
            this.pnlKiralamalarim.SuspendLayout();
            this.SuspendLayout();
             
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Controls.Add(this.lblKullanici);
            this.pnlHeader.Controls.Add(this.btnKiralamalarim);
            this.pnlHeader.Controls.Add(this.btnCikis);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1150, 62);
            this.pnlHeader.TabIndex = 3;
            
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(280, 62);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🚗  SUAL Araç Kiralama";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
           
            this.lblKullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.lblKullanici.Location = new System.Drawing.Point(300, 0);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(500, 62);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "Hoş Geldiniz";
            this.lblKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             
            this.btnKiralamalarim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.btnKiralamalarim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiralamalarim.FlatAppearance.BorderSize = 0;
            this.btnKiralamalarim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiralamalarim.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiralamalarim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(230)))));
            this.btnKiralamalarim.Location = new System.Drawing.Point(870, 12);
            this.btnKiralamalarim.Name = "btnKiralamalarim";
            this.btnKiralamalarim.Size = new System.Drawing.Size(145, 38);
            this.btnKiralamalarim.TabIndex = 2;
            this.btnKiralamalarim.Text = "📋 Kiralamalarım";
            this.btnKiralamalarim.UseVisualStyleBackColor = false;
            this.btnKiralamalarim.Click += new System.EventHandler(this.btnKiralamalarim_Click);
             
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(1025, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 38);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            
            this.pnlKayit.AutoScroll = true;
            this.pnlKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.pnlKayit.Controls.Add(this.pnlKayitKart);
            this.pnlKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKayit.Location = new System.Drawing.Point(0, 62);
            this.pnlKayit.Name = "pnlKayit";
            this.pnlKayit.Size = new System.Drawing.Size(1150, 638);
            this.pnlKayit.TabIndex = 0;
            this.pnlKayit.Visible = false;
             
            this.pnlKayitKart.BackColor = System.Drawing.Color.White;
            this.pnlKayitKart.Controls.Add(this.lblKayitBaslik);
            this.pnlKayitKart.Controls.Add(this.lblKayitAciklama);
            this.pnlKayitKart.Controls.Add(this.lblAdSoyad);
            this.pnlKayitKart.Controls.Add(this.txtAd);
            this.pnlKayitKart.Controls.Add(this.lblSoyad);
            this.pnlKayitKart.Controls.Add(this.txtSoyad);
            this.pnlKayitKart.Controls.Add(this.lblTc);
            this.pnlKayitKart.Controls.Add(this.txtTc);
            this.pnlKayitKart.Controls.Add(this.btnKayitOl);
            this.pnlKayitKart.Location = new System.Drawing.Point(375, 100);
            this.pnlKayitKart.Name = "pnlKayitKart";
            this.pnlKayitKart.Size = new System.Drawing.Size(400, 430);
            this.pnlKayitKart.TabIndex = 0;
             
            this.lblKayitBaslik.BackColor = System.Drawing.Color.White;
            this.lblKayitBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.lblKayitBaslik.Location = new System.Drawing.Point(0, 25);
            this.lblKayitBaslik.Name = "lblKayitBaslik";
            this.lblKayitBaslik.Size = new System.Drawing.Size(400, 40);
            this.lblKayitBaslik.TabIndex = 0;
            this.lblKayitBaslik.Text = "👤 Kayıt Bilgileri";
            this.lblKayitBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.lblKayitAciklama.BackColor = System.Drawing.Color.White;
            this.lblKayitAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(140)))));
            this.lblKayitAciklama.Location = new System.Drawing.Point(20, 70);
            this.lblKayitAciklama.Name = "lblKayitAciklama";
            this.lblKayitAciklama.Size = new System.Drawing.Size(360, 45);
            this.lblKayitAciklama.TabIndex = 1;
            this.lblKayitAciklama.Text = "Sistemi ilk kez kullanıyorsunuz.\nBilgilerinizi tamamlayarak devam edin.";
            this.lblKayitAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.lblAdSoyad.BackColor = System.Drawing.Color.White;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblAdSoyad.Location = new System.Drawing.Point(30, 128);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(340, 18);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad";
            
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(30, 148);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(340, 30);
            this.txtAd.TabIndex = 3;
             
            this.lblSoyad.BackColor = System.Drawing.Color.White;
            this.lblSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblSoyad.Location = new System.Drawing.Point(30, 192);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(340, 18);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad";
             
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(30, 212);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(340, 30);
            this.txtSoyad.TabIndex = 5;
             
            this.lblTc.BackColor = System.Drawing.Color.White;
            this.lblTc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.lblTc.Location = new System.Drawing.Point(30, 256);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(340, 18);
            this.lblTc.TabIndex = 6;
            this.lblTc.Text = "TC Kimlik Numarası";
             
            this.txtTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.txtTc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(30, 276);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(340, 30);
            this.txtTc.TabIndex = 7;
             
            this.btnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayitOl.FlatAppearance.BorderSize = 0;
            this.btnKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOl.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Location = new System.Drawing.Point(30, 336);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(340, 48);
            this.btnKayitOl.TabIndex = 8;
            this.btnKayitOl.Text = "Kaydı Tamamla →";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
             
            this.pnlKiralama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.pnlKiralama.Controls.Add(this.pnlFiltre);
            this.pnlKiralama.Controls.Add(this.pnlSonuclar);
            this.pnlKiralama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKiralama.Location = new System.Drawing.Point(0, 62);
            this.pnlKiralama.Name = "pnlKiralama";
            this.pnlKiralama.Size = new System.Drawing.Size(1150, 638);
            this.pnlKiralama.TabIndex = 1;
            this.pnlKiralama.Visible = false;
             
            this.pnlFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.pnlFiltre.Controls.Add(this.lblFiltreBaslik);
            this.pnlFiltre.Controls.Add(this.lblSehirEtiketi);
            this.pnlFiltre.Controls.Add(this.cmbSehir);
            this.pnlFiltre.Controls.Add(this.lblBaslangicEtiketi);
            this.pnlFiltre.Controls.Add(this.dtpBaslangic);
            this.pnlFiltre.Controls.Add(this.lblBitisEtiketi);
            this.pnlFiltre.Controls.Add(this.dtpBitis);
            this.pnlFiltre.Controls.Add(this.lblSegmentEtiketi);
            this.pnlFiltre.Controls.Add(this.cmbSegment);
            this.pnlFiltre.Controls.Add(this.btnAra);
            this.pnlFiltre.Controls.Add(this.lblSonucSayisi);
            this.pnlFiltre.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltre.Name = "pnlFiltre";
            this.pnlFiltre.Size = new System.Drawing.Size(255, 638);
            this.pnlFiltre.TabIndex = 0;
             
            this.lblFiltreBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltreBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiltreBaslik.ForeColor = System.Drawing.Color.White;
            this.lblFiltreBaslik.Location = new System.Drawing.Point(0, 18);
            this.lblFiltreBaslik.Name = "lblFiltreBaslik";
            this.lblFiltreBaslik.Size = new System.Drawing.Size(255, 35);
            this.lblFiltreBaslik.TabIndex = 0;
            this.lblFiltreBaslik.Text = "🔍  Araç Filtrele";
            this.lblFiltreBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.lblSehirEtiketi.BackColor = System.Drawing.Color.Transparent;
            this.lblSehirEtiketi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehirEtiketi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(220)))));
            this.lblSehirEtiketi.Location = new System.Drawing.Point(15, 68);
            this.lblSehirEtiketi.Name = "lblSehirEtiketi";
            this.lblSehirEtiketi.Size = new System.Drawing.Size(225, 20);
            this.lblSehirEtiketi.TabIndex = 1;
            this.lblSehirEtiketi.Text = "📍  Şehir Seçin";
             
            this.cmbSehir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSehir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSehir.Location = new System.Drawing.Point(15, 90);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(225, 31);
            this.cmbSehir.TabIndex = 2;
             
            this.lblBaslangicEtiketi.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslangicEtiketi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangicEtiketi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(220)))));
            this.lblBaslangicEtiketi.Location = new System.Drawing.Point(15, 138);
            this.lblBaslangicEtiketi.Name = "lblBaslangicEtiketi";
            this.lblBaslangicEtiketi.Size = new System.Drawing.Size(225, 20);
            this.lblBaslangicEtiketi.TabIndex = 3;
            this.lblBaslangicEtiketi.Text = "📅  Başlangıç Tarihi";
            
            this.dtpBaslangic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(15, 160);
            this.dtpBaslangic.MinDate = new System.DateTime(2026, 5, 28, 0, 0, 0, 0);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(225, 30);
            this.dtpBaslangic.TabIndex = 4;
            this.dtpBaslangic.Value = new System.DateTime(2026, 5, 28, 0, 0, 0, 0);
             
            this.lblBitisEtiketi.BackColor = System.Drawing.Color.Transparent;
            this.lblBitisEtiketi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitisEtiketi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(220)))));
            this.lblBitisEtiketi.Location = new System.Drawing.Point(15, 205);
            this.lblBitisEtiketi.Name = "lblBitisEtiketi";
            this.lblBitisEtiketi.Size = new System.Drawing.Size(225, 20);
            this.lblBitisEtiketi.TabIndex = 5;
            this.lblBitisEtiketi.Text = "📅  Bitiş Tarihi";
             
            this.dtpBitis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(15, 227);
            this.dtpBitis.MinDate = new System.DateTime(2026, 5, 29, 0, 0, 0, 0);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(225, 30);
            this.dtpBitis.TabIndex = 6;
            this.dtpBitis.Value = new System.DateTime(2026, 5, 31, 0, 0, 0, 0);
             
            this.lblSegmentEtiketi.BackColor = System.Drawing.Color.Transparent;
            this.lblSegmentEtiketi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSegmentEtiketi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(220)))));
            this.lblSegmentEtiketi.Location = new System.Drawing.Point(15, 272);
            this.lblSegmentEtiketi.Name = "lblSegmentEtiketi";
            this.lblSegmentEtiketi.Size = new System.Drawing.Size(225, 20);
            this.lblSegmentEtiketi.TabIndex = 7;
            this.lblSegmentEtiketi.Text = "🚘  Araç Tipi";
             
            this.cmbSegment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.cmbSegment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSegment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSegment.Items.AddRange(new object[] {
            "Tümü",
            "Ekonomi",
            "Orta",
            "SUV",
            "Premium"});
            this.cmbSegment.Location = new System.Drawing.Point(15, 294);
            this.cmbSegment.Name = "cmbSegment";
            this.cmbSegment.Size = new System.Drawing.Size(225, 31);
            this.cmbSegment.TabIndex = 8;
             
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(15, 348);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(225, 48);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "🔍   Araçları Listele";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            
            this.lblSonucSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblSonucSayisi.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonucSayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.lblSonucSayisi.Location = new System.Drawing.Point(15, 408);
            this.lblSonucSayisi.Name = "lblSonucSayisi";
            this.lblSonucSayisi.Size = new System.Drawing.Size(225, 20);
            this.lblSonucSayisi.TabIndex = 10;
            this.lblSonucSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.pnlSonuclar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSonuclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.pnlSonuclar.Controls.Add(this.lblSonucBaslik);
            this.pnlSonuclar.Controls.Add(this.flowAraclar);
            this.pnlSonuclar.Location = new System.Drawing.Point(255, 0);
            this.pnlSonuclar.Name = "pnlSonuclar";
            this.pnlSonuclar.Size = new System.Drawing.Size(1845, 1176);
            this.pnlSonuclar.TabIndex = 1;
             
            this.lblSonucBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.lblSonucBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonucBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.lblSonucBaslik.Location = new System.Drawing.Point(15, 15);
            this.lblSonucBaslik.Name = "lblSonucBaslik";
            this.lblSonucBaslik.Size = new System.Drawing.Size(870, 35);
            this.lblSonucBaslik.TabIndex = 0;
            this.lblSonucBaslik.Text = "Şehir ve tarih seçerek araç arayın";
            this.lblSonucBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
             
            this.flowAraclar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowAraclar.AutoScroll = true;
            this.flowAraclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.flowAraclar.Location = new System.Drawing.Point(10, 58);
            this.flowAraclar.Name = "flowAraclar";
            this.flowAraclar.Size = new System.Drawing.Size(1825, 1108);
            this.flowAraclar.TabIndex = 1;
            
            this.pnlKiralamalarim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.pnlKiralamalarim.Controls.Add(this.lblGecmisBaslik);
            this.pnlKiralamalarim.Controls.Add(this.lvKiralamalar);
            this.pnlKiralamalarim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKiralamalarim.Location = new System.Drawing.Point(0, 62);
            this.pnlKiralamalarim.Name = "pnlKiralamalarim";
            this.pnlKiralamalarim.Padding = new System.Windows.Forms.Padding(20);
            this.pnlKiralamalarim.Size = new System.Drawing.Size(1150, 638);
            this.pnlKiralamalarim.TabIndex = 2;
            this.pnlKiralamalarim.Visible = false;
             
            this.lblGecmisBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.lblGecmisBaslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGecmisBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.lblGecmisBaslik.Location = new System.Drawing.Point(20, 20);
            this.lblGecmisBaslik.Name = "lblGecmisBaslik";
            this.lblGecmisBaslik.Size = new System.Drawing.Size(500, 38);
            this.lblGecmisBaslik.TabIndex = 0;
            this.lblGecmisBaslik.Text = "📋  Kiralama Geçmişim";
             
            this.lvKiralamalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvKiralamalar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvKiralamalar.FullRowSelect = true;
            this.lvKiralamalar.GridLines = true;
            this.lvKiralamalar.HideSelection = false;
            this.lvKiralamalar.Location = new System.Drawing.Point(20, 70);
            this.lvKiralamalar.Name = "lvKiralamalar";
            this.lvKiralamalar.Size = new System.Drawing.Size(2050, 1098);
            this.lvKiralamalar.TabIndex = 1;
            this.lvKiralamalar.UseCompatibleStateImageBehavior = false;
            this.lvKiralamalar.View = System.Windows.Forms.View.Details;
             
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.pnlKayit);
            this.Controls.Add(this.pnlKiralama);
            this.Controls.Add(this.pnlKiralamalarim);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "MusteriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUAL Araç Kiralama — Müşteri Paneli";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            this.SizeChanged += new System.EventHandler(this.MusteriForm_SizeChanged);
            this.pnlHeader.ResumeLayout(false);
            this.pnlKayit.ResumeLayout(false);
            this.pnlKayitKart.ResumeLayout(false);
            this.pnlKayitKart.PerformLayout();
            this.pnlKiralama.ResumeLayout(false);
            this.pnlFiltre.ResumeLayout(false);
            this.pnlSonuclar.ResumeLayout(false);
            this.pnlKiralamalarim.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Button btnKiralamalarim;
        private System.Windows.Forms.Button btnCikis;

        private System.Windows.Forms.Panel pnlKayit;
        private System.Windows.Forms.Panel pnlKayitKart;
        private System.Windows.Forms.Label lblKayitBaslik;
        private System.Windows.Forms.Label lblKayitAciklama;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnKayitOl;

        private System.Windows.Forms.Panel pnlKiralama;
        private System.Windows.Forms.Panel pnlFiltre;
        private System.Windows.Forms.Label lblFiltreBaslik;
        private System.Windows.Forms.Label lblSehirEtiketi;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label lblBaslangicEtiketi;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label lblBitisEtiketi;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label lblSegmentEtiketi;
        private System.Windows.Forms.ComboBox cmbSegment;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label lblSonucSayisi;

        private System.Windows.Forms.Panel pnlSonuclar;
        private System.Windows.Forms.Label lblSonucBaslik;
        private System.Windows.Forms.FlowLayoutPanel flowAraclar;

        private System.Windows.Forms.Panel pnlKiralamalarim;
        private System.Windows.Forms.Label lblGecmisBaslik;
        private System.Windows.Forms.ListView lvKiralamalar;
        private System.Windows.Forms.Label lblSoyad;
    }
}