using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SUAL_AracKiralama
{
    public partial class MusteriForm : Form
    {
        private MusteriModel _musteri;
        private string _girisKullaniciAdi;
        private DateTime _secilenBaslangic;
        private DateTime _secilenBitis;
        private string _secilenSehir;
        private HashSet<int> _bakimdakiAracIdleri = new HashSet<int>();

        
        private Panel pnlTcGirisKapisi;
        private TextBox txtTcGiris;
        private Button btnTcGirisYap;
        private Button btnTcKayitModunaGec;

        private TextBox txtYeniAd;
        private TextBox txtYeniSoyad;
        private TextBox txtYeniTc;
        private Button btnYeniKayitOl;
        private Button btnGeriDon;
        private Label lblKapiBaslik;

         
        private Label lblYeniAd;
        private Label lblYeniSoyad;
        private Label lblYeniTc;

        private static readonly string[] Iller = new string[]
        {
            "Adana","Adıyaman","Afyonkarahisar","Ağrı","Amasya","Ankara","Antalya",
            "Artvin","Aydın","Balıkesir","Bilecik","Bingöl","Bitlis","Bolu","Burdur",
            "Bursa","Çanakkale","Çankırı","Çorum","Denizli","Diyarbakır","Edirne",
            "Elazığ","Erzincan","Erzurum","Eskişehir","Gaziantep","Giresun","Gümüşhane",
            "Hakkari","Hatay","Isparta","Mersin","İstanbul","İzmir","Kars","Kastamonu",
            "Kayseri","Kırklareli","Kırşehir","Kocaeli","Konya","Kütahya","Malatya",
            "Manisa","Kahramanmaraş","Mardin","Muğla","Muş","Nevşehir","Niğde","Ordu",
            "Rize","Sakarya","Samsun","Siirt","Sinop","Sivas","Tekirdağ","Tokat",
            "Trabzon","Tunceli","Şanlıurfa","Uşak","Van","Yozgat","Zonguldak","Aksaray",
            "Bayburt","Karaman","Kırıkkale","Batman","Şırnak","Bartın","Ardahan","Iğdır",
            "Yalova","Karabük","Kilis","Osmaniye","Düzce"
        };

        public MusteriForm(string kullaniciAdi)
        {
            InitializeComponent();
            _girisKullaniciAdi = kullaniciAdi;
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            cmbSehir.Items.AddRange(Iller);
            cmbSehir.SelectedIndex = 33; 

            
            pnlKiralama.Visible = false;
            pnlKiralamalarim.Visible = false;
            pnlKayit.Visible = false;


            
            KapiTasariminiOlustur();

            PanelleriYenidenBoyutlandir();
            flowAraclar.AutoScroll = true;
        }

        
        private void KapiTasariminiOlustur()
        {
            pnlTcGirisKapisi = new Panel();
            pnlTcGirisKapisi.Size = new Size(400, 300);
            pnlTcGirisKapisi.BackColor = Color.FromArgb(30, 48, 72);
            pnlTcGirisKapisi.Location = new Point((this.ClientSize.Width - 400) / 2, (this.ClientSize.Height - 300) / 2);
            this.Controls.Add(pnlTcGirisKapisi);
            pnlTcGirisKapisi.BringToFront();

            lblKapiBaslik = new Label();
            lblKapiBaslik.Text = "👤 Müşteri Kimlik Doğrulama";
            lblKapiBaslik.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
            lblKapiBaslik.ForeColor = Color.White;
            lblKapiBaslik.Location = new Point(20, 20);
            lblKapiBaslik.Size = new Size(360, 30);
            lblKapiBaslik.TextAlign = ContentAlignment.MiddleCenter;
            pnlTcGirisKapisi.Controls.Add(lblKapiBaslik);

            
            txtTcGiris = new TextBox();
            txtTcGiris.Font = new Font("Segoe UI", 12f);
            txtTcGiris.Location = new Point(80, 100);
            txtTcGiris.Size = new Size(240, 30);
            txtTcGiris.Text = "Müşteri TC girin";
            txtTcGiris.ForeColor = Color.Gray;
            txtTcGiris.Enter += (s, e) => { if (txtTcGiris.Text == "Müşteri TC girin") { txtTcGiris.Text = ""; txtTcGiris.ForeColor = Color.Black; } };
            pnlTcGirisKapisi.Controls.Add(txtTcGiris);

            btnTcGirisYap = new Button();
            btnTcGirisYap.Text = "TC ile Giriş Yap ➔";
            btnTcGirisYap.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            btnTcGirisYap.BackColor = Color.FromArgb(41, 128, 185);
            btnTcGirisYap.ForeColor = Color.White;
            btnTcGirisYap.FlatStyle = FlatStyle.Flat;
            btnTcGirisYap.Location = new Point(80, 150);
            btnTcGirisYap.Size = new Size(240, 40);
            btnTcGirisYap.Click += BtnTcGirisYap_Click;
            pnlTcGirisKapisi.Controls.Add(btnTcGirisYap);

            btnTcKayitModunaGec = new Button();
            btnTcKayitModunaGec.Text = "Sistemde Kayıtlı Değil mi? Yeni Kayıt Oluştur";
            btnTcKayitModunaGec.Font = new Font("Segoe UI", 9f, FontStyle.Underline);
            btnTcKayitModunaGec.ForeColor = Color.FromArgb(155, 178, 205);
            btnTcKayitModunaGec.FlatStyle = FlatStyle.Flat;
            btnTcKayitModunaGec.FlatAppearance.BorderSize = 0;
            btnTcKayitModunaGec.Location = new Point(40, 220);
            btnTcKayitModunaGec.Size = new Size(320, 30);
            btnTcKayitModunaGec.Click += (s, e) => KayitModunuGoster(true);
            pnlTcGirisKapisi.Controls.Add(btnTcKayitModunaGec);

            
            txtYeniAd = new TextBox() { Font = new Font("Segoe UI", 11f), Location = new Point(130, 70), Size = new Size(200, 28), Visible = false };
            txtYeniSoyad = new TextBox() { Font = new Font("Segoe UI", 11f), Location = new Point(130, 110), Size = new Size(200, 28), Visible = false };
            txtYeniTc = new TextBox() { Font = new Font("Segoe UI", 11f), Location = new Point(130, 150), Size = new Size(200, 28), Visible = false };

            
            lblYeniAd = new Label() { Text = "Ad:", ForeColor = Color.White, Font = new Font("Segoe UI", 10f, FontStyle.Bold), Location = new Point(40, 73), Size = new Size(80, 20), Visible = false };
            lblYeniSoyad = new Label() { Text = "Soyad:", ForeColor = Color.White, Font = new Font("Segoe UI", 10f, FontStyle.Bold), Location = new Point(40, 113), Size = new Size(80, 20), Visible = false };
            lblYeniTc = new Label() { Text = "TC Kimlik:", ForeColor = Color.White, Font = new Font("Segoe UI", 10f, FontStyle.Bold), Location = new Point(40, 153), Size = new Size(80, 20), Visible = false };

            btnYeniKayitOl = new Button() { Text = "Sisteme Kaydet ve Giriş Yap", Font = new Font("Segoe UI", 10f, FontStyle.Bold), BackColor = Color.FromArgb(46, 204, 113), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(130, 200), Size = new Size(200, 35), Visible = false };
            btnGeriDon = new Button() { Text = "✕ İptal", Font = new Font("Segoe UI", 9f), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(20, 250), Size = new Size(80, 30), Visible = false };

            btnYeniKayitOl.Click += BtnYeniKayitOl_Click;
            btnGeriDon.Click += (s, e) => KayitModunuGoster(false);

            pnlTcGirisKapisi.Controls.AddRange(new Control[] { txtYeniAd, txtYeniSoyad, txtYeniTc, lblYeniAd, lblYeniSoyad, lblYeniTc, btnYeniKayitOl, btnGeriDon });
        }

        private void KayitModunuGoster(bool kayitModuMu)
        {
            lblKapiBaslik.Text = kayitModuMu ? "👤 Yeni Müşteri Kaydı" : "👤 Müşteri Kimlik Doğrulama";
            txtTcGiris.Visible = !kayitModuMu;
            btnTcGirisYap.Visible = !kayitModuMu;
            btnTcKayitModunaGec.Visible = !kayitModuMu;

            txtYeniAd.Visible = kayitModuMu;
            txtYeniSoyad.Visible = kayitModuMu;
            txtYeniTc.Visible = kayitModuMu;
            btnYeniKayitOl.Visible = kayitModuMu;
            btnGeriDon.Visible = kayitModuMu;

            
            lblYeniAd.Visible = kayitModuMu;
            lblYeniSoyad.Visible = kayitModuMu;
            lblYeniTc.Visible = kayitModuMu;

            if (kayitModuMu)
            {
                pnlTcGirisKapisi.Invalidate();
            }
        }

        
        private void BtnTcGirisYap_Click(object sender, EventArgs e)
        {
            string tcInput = txtTcGiris.Text.Trim();

            
            if (tcInput.Length != 11 || !long.TryParse(tcInput, out _))
            {
                MessageBox.Show("Lütfen geçerli ve 11 haneli bir TC Kimlik Numarası girin ", "Geçersiz TC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _musteri = DatabaseHelper.MusteriGetirVeTcKontrolEt(tcInput);

            if (_musteri != null)
            {
                lblKullanici.Text = "Hoş Geldiniz,  " + _musteri.AdSoyad;
                pnlTcGirisKapisi.Visible = false;
                pnlKiralama.Visible = true;
                pnlKiralama.BringToFront();
                MessageBox.Show($"Oturum Açıldı: {_musteri.AdSoyad}", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult cevap = MessageBox.Show("Bu TC numarası sistemde kayıtlı değil! Yeni kayıt oluşturmak ister misin?", "Müşteri Bulunamadı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    KayitModunuGoster(true);
                    txtYeniTc.Text = tcInput;
                }
            }
        }

        
        private void BtnYeniKayitOl_Click(object sender, EventArgs e)
        {
            string ad = txtYeniAd.Text.Trim();
            string soyad = txtYeniSoyad.Text.Trim();
            string tc = txtYeniTc.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(tc))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldur!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (tc.Length != 11 || !long.TryParse(tc, out _))
            {
                MessageBox.Show("Yeni kayıt için girdiğiniz TC Kimlik Numarası 11 haneli ve sadece rakamlardan oluşmalıdır!", "Geçersiz TC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rastgeleKullaniciAdi = ad.ToLower() + tc;

            MusteriModel yeniMusteri = new MusteriModel
            {
                KullaniciAdi = rastgeleKullaniciAdi,
                Ad = ad,
                Soyad = soyad,
                TcKimlik = tc
            };

            bool basarili = DatabaseHelper.MusteriKaydet(yeniMusteri);

            if (basarili)
            {
                _musteri = DatabaseHelper.MusteriGetir(rastgeleKullaniciAdi);
                lblKullanici.Text = "Hoş Geldiniz,  " + _musteri.AdSoyad;

                pnlTcGirisKapisi.Visible = false;
                pnlKiralama.Visible = true;
                pnlKiralama.BringToFront();

                MessageBox.Show($"Yeni müşteri '{_musteri.AdSoyad}' başarıyla kaydedildi ve oturum açıldı 🎉", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik numarasıyla başka bir müşteri zaten var", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MusteriForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) return;
            PanelleriYenidenBoyutlandir();

            if (pnlTcGirisKapisi != null && pnlTcGirisKapisi.Visible)
            {
                pnlTcGirisKapisi.Location = new Point((this.ClientSize.Width - 400) / 2, (this.ClientSize.Height - 300) / 2);
            }
        }

        private void PanelleriYenidenBoyutlandir()
        {
            int icerikYuksekligi = this.ClientSize.Height - 62;

            pnlFiltre.Height = icerikYuksekligi;
            pnlSonuclar.Width = this.ClientSize.Width - 255;
            pnlSonuclar.Height = icerikYuksekligi;

            
            flowAraclar.Left = 10;
            flowAraclar.Top = 55;
            flowAraclar.Width = pnlSonuclar.Width - 20;
            flowAraclar.Height = pnlSonuclar.Height - 75; 
            flowAraclar.AutoScroll = true; 

            lvKiralamalar.Width = this.ClientSize.Width - 60;
            lvKiralamalar.Height = icerikYuksekligi - 80;

            btnCikis.Location = new Point(this.ClientSize.Width - 115, 12);
            btnKiralamalarim.Location = new Point(this.ClientSize.Width - 270, 12);
        }

        private void EkraniGoster(string ekran)
        {
            pnlKiralama.Visible = (ekran == "kiralama");
            pnlKiralamalarim.Visible = (ekran == "kiralamalarim");

            if (ekran == "kiralama")
                pnlKiralama.BringToFront();
            else if (ekran == "kiralamalarim")
            {
                pnlKiralamalarim.BringToFront();
                KiralamalariniYukle();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (cmbSehir.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir şehir seçiniz.", "Şehir Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime bas = dtpBaslangic.Value.Date;
            DateTime bit = dtpBitis.Value.Date;

            if (bas >= bit)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden sonra olmalıdır.", "Tarih Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _secilenSehir = cmbSehir.SelectedItem.ToString();
            _secilenBaslangic = bas;
            _secilenBitis = bit;

            string segment = cmbSegment.SelectedItem != null ? cmbSegment.SelectedItem.ToString() : "Tümü";

            List<ArabaModel> arabalar = DatabaseHelper.MuasaitAraclariGetir(_secilenSehir, _secilenBaslangic, _secilenBitis, segment);
            _bakimdakiAracIdleri = DatabaseHelper.BakimdakiAracIdleri(_secilenSehir);
            AraclariListele(arabalar);
        }

        private void AraclariListele(List<ArabaModel> arabalar)
        {
            flowAraclar.Controls.Clear();
            int gunSayisi = (_secilenBitis - _secilenBaslangic).Days;

            if (arabalar.Count == 0)
            {
                lblSonucBaslik.Text = "Seçilen kriterlere uygun müsait araç bulunamadı.";
                lblSonucSayisi.Text = "0 araç";
                return;
            }

            lblSonucBaslik.Text = _secilenSehir + " — " + _secilenBaslangic.ToString("dd MMM") + " › " + _secilenBitis.ToString("dd MMM yyyy") + "  |  Müsait Araçlar";
            lblSonucSayisi.Text = arabalar.Count + " araç listelendi";

            foreach (ArabaModel araba in arabalar)
            {
                Panel kart = ArabaKartiOlustur(araba, gunSayisi);
                flowAraclar.Controls.Add(kart);
            }
        }

        private Panel ArabaKartiOlustur(ArabaModel araba, int gunSayisi)
        {
            Color segmentRenk;
            switch (araba.Segment)
            {
                case "Premium": segmentRenk = Color.FromArgb(155, 89, 182); break;
                case "SUV": segmentRenk = Color.FromArgb(39, 174, 96); break;
                case "Orta": segmentRenk = Color.FromArgb(41, 128, 185); break;
                default: segmentRenk = Color.FromArgb(149, 165, 166); break;  
            }

            Panel kart = new Panel();
            kart.Size = new Size(200, 280);
            kart.BackColor = Color.White;
            kart.Margin = new Padding(10);
            kart.Cursor = Cursors.Hand;

            
            Panel serit = new Panel() { Location = new Point(0, 0), Size = new Size(200, 6), BackColor = segmentRenk };

            
            PictureBox pbAraba = new PictureBox();
            pbAraba.Location = new Point(10, 12);
            pbAraba.Size = new Size(180, 75);
            pbAraba.SizeMode = PictureBoxSizeMode.Zoom; 
            pbAraba.BackColor = Color.White;

            try
            {
                
                object gorsel = Properties.Resources.ResourceManager.GetObject(araba.GorselAdi);
                if (gorsel != null)
                {
                    pbAraba.Image = (Image)gorsel;
                }
            }
            catch (Exception)
            {
                
            }

            Label lblAd = new Label() { Text = araba.TamAdi, Font = new Font("Segoe UI", 10.5f, FontStyle.Bold), ForeColor = Color.FromArgb(22, 36, 58), Location = new Point(5, 95), Size = new Size(190, 22), TextAlign = ContentAlignment.MiddleCenter };
            Label lblDetay = new Label() { Text = araba.Yil + "  ·  " + araba.Segment, Font = new Font("Segoe UI", 8.5f), ForeColor = Color.FromArgb(120, 140, 165), Location = new Point(5, 118), Size = new Size(190, 18), TextAlign = ContentAlignment.MiddleCenter };
            
            string puanDurumu = DatabaseHelper.ArabaPuanDurumuGetir(araba.Id);
            Label lblPuan = new Label() { Text = puanDurumu, Font = new Font("Segoe UI", 8.5f, FontStyle.Bold), ForeColor = Color.FromArgb(230, 126, 34), Location = new Point(5, 138), Size = new Size(190, 18), TextAlign = ContentAlignment.MiddleCenter };
            Panel cizgi = new Panel() { Location = new Point(20, 160), Size = new Size(160, 1), BackColor = Color.FromArgb(220, 225, 235) };
            Label lblFiyat = new Label() { Text = araba.GunlukFiyat.ToString("N0") + " ₺ / gün", Font = new Font("Segoe UI", 12f, FontStyle.Bold), ForeColor = Color.FromArgb(41, 128, 185), Location = new Point(5, 168), Size = new Size(190, 25), TextAlign = ContentAlignment.MiddleCenter };

            double toplam = araba.GunlukFiyat * gunSayisi;
            Label lblToplam = new Label() { Text = gunSayisi + " gün = " + toplam.ToString("N0") + " ₺", Font = new Font("Segoe UI", 8f), ForeColor = Color.FromArgb(100, 120, 150), Location = new Point(5, 195), Size = new Size(190, 16), TextAlign = ContentAlignment.MiddleCenter };

            Button btnKirala = new Button() { Text = "Kirala", Font = new Font("Segoe UI", 10f, FontStyle.Bold), ForeColor = Color.White, BackColor = segmentRenk, FlatStyle = FlatStyle.Flat, Location = new Point(15, 220), Size = new Size(170, 42), Cursor = Cursors.Hand };
            btnKirala.FlatAppearance.BorderSize = 0;

            ArabaModel arabaRef = araba;
            double toplamRef = toplam;
            btnKirala.Click += delegate { KiralamaOnay(arabaRef, toplamRef, gunSayisi); };

            bool bakimda = _bakimdakiAracIdleri.Contains(araba.Id);
            if (bakimda)
            {
                kart.BackColor = Color.FromArgb(235, 235, 235);
                serit.BackColor = Color.FromArgb(160, 160, 160);
                lblAd.ForeColor = Color.Gray;
                lblFiyat.ForeColor = Color.Gray;
                btnKirala.Enabled = false;
                btnKirala.BackColor = Color.FromArgb(180, 180, 180);
                btnKirala.ForeColor = Color.FromArgb(120, 120, 120);
                btnKirala.Text = "🔧 Bakımda";
                btnKirala.Cursor = Cursors.Default;
                Label lblBakimda = new Label()
                {
                    Text = "🔧 BAKIMDA",
                    Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(192, 57, 43),
                    BackColor = Color.FromArgb(253, 237, 236),
                    Location = new Point(40, 195),
                    Size = new Size(120, 22),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                kart.Controls.Add(lblBakimda);
            }

            kart.Controls.AddRange(new Control[] { serit, pbAraba, lblAd, lblDetay, cizgi, lblFiyat, lblToplam, btnKirala,lblPuan });
            return kart;
        }

        private void KiralamaOnay(ArabaModel araba, double ilkToplamFiyat, int gunSayisi)
        {
            
            double sonFiyat = ilkToplamFiyat;

            Form frmOnay = new Form();
            frmOnay.Size = new Size(380, 420);
            frmOnay.Text = "🔒 Kiralama Onayı";
            frmOnay.StartPosition = FormStartPosition.CenterParent;
            frmOnay.FormBorderStyle = FormBorderStyle.FixedDialog;
            frmOnay.MaximizeBox = false;
            frmOnay.MinimizeBox = false;
            frmOnay.BackColor = Color.FromArgb(245, 247, 250);

            Label lblBilgi = new Label() { Text = $"🚗 {araba.TamAdi}\n📍 Şehir: {cmbSehir.Text}\n📅 Süre: {gunSayisi} Gün", Font = new Font("Segoe UI", 11f), Location = new Point(20, 20), Size = new Size(320, 70), ForeColor = Color.FromArgb(40, 50, 70) };

            
            Label lblFiyatBaslik = new Label() { Text = "Toplam Tutar:", Font = new Font("Segoe UI", 10f), Location = new Point(20, 105), Size = new Size(120, 20), ForeColor = Color.Gray };
            Label lblFiyat = new Label() { Text = ilkToplamFiyat.ToString("N0") + " ₺", Font = new Font("Segoe UI", 16f, FontStyle.Bold), Location = new Point(20, 125), Size = new Size(320, 35), ForeColor = Color.FromArgb(41, 128, 185) };

            
            Label lblKuponBaslik = new Label() { Text = "🎁 Mevcut Kampanyalar / Kuponlar:", Font = new Font("Segoe UI", 9.5f, FontStyle.Bold), Location = new Point(20, 180), Size = new Size(320, 20), ForeColor = Color.FromArgb(22, 36, 58) };

            ComboBox cmbKuponlar = new ComboBox() { Location = new Point(20, 205), Size = new Size(320, 30), Font = new Font("Segoe UI", 10f), DropDownStyle = ComboBoxStyle.DropDownList };
            cmbKuponlar.Items.AddRange(new string[] { "Kupon Yok", "ALIM20 (%20 İndirim)", "COMU2026 (%20 İndirim)","SUDE30 (%30 İndirim)" });
            cmbKuponlar.SelectedIndex = 0;

            
            cmbKuponlar.SelectedIndexChanged += (s, e) =>
            {
                if (cmbKuponlar.SelectedIndex > 0) 
                {
                    sonFiyat = ilkToplamFiyat * 0.8; 
                    lblFiyat.Text = sonFiyat.ToString("N0") + " ₺ (Kupon Uygulandı! 🎉)";
                    lblFiyat.ForeColor = Color.FromArgb(39, 174, 96); 
                }
                else
                {
                    sonFiyat = ilkToplamFiyat;
                    lblFiyat.Text = ilkToplamFiyat.ToString("N0") + " ₺";
                    lblFiyat.ForeColor = Color.FromArgb(41, 128, 185);
                }
            };

            Button btnOnayla = new Button() { Text = "🔒 Ödemeyi Yap ve Kirala", Font = new Font("Segoe UI", 11f, FontStyle.Bold), ForeColor = Color.White, BackColor = Color.FromArgb(41, 128, 185), FlatStyle = FlatStyle.Flat, Location = new Point(20, 280), Size = new Size(320, 45), Cursor = Cursors.Hand };
            btnOnayla.FlatAppearance.BorderSize = 0;

            btnOnayla.Click += delegate
            {
                KiralamModel k = new KiralamModel
                {
                    MusteriId = _musteri.Id,
                    ArabaId = araba.Id,
                    Sehir = cmbSehir.Text,
                    BaslangicTarihi = dtpBaslangic.Value,
                    BitisTarihi = dtpBitis.Value,
                    ToplamFiyat = sonFiyat 
                };

               
                string secilenKupon = cmbKuponlar.SelectedIndex > 0 ? cmbKuponlar.Text.Split(' ')[0] : "";

                if (DatabaseHelper.KiralamayiKaydet(k, secilenKupon))
                {
                    MessageBox.Show($"Aracınız başarıyla kiralandı 🚀\nÖdenen Tutar: {sonFiyat.ToString("N0")} ₺", "Hayırlı Olsun", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmOnay.Close();
                    KiralamalariniYukle();
                    
                    string seg = cmbSegment.SelectedItem != null ? cmbSegment.SelectedItem.ToString() : "Tümü";
                    List<ArabaModel> guncelListe = DatabaseHelper.MuasaitAraclariGetir(_secilenSehir, _secilenBaslangic, _secilenBitis, seg);
                    AraclariListele(guncelListe);
                }
            };

            frmOnay.Controls.AddRange(new Control[] { lblBilgi, lblFiyatBaslik, lblFiyat, lblKuponBaslik, cmbKuponlar, btnOnayla });
            frmOnay.ShowDialog();
        
        }

        private void KiralamalariniYukle()
        {
            lvKiralamalar.Items.Clear();
            if (_musteri == null) return;

            
            lvKiralamalar.View = View.Details;
            lvKiralamalar.Columns.Clear();
            lvKiralamalar.Columns.Add("Araç", 180, HorizontalAlignment.Left);
            lvKiralamalar.Columns.Add("Şehir", 100, HorizontalAlignment.Left);
            lvKiralamalar.Columns.Add("Başlangıç", 110, HorizontalAlignment.Left);
            lvKiralamalar.Columns.Add("Bitiş", 110, HorizontalAlignment.Left);
            lvKiralamalar.Columns.Add("Toplam Ücret", 120, HorizontalAlignment.Left);
            lvKiralamalar.Columns.Add("Durum", 100, HorizontalAlignment.Left);

            List<KiralamaBilgiModel> liste = DatabaseHelper.MusteriKiralamalariniGetir(_musteri.Id);

            if (liste.Count == 0)
            {
                lblGecmisBaslik.Text = "📋  Kiralama Geçmişim  (henüz kiralama yok)";
                return;
            }

            lblGecmisBaslik.Text = "📋  Kiralama Geçmişim  (" + liste.Count + " kayıt)";

            
            foreach (KiralamaBilgiModel k in liste)
            {
                string gorunurAracAdi = k.ArabaAdi;
                if (!string.IsNullOrEmpty(k.KuponAdi))
                {
                    gorunurAracAdi += $" 🎁 [{k.KuponAdi}]";
                }
                ListViewItem item = new ListViewItem(gorunurAracAdi);
                item.SubItems.AddRange(new string[] {
            k.Sehir,
            k.BaslangicTarihi.ToString("dd.MM.yyyy"),
            k.BitisTarihi.ToString("dd.MM.yyyy"),
            k.ToplamFiyat.ToString("N0") + " ₺",
            k.Durum
        });

                item.Tag = k.Id; 

                if (k.BitisTarihi >= DateTime.Today)
                    item.BackColor = Color.FromArgb(232, 255, 240);

                lvKiralamalar.Items.Add(item);
            }

            
            ContextMenuStrip sagTikMenu = new ContextMenuStrip();
            ToolStripMenuItem btnIptalEt = new ToolStripMenuItem("❌ Kiralamayı İptal Et");
            sagTikMenu.Items.Add(btnIptalEt);
            ToolStripMenuItem btnYorumYap = new ToolStripMenuItem("✍️ Yorum Yap / Puan Ver");
            sagTikMenu.Items.Add(btnYorumYap);

            
            btnYorumYap.Click += (s, e) =>
            {
                if (lvKiralamalar.SelectedItems.Count > 0)
                {
                    ListViewItem seciliSatir = lvKiralamalar.SelectedItems[0];
                    string durum = seciliSatir.SubItems[5].Text;

                    if (durum != "⏹️ Kiralama Süresi Bitti")
                    {
                        MessageBox.Show("Sadece süresi bitmiş ve tamamlanmış kiralamalara yorum yapabilirsiniz ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    int kiralamaId = (int)seciliSatir.Tag;

                    
                    Form frmYorum = new Form();
                    frmYorum.Size = new Size(320, 260);
                    frmYorum.Text = "✍️ Araba Değerlendirme";
                    frmYorum.StartPosition = FormStartPosition.CenterParent;
                    frmYorum.FormBorderStyle = FormBorderStyle.FixedDialog;

                    Label lblPuanBaslik = new Label() { Text = "Puan Ver (1 - 5):", Location = new Point(20, 20), Size = new Size(100, 20) };
                    NumericUpDown numPuan = new NumericUpDown() { Location = new Point(130, 18), Size = new Size(60, 20), Minimum = 1, Maximum = 5, Value = 5 };

                    Label lblYorumBaslik = new Label() { Text = "Yorumunuz:", Location = new Point(20, 60), Size = new Size(100, 20) };
                    TextBox txtYorum = new TextBox() { Location = new Point(20, 85), Size = new Size(260, 60), Multiline = true };

                    Button btnKaydet = new Button() { Text = "Gönder", Location = new Point(180, 160), Size = new Size(100, 35), BackColor = Color.FromArgb(46, 204, 113), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };

                    btnKaydet.Click += delegate
                    {
                        
                        using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection(DatabaseHelper.Baglanti))
                        {
                            con.Open();
                            string sql = "SELECT ArabaId FROM Kiralamalar WHERE Id = @id";
                            using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@id", kiralamaId);
                                int arabaId = Convert.ToInt32(cmd.ExecuteScalar());

                                if (DatabaseHelper.YorumKaydet(arabaId, _musteri.Id, (int)numPuan.Value, txtYorum.Text))
                                {
                                    MessageBox.Show("Değerlendirmeniz başarıyla kaydedildi  ⭐", "Teşekkürler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    frmYorum.Close();
                                    
                                }
                            }
                        }
                    };

                    frmYorum.Controls.AddRange(new Control[] { lblPuanBaslik, numPuan, lblYorumBaslik, txtYorum, btnKaydet });
                    frmYorum.ShowDialog();
                }
            };
            lvKiralamalar.ContextMenuStrip = sagTikMenu;

            
            btnIptalEt.Click -= BtnIptalEt_Click;
            btnIptalEt.Click += BtnIptalEt_Click;
        }

        
        private void BtnIptalEt_Click(object sender, EventArgs e)
        {
            if (lvKiralamalar.SelectedItems.Count > 0)
            {
                ListViewItem seciliSatir = lvKiralamalar.SelectedItems[0];
                string durum = seciliSatir.SubItems[5].Text;

                if (durum != "✅ Aktif")
                {
                    string mesaj = durum.Contains("İptal")
                        ? "Bu kiralama zaten iptal edilmiş."
                        : "Geçmişte tamamlanmış kiralamaları iptal edemezsiniz.";
                    MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult eminMi = MessageBox.Show("Bu araç kiralamasını iptal etmek istediğinize emin misiniz ", "Kiralama İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (eminMi == DialogResult.Yes)
                {
                    int kiralamaId = (int)seciliSatir.Tag;
                    if (DatabaseHelper.KiralamayiIptalEt(kiralamaId))
                    {
                        MessageBox.Show("Kiralama başarıyla iptal edildi  ❌", "İptal Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KiralamalariniYukle(); 
                    }
                    else
                    {
                        MessageBox.Show("İptal işlemi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnKiralamalarim_Click(object sender, EventArgs e)
        {
            if (pnlKiralamalarim.Visible)
                EkraniGoster("kiralama");
            else
                EkraniGoster("kiralamalarim");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Oturumu kapatmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes) this.Close();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            
        }
    }
}