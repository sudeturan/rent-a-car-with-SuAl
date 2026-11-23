namespace SUAL_AracKiralama
{
    partial class AdminForm
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarLogo = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnFiloYonetimi = new System.Windows.Forms.Button();
            this.btnKiralamaTakip = new System.Windows.Forms.Button();
            this.btnYorumPanel = new System.Windows.Forms.Button();
            this.btnAdminCikis = new System.Windows.Forms.Button();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSayfaBaslik = new System.Windows.Forms.Label();
            this.lblAdminBilgi = new System.Windows.Forms.Label();

            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlKartCiro = new System.Windows.Forms.Panel();
            this.lblCiroSayi = new System.Windows.Forms.Label();
            this.lblCiroBaslik = new System.Windows.Forms.Label();
            this.pnlKartAktif = new System.Windows.Forms.Panel();
            this.lblAktifSayi = new System.Windows.Forms.Label();
            this.lblAktifBaslik = new System.Windows.Forms.Label();
            this.pnlKartMusteri = new System.Windows.Forms.Panel();
            this.lblMusteriSayi = new System.Windows.Forms.Label();
            this.lblMusteriBaslik = new System.Windows.Forms.Label();
            this.pnlKartKupon = new System.Windows.Forms.Panel();
            this.lblKuponIcerik = new System.Windows.Forms.Label();
            this.lblKuponBaslik = new System.Windows.Forms.Label();

            this.pnlFilo = new System.Windows.Forms.Panel();
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.pnlFiloForm = new System.Windows.Forms.Panel();
            this.lblFiloFormBaslik = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cmbSegment = new System.Windows.Forms.ComboBox();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAracGuncelle = new System.Windows.Forms.Button();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.lblBakimBaslik = new System.Windows.Forms.Label();
            this.cmbBakimSehir = new System.Windows.Forms.ComboBox();
            this.btnBakimaAl = new System.Windows.Forms.Button();
            this.btnBakimdanCikar = new System.Windows.Forms.Button();
            this.lblBakimDurum = new System.Windows.Forms.Label();

            this.pnlKiralama = new System.Windows.Forms.Panel();
            this.txtKiralamaAra = new System.Windows.Forms.TextBox();
            this.lvKiralamalar = new System.Windows.Forms.ListView();
            this.btnKiralamaIptal = new System.Windows.Forms.Button();

            this.pnlYorumlar = new System.Windows.Forms.Panel();
            this.lvYorumlar = new System.Windows.Forms.ListView();
            this.btnYorumSil = new System.Windows.Forms.Button();

            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlKartCiro.SuspendLayout();
            this.pnlKartAktif.SuspendLayout();
            this.pnlKartMusteri.SuspendLayout();
            this.pnlKartKupon.SuspendLayout();
            this.pnlFilo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.pnlFiloForm.SuspendLayout();
            this.pnlKiralama.SuspendLayout();
            this.pnlYorumlar.SuspendLayout();
            this.SuspendLayout();

            
            this.Text = "SUAL Araç Kiralama — Yönetici Paneli";
            this.ClientSize = new System.Drawing.Size(1220, 720);
            this.MinimumSize = new System.Drawing.Size(1050, 620);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 248);
            this.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.SizeChanged += new System.EventHandler(this.AdminForm_SizeChanged);

            
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 225;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(15, 25, 45);

            this.lblSidebarLogo.Text = "🛡️  SUAL Admin";
            this.lblSidebarLogo.Font = new System.Drawing.Font("Segoe UI", 15f, System.Drawing.FontStyle.Bold);
            this.lblSidebarLogo.ForeColor = System.Drawing.Color.White;
            this.lblSidebarLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblSidebarLogo.Location = new System.Drawing.Point(0, 18);
            this.lblSidebarLogo.Size = new System.Drawing.Size(225, 45);
            this.lblSidebarLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            System.Windows.Forms.Panel sideAyirici = new System.Windows.Forms.Panel();
            sideAyirici.Location = new System.Drawing.Point(20, 72);
            sideAyirici.Size = new System.Drawing.Size(185, 1);
            sideAyirici.BackColor = System.Drawing.Color.FromArgb(40, 60, 90);

            int sy = 90;
            SideBtn(this.btnDashboard, "📊   Dashboard", sy); sy += 52;
            SideBtn(this.btnFiloYonetimi, "🚗   Filo Yönetimi", sy); sy += 52;
            SideBtn(this.btnKiralamaTakip, "📋   Kiralama Takibi", sy); sy += 52;
            SideBtn(this.btnYorumPanel, "✍️   Yorumlar", sy);

            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnFiloYonetimi.Click += new System.EventHandler(this.btnFiloYonetimi_Click);
            this.btnKiralamaTakip.Click += new System.EventHandler(this.btnKiralamaTakip_Click);
            this.btnYorumPanel.Click += new System.EventHandler(this.btnYorumPanel_Click);

            this.btnAdminCikis.Text = "🔒   Çıkış Yap";
            this.btnAdminCikis.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnAdminCikis.ForeColor = System.Drawing.Color.FromArgb(240, 90, 90);
            this.btnAdminCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminCikis.FlatAppearance.BorderSize = 0;
            this.btnAdminCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(60, 20, 20);
            this.btnAdminCikis.Size = new System.Drawing.Size(225, 50);
            this.btnAdminCikis.Location = new System.Drawing.Point(0, 630);
            this.btnAdminCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminCikis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdminCikis.Click += new System.EventHandler(this.btnAdminCikis_Click);

            this.pnlSidebar.Controls.Add(this.lblSidebarLogo);
            this.pnlSidebar.Controls.Add(sideAyirici);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnFiloYonetimi);
            this.pnlSidebar.Controls.Add(this.btnKiralamaTakip);
            this.pnlSidebar.Controls.Add(this.btnYorumPanel);
            this.pnlSidebar.Controls.Add(this.btnAdminCikis);

            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;
            this.pnlHeader.BackColor = System.Drawing.Color.White;

            this.lblSayfaBaslik.Text = "📊  Dashboard";
            this.lblSayfaBaslik.Font = new System.Drawing.Font("Segoe UI", 15f, System.Drawing.FontStyle.Bold);
            this.lblSayfaBaslik.ForeColor = System.Drawing.Color.FromArgb(18, 30, 52);
            this.lblSayfaBaslik.Location = new System.Drawing.Point(18, 0);
            this.lblSayfaBaslik.Size = new System.Drawing.Size(450, 60);
            this.lblSayfaBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblAdminBilgi.Text = "👤  Yönetici Oturumu";
            this.lblAdminBilgi.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.lblAdminBilgi.ForeColor = System.Drawing.Color.FromArgb(130, 150, 180);
            this.lblAdminBilgi.Size = new System.Drawing.Size(250, 60);
            this.lblAdminBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.pnlHeader.Controls.Add(this.lblSayfaBaslik);
            this.pnlHeader.Controls.Add(this.lblAdminBilgi);

            
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(236, 240, 248);
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(20);

            StatKart(pnlKartCiro, lblCiroSayi, lblCiroBaslik, "0 ₺", "💰  Şirket Toplam Cirosu", System.Drawing.Color.FromArgb(230, 126, 34), 25, 25);
            StatKart(pnlKartAktif, lblAktifSayi, lblAktifBaslik, "0", "🚗  Aktif Kiralama", System.Drawing.Color.FromArgb(41, 128, 185), 255, 25);
            StatKart(pnlKartMusteri, lblMusteriSayi, lblMusteriBaslik, "0", "👥  Toplam Müşteri", System.Drawing.Color.FromArgb(39, 174, 96), 485, 25);
            StatKart(pnlKartKupon, lblKuponIcerik, lblKuponBaslik, "—", "🎟️  Kupon İstatistikleri", System.Drawing.Color.FromArgb(155, 89, 182), 715, 25);

            this.pnlDashboard.Controls.Add(this.pnlKartCiro);
            this.pnlDashboard.Controls.Add(this.pnlKartAktif);
            this.pnlDashboard.Controls.Add(this.pnlKartMusteri);
            this.pnlDashboard.Controls.Add(this.pnlKartKupon);

            
            this.pnlFilo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilo.BackColor = System.Drawing.Color.FromArgb(236, 240, 248);
            this.pnlFilo.Visible = false;

            this.dgvAraclar.Location = new System.Drawing.Point(15, 15);
            this.dgvAraclar.Size = new System.Drawing.Size(630, 590);
            this.dgvAraclar.BackgroundColor = System.Drawing.Color.White;
            this.dgvAraclar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAraclar.RowHeadersVisible = false;
            this.dgvAraclar.AllowUserToAddRows = false;
            this.dgvAraclar.AllowUserToDeleteRows = false;
            this.dgvAraclar.ReadOnly = true;
            this.dgvAraclar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAraclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAraclar.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.dgvAraclar.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 36, 58);
            this.dgvAraclar.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAraclar.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.dgvAraclar.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.dgvAraclar.EnableHeadersVisualStyles = false;
            this.dgvAraclar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.dgvAraclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAraclar_CellClick);

            
            this.pnlFiloForm.Location = new System.Drawing.Point(660, 15);
            this.pnlFiloForm.Size = new System.Drawing.Size(310, 590);
            this.pnlFiloForm.BackColor = System.Drawing.Color.White;
            this.pnlFiloForm.AutoScroll = true;
            this.pnlFiloForm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;

            this.lblFiloFormBaslik.Text = "🚗  Araç Ekle / Düzenle";
            this.lblFiloFormBaslik.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblFiloFormBaslik.ForeColor = System.Drawing.Color.FromArgb(18, 30, 52);
            this.lblFiloFormBaslik.Location = new System.Drawing.Point(0, 12);
            this.lblFiloFormBaslik.Size = new System.Drawing.Size(295, 32);
            this.lblFiloFormBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            int fy = 55;
            FiloAlan("Marka", this.txtMarka, ref fy);
            FiloAlan("Model", this.txtModel, ref fy);
            FiloAlan("Yıl", this.txtYil, ref fy);
            FiloAlan("Günlük Fiyat (₺)", this.txtFiyat, ref fy);

            System.Windows.Forms.Label lblSeg = new System.Windows.Forms.Label();
            lblSeg.Text = "Segment"; lblSeg.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            lblSeg.ForeColor = System.Drawing.Color.FromArgb(60, 80, 110);
            lblSeg.Location = new System.Drawing.Point(20, fy); lblSeg.Size = new System.Drawing.Size(260, 17);
            this.pnlFiloForm.Controls.Add(lblSeg); fy += 19;
            this.cmbSegment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSegment.Items.AddRange(new object[] { "Ekonomi", "Orta", "SUV", "Premium" });
            this.cmbSegment.SelectedIndex = 0;
            this.cmbSegment.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.cmbSegment.Location = new System.Drawing.Point(20, fy);
            this.cmbSegment.Size = new System.Drawing.Size(260, 28);
            this.pnlFiloForm.Controls.Add(this.cmbSegment); fy += 42;

            
            this.btnAracEkle.Text = "➕  Yeni Araç Ekle";
            this.btnAracEkle.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnAracEkle.ForeColor = System.Drawing.Color.White;
            this.btnAracEkle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAracEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracEkle.FlatAppearance.BorderSize = 0;
            this.btnAracEkle.Location = new System.Drawing.Point(20, fy);
            this.btnAracEkle.Size = new System.Drawing.Size(260, 38);
            this.btnAracEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            this.pnlFiloForm.Controls.Add(this.btnAracEkle); fy += 44;

            this.btnAracGuncelle.Text = "✏️  Seçili Aracı Güncelle";
            this.btnAracGuncelle.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnAracGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnAracGuncelle.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnAracGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracGuncelle.FlatAppearance.BorderSize = 0;
            this.btnAracGuncelle.Location = new System.Drawing.Point(20, fy);
            this.btnAracGuncelle.Size = new System.Drawing.Size(260, 38);
            this.btnAracGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAracGuncelle.Click += new System.EventHandler(this.btnAracGuncelle_Click);
            this.pnlFiloForm.Controls.Add(this.btnAracGuncelle); fy += 44;

            this.btnAracSil.Text = "🗑️  Seçili Aracı Sil";
            this.btnAracSil.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnAracSil.ForeColor = System.Drawing.Color.White;
            this.btnAracSil.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnAracSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracSil.FlatAppearance.BorderSize = 0;
            this.btnAracSil.Location = new System.Drawing.Point(20, fy);
            this.btnAracSil.Size = new System.Drawing.Size(260, 38);
            this.btnAracSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            this.pnlFiloForm.Controls.Add(this.btnAracSil); fy += 50;

            
            System.Windows.Forms.Panel bakimAyirici = new System.Windows.Forms.Panel();
            bakimAyirici.Location = new System.Drawing.Point(20, fy);
            bakimAyirici.Size = new System.Drawing.Size(260, 1);
            bakimAyirici.BackColor = System.Drawing.Color.FromArgb(220, 225, 235);
            this.pnlFiloForm.Controls.Add(bakimAyirici); fy += 12;

            this.lblBakimBaslik.Text = "🔧  Bakım Yönetimi";
            this.lblBakimBaslik.Font = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.lblBakimBaslik.ForeColor = System.Drawing.Color.FromArgb(18, 30, 52);
            this.lblBakimBaslik.Location = new System.Drawing.Point(20, fy);
            this.lblBakimBaslik.Size = new System.Drawing.Size(260, 28);
            this.pnlFiloForm.Controls.Add(this.lblBakimBaslik); fy += 32;

            System.Windows.Forms.Label lblBakimSehirEtiket = new System.Windows.Forms.Label();
            lblBakimSehirEtiket.Text = "Şehir Seçin"; lblBakimSehirEtiket.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            lblBakimSehirEtiket.ForeColor = System.Drawing.Color.FromArgb(60, 80, 110);
            lblBakimSehirEtiket.Location = new System.Drawing.Point(20, fy); lblBakimSehirEtiket.Size = new System.Drawing.Size(260, 17);
            this.pnlFiloForm.Controls.Add(lblBakimSehirEtiket); fy += 19;

            this.cmbBakimSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBakimSehir.Font = new System.Drawing.Font("Segoe UI", 10f);
            this.cmbBakimSehir.Location = new System.Drawing.Point(20, fy);
            this.cmbBakimSehir.Size = new System.Drawing.Size(260, 28);
            this.pnlFiloForm.Controls.Add(this.cmbBakimSehir); fy += 38;

            this.btnBakimaAl.Text = "🚫  Bu Şehirde Bakıma Al";
            this.btnBakimaAl.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnBakimaAl.ForeColor = System.Drawing.Color.White;
            this.btnBakimaAl.BackColor = System.Drawing.Color.FromArgb(211, 84, 0);
            this.btnBakimaAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakimaAl.FlatAppearance.BorderSize = 0;
            this.btnBakimaAl.Location = new System.Drawing.Point(20, fy);
            this.btnBakimaAl.Size = new System.Drawing.Size(260, 36);
            this.btnBakimaAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBakimaAl.Click += new System.EventHandler(this.btnBakimaAl_Click);
            this.pnlFiloForm.Controls.Add(this.btnBakimaAl); fy += 42;

            this.btnBakimdanCikar.Text = "✅  Bu Şehirde Bakımdan Çıkar";
            this.btnBakimdanCikar.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnBakimdanCikar.ForeColor = System.Drawing.Color.White;
            this.btnBakimdanCikar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnBakimdanCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakimdanCikar.FlatAppearance.BorderSize = 0;
            this.btnBakimdanCikar.Location = new System.Drawing.Point(20, fy);
            this.btnBakimdanCikar.Size = new System.Drawing.Size(260, 36);
            this.btnBakimdanCikar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBakimdanCikar.Click += new System.EventHandler(this.btnBakimdanCikar_Click);
            this.pnlFiloForm.Controls.Add(this.btnBakimdanCikar); fy += 42;

            this.lblBakimDurum.Text = "";
            this.lblBakimDurum.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Italic);
            this.lblBakimDurum.ForeColor = System.Drawing.Color.FromArgb(180, 80, 30);
            this.lblBakimDurum.Location = new System.Drawing.Point(20, fy);
            this.lblBakimDurum.Size = new System.Drawing.Size(260, 50);
            this.pnlFiloForm.Controls.Add(this.lblBakimDurum);

            this.pnlFiloForm.Controls.Add(this.lblFiloFormBaslik);
            this.pnlFilo.Controls.Add(this.dgvAraclar);
            this.pnlFilo.Controls.Add(this.pnlFiloForm);

            
            this.pnlKiralama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKiralama.BackColor = System.Drawing.Color.FromArgb(236, 240, 248);
            this.pnlKiralama.Visible = false;

            this.txtKiralamaAra.Font = new System.Drawing.Font("Segoe UI", 11f);
            this.txtKiralamaAra.Location = new System.Drawing.Point(15, 15);
            this.txtKiralamaAra.Size = new System.Drawing.Size(400, 30);
            this.txtKiralamaAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKiralamaAra.BackColor = System.Drawing.Color.White;
            this.txtKiralamaAra.ForeColor = System.Drawing.Color.Gray;
            this.txtKiralamaAra.Text = "🔍  TC veya Müşteri Adı ile Ara...";
            this.txtKiralamaAra.Enter += new System.EventHandler(this.txtKiralamaAra_Enter);
            this.txtKiralamaAra.Leave += new System.EventHandler(this.txtKiralamaAra_Leave);
            this.txtKiralamaAra.TextChanged += new System.EventHandler(this.txtKiralamaAra_TextChanged);

            
            this.btnKiralamaIptal.Text = "❌  Seçili Kiralamayı İptal Et";
            this.btnKiralamaIptal.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnKiralamaIptal.ForeColor = System.Drawing.Color.White;
            this.btnKiralamaIptal.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnKiralamaIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiralamaIptal.FlatAppearance.BorderSize = 0;
            this.btnKiralamaIptal.Location = new System.Drawing.Point(430, 13);
            this.btnKiralamaIptal.Size = new System.Drawing.Size(270, 34);
            this.btnKiralamaIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiralamaIptal.Click += new System.EventHandler(this.btnKiralamaIptal_Click);

            this.lvKiralamalar.Location = new System.Drawing.Point(15, 55);
            this.lvKiralamalar.Size = new System.Drawing.Size(950, 555);
            this.lvKiralamalar.View = System.Windows.Forms.View.Details;
            this.lvKiralamalar.FullRowSelect = true;
            this.lvKiralamalar.GridLines = true;
            this.lvKiralamalar.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.lvKiralamalar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lvKiralamalar.Columns.Add("ID", 42);
            this.lvKiralamalar.Columns.Add("Müşteri (TC)", 210);
            this.lvKiralamalar.Columns.Add("Araç", 150);
            this.lvKiralamalar.Columns.Add("Şehir", 100);
            this.lvKiralamalar.Columns.Add("Başlangıç", 95);
            this.lvKiralamalar.Columns.Add("Bitiş", 95);
            this.lvKiralamalar.Columns.Add("Tutar", 90);
            this.lvKiralamalar.Columns.Add("Kupon", 80);
            this.lvKiralamalar.Columns.Add("Durum", 85);

            this.pnlKiralama.Controls.Add(this.txtKiralamaAra);
            this.pnlKiralama.Controls.Add(this.btnKiralamaIptal);
            this.pnlKiralama.Controls.Add(this.lvKiralamalar);

            
            this.pnlYorumlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlYorumlar.BackColor = System.Drawing.Color.FromArgb(236, 240, 248);
            this.pnlYorumlar.Visible = false;

            this.lvYorumlar.Location = new System.Drawing.Point(15, 15);
            this.lvYorumlar.Size = new System.Drawing.Size(950, 545);
            this.lvYorumlar.View = System.Windows.Forms.View.Details;
            this.lvYorumlar.FullRowSelect = true;
            this.lvYorumlar.GridLines = true;
            this.lvYorumlar.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.lvYorumlar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lvYorumlar.Columns.Add("ID", 42);
            this.lvYorumlar.Columns.Add("Müşteri", 160);
            this.lvYorumlar.Columns.Add("Araç", 170);
            this.lvYorumlar.Columns.Add("Puan", 110);
            this.lvYorumlar.Columns.Add("Yorum", 460);

            this.btnYorumSil.Text = "🗑️  Seçili Yorumu Sil";
            this.btnYorumSil.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnYorumSil.ForeColor = System.Drawing.Color.White;
            this.btnYorumSil.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnYorumSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYorumSil.FlatAppearance.BorderSize = 0;
            this.btnYorumSil.Location = new System.Drawing.Point(15, 570);
            this.btnYorumSil.Size = new System.Drawing.Size(220, 42);
            this.btnYorumSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYorumSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnYorumSil.Click += new System.EventHandler(this.btnYorumSil_Click);

            this.pnlYorumlar.Controls.Add(this.lvYorumlar);
            this.pnlYorumlar.Controls.Add(this.btnYorumSil);

            
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlFilo);
            this.Controls.Add(this.pnlKiralama);
            this.Controls.Add(this.pnlYorumlar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlKartCiro.ResumeLayout(false);
            this.pnlKartAktif.ResumeLayout(false);
            this.pnlKartMusteri.ResumeLayout(false);
            this.pnlKartKupon.ResumeLayout(false);
            this.pnlFilo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.pnlFiloForm.ResumeLayout(false);
            this.pnlFiloForm.PerformLayout();
            this.pnlKiralama.ResumeLayout(false);
            this.pnlKiralama.PerformLayout();
            this.pnlYorumlar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void SideBtn(System.Windows.Forms.Button btn, string text, int y)
        {
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 10.5f);
            btn.ForeColor = System.Drawing.Color.FromArgb(170, 192, 225);
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(28, 45, 75);
            btn.Location = new System.Drawing.Point(0, y);
            btn.Size = new System.Drawing.Size(225, 48);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
        }

        private void StatKart(System.Windows.Forms.Panel pnl, System.Windows.Forms.Label lblSayi, System.Windows.Forms.Label lblBaslik, string sayi, string baslik, System.Drawing.Color renk, int x, int y)
        {
            pnl.Location = new System.Drawing.Point(x, y); pnl.Size = new System.Drawing.Size(215, 120); pnl.BackColor = System.Drawing.Color.White;
            System.Windows.Forms.Panel serit = new System.Windows.Forms.Panel();
            serit.Dock = System.Windows.Forms.DockStyle.Top; serit.Height = 5; serit.BackColor = renk; pnl.Controls.Add(serit);
            lblSayi.Text = sayi; lblSayi.Font = new System.Drawing.Font("Segoe UI", 18f, System.Drawing.FontStyle.Bold); lblSayi.ForeColor = System.Drawing.Color.FromArgb(18, 30, 52); lblSayi.Location = new System.Drawing.Point(14, 20); lblSayi.Size = new System.Drawing.Size(190, 45); pnl.Controls.Add(lblSayi);
            lblBaslik.Text = baslik; lblBaslik.Font = new System.Drawing.Font("Segoe UI", 8.5f); lblBaslik.ForeColor = System.Drawing.Color.FromArgb(120, 145, 175); lblBaslik.Location = new System.Drawing.Point(14, 72); lblBaslik.Size = new System.Drawing.Size(190, 35); pnl.Controls.Add(lblBaslik);
        }

        private void FiloAlan(string etiket, System.Windows.Forms.TextBox txt, ref int y)
        {
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            lbl.Text = etiket; lbl.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(60, 80, 110); lbl.Location = new System.Drawing.Point(20, y); lbl.Size = new System.Drawing.Size(260, 17);
            this.pnlFiloForm.Controls.Add(lbl); y += 19;
            txt.Font = new System.Drawing.Font("Segoe UI", 10f); txt.Location = new System.Drawing.Point(20, y); txt.Size = new System.Drawing.Size(260, 28);
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; txt.BackColor = System.Drawing.Color.FromArgb(246, 249, 255);
            this.pnlFiloForm.Controls.Add(txt); y += 40;
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnFiloYonetimi;
        private System.Windows.Forms.Button btnKiralamaTakip;
        private System.Windows.Forms.Button btnYorumPanel;
        private System.Windows.Forms.Button btnAdminCikis;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSayfaBaslik;
        private System.Windows.Forms.Label lblAdminBilgi;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlKartCiro;
        private System.Windows.Forms.Label lblCiroSayi;
        private System.Windows.Forms.Label lblCiroBaslik;
        private System.Windows.Forms.Panel pnlKartAktif;
        private System.Windows.Forms.Label lblAktifSayi;
        private System.Windows.Forms.Label lblAktifBaslik;
        private System.Windows.Forms.Panel pnlKartMusteri;
        private System.Windows.Forms.Label lblMusteriSayi;
        private System.Windows.Forms.Label lblMusteriBaslik;
        private System.Windows.Forms.Panel pnlKartKupon;
        private System.Windows.Forms.Label lblKuponIcerik;
        private System.Windows.Forms.Label lblKuponBaslik;
        private System.Windows.Forms.Panel pnlFilo;
        private System.Windows.Forms.DataGridView dgvAraclar;
        private System.Windows.Forms.Panel pnlFiloForm;
        private System.Windows.Forms.Label lblFiloFormBaslik;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ComboBox cmbSegment;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAracGuncelle;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Label lblBakimBaslik;
        private System.Windows.Forms.ComboBox cmbBakimSehir;
        private System.Windows.Forms.Button btnBakimaAl;
        private System.Windows.Forms.Button btnBakimdanCikar;
        private System.Windows.Forms.Label lblBakimDurum;
        private System.Windows.Forms.Panel pnlKiralama;
        private System.Windows.Forms.TextBox txtKiralamaAra;
        private System.Windows.Forms.ListView lvKiralamalar;
        private System.Windows.Forms.Button btnKiralamaIptal;
        private System.Windows.Forms.Panel pnlYorumlar;
        private System.Windows.Forms.ListView lvYorumlar;
        private System.Windows.Forms.Button btnYorumSil;
    }
}