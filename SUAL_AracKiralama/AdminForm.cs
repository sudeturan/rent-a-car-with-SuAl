using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SUAL_AracKiralama
{
    public partial class AdminForm : Form
    {
        private int _seciliAracId = -1;
        private List<KiralamaDetayModel> _tumKiralamalar;

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

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
             
            cmbBakimSehir.Items.AddRange(Iller);
            cmbBakimSehir.SelectedIndex = 33; 

            SayfaGoster("dashboard");
            AdminForm_SizeChanged(null, EventArgs.Empty);
        }

        private void AdminForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) return;
            btnAdminCikis.Location = new Point(0, pnlSidebar.Height - 58);
            lblAdminBilgi.Location = new Point(this.ClientSize.Width - 225 - 260, 0);

            
            int filoW = pnlFilo.ClientSize.Width;
            int panelW = 310;
            pnlFiloForm.Size = new Size(panelW, pnlFilo.ClientSize.Height - 30);
            pnlFiloForm.Location = new Point(filoW - panelW - 15, 15);
            dgvAraclar.Width = filoW - panelW - 45;
            pnlFiloForm.BringToFront();
        }

        
        private void SayfaGoster(string sayfa)
        {
            pnlDashboard.Visible = (sayfa == "dashboard");
            pnlFilo.Visible = (sayfa == "filo");
            pnlKiralama.Visible = (sayfa == "kiralama");
            pnlYorumlar.Visible = (sayfa == "yorumlar");

            Color normalRenk = Color.Transparent;
            Color normalYazi = Color.FromArgb(170, 192, 225);
            btnDashboard.BackColor = normalRenk; btnDashboard.ForeColor = normalYazi;
            btnFiloYonetimi.BackColor = normalRenk; btnFiloYonetimi.ForeColor = normalYazi;
            btnKiralamaTakip.BackColor = normalRenk; btnKiralamaTakip.ForeColor = normalYazi;
            btnYorumPanel.BackColor = normalRenk; btnYorumPanel.ForeColor = normalYazi;

            Color aktifArka = Color.FromArgb(41, 128, 185);
            switch (sayfa)
            {
                case "dashboard":
                    lblSayfaBaslik.Text = "📊  Dashboard";
                    btnDashboard.BackColor = aktifArka; btnDashboard.ForeColor = Color.White;
                    DashboardYukle(); break;
                case "filo":
                    lblSayfaBaslik.Text = "🚗  Filo Yönetimi";
                    btnFiloYonetimi.BackColor = aktifArka; btnFiloYonetimi.ForeColor = Color.White;
                    FiloYukle(); break;
                case "kiralama":
                    lblSayfaBaslik.Text = "📋  Canlı Kiralama Takibi";
                    btnKiralamaTakip.BackColor = aktifArka; btnKiralamaTakip.ForeColor = Color.White;
                    KiralamaYukle(); break;
                case "yorumlar":
                    lblSayfaBaslik.Text = "✍️  Yorum & Şikayet Paneli";
                    btnYorumPanel.BackColor = aktifArka; btnYorumPanel.ForeColor = Color.White;
                    YorumlarYukle(); break;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e) { SayfaGoster("dashboard"); }
        private void btnFiloYonetimi_Click(object sender, EventArgs e) { SayfaGoster("filo"); }
        private void btnKiralamaTakip_Click(object sender, EventArgs e) { SayfaGoster("kiralama"); }
        private void btnYorumPanel_Click(object sender, EventArgs e) { SayfaGoster("yorumlar"); }

        private void btnAdminCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Yönetici oturumunu kapatmak istiyor musunuz?",
                "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes) this.Close();
        }

        
        private void DashboardYukle()
        {
            try
            {
                lblCiroSayi.Text = DatabaseHelper.ToplamGelir().ToString("N0") + " ₺";
                lblAktifSayi.Text = DatabaseHelper.AktifKiralamaSayisi().ToString();
                lblMusteriSayi.Text = DatabaseHelper.ToplamMusteriSayisi().ToString();
                lblKuponIcerik.Text = DatabaseHelper.KuponIstatistikleri();
                lblKuponIcerik.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard yüklenirken hata:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void FiloYukle()
        {
            _seciliAracId = -1;
            FiloFormTemizle();

            List<ArabaModel> araclar = DatabaseHelper.TumArabalariGetir();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Marka", typeof(string));
            dt.Columns.Add("Model", typeof(string));
            dt.Columns.Add("Yıl", typeof(int));
            dt.Columns.Add("Fiyat/Gün", typeof(string));
            dt.Columns.Add("Segment", typeof(string));

            foreach (ArabaModel a in araclar)
                dt.Rows.Add(a.Id, a.Marka, a.Model, a.Yil, a.GunlukFiyat.ToString("N0") + " ₺", a.Segment);

            dgvAraclar.DataSource = dt;

            foreach (DataGridViewRow row in dgvAraclar.Rows)
            {
                if (row.Cells["Segment"].Value == null) continue;
                string seg = row.Cells["Segment"].Value.ToString();
                switch (seg)
                {
                    case "Premium": row.DefaultCellStyle.BackColor = Color.FromArgb(248, 240, 255); break;
                    case "SUV": row.DefaultCellStyle.BackColor = Color.FromArgb(235, 255, 242); break;
                    case "Orta": row.DefaultCellStyle.BackColor = Color.FromArgb(237, 246, 255); break;
                    default: row.DefaultCellStyle.BackColor = Color.White; break;
                }
            }
        }

        private void dgvAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvAraclar.Rows[e.RowIndex];
            _seciliAracId = Convert.ToInt32(row.Cells["ID"].Value);
            txtMarka.Text = row.Cells["Marka"].Value.ToString();
            txtModel.Text = row.Cells["Model"].Value.ToString();
            txtYil.Text = row.Cells["Yıl"].Value.ToString();
            txtFiyat.Text = row.Cells["Fiyat/Gün"].Value.ToString().Replace(" ₺", "").Replace(".", "").Replace(",", "");

            string segment = row.Cells["Segment"].Value.ToString();
            for (int i = 0; i < cmbSegment.Items.Count; i++)
                if (cmbSegment.Items[i].ToString() == segment) cmbSegment.SelectedIndex = i;

            lblFiloFormBaslik.Text = "✏️  Düzenleniyor (ID: " + _seciliAracId + ")";

            
            BakimDurumunuGuncelle();
        }

        private void BakimDurumunuGuncelle()
        {
            if (_seciliAracId < 1) { lblBakimDurum.Text = ""; return; }

            string sehirler = DatabaseHelper.BakimSehirleriniGetir(_seciliAracId);
            if (string.IsNullOrEmpty(sehirler))
                lblBakimDurum.Text = "✅ Bu araç hiçbir şehirde bakımda değil";
            else
                lblBakimDurum.Text = "🔧 Bakımdaki şehirler:\n" + sehirler;
        }

        private void FiloFormTemizle()
        {
            txtMarka.Text = ""; txtModel.Text = ""; txtYil.Text = ""; txtFiyat.Text = "";
            cmbSegment.SelectedIndex = 0;
            lblFiloFormBaslik.Text = "🚗  Araç Ekle / Düzenle";
            lblBakimDurum.Text = "";
            _seciliAracId = -1;
        }

        private bool FiloFormDogrula(out int yil, out double fiyat)
        {
            yil = 0; fiyat = 0;
            if (string.IsNullOrWhiteSpace(txtMarka.Text) || string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtYil.Text) || string.IsNullOrWhiteSpace(txtFiyat.Text))
            { MessageBox.Show("Tüm alanları doldurunuz.", "Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!int.TryParse(txtYil.Text.Trim(), out yil))
            { MessageBox.Show("Yıl sayısal olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (!double.TryParse(txtFiyat.Text.Trim(), out fiyat))
            { MessageBox.Show("Fiyat sayısal olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            return true;
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            int yil; double fiyat;
            if (!FiloFormDogrula(out yil, out fiyat)) return;
            bool ok = DatabaseHelper.ArabaEkle(txtMarka.Text.Trim(), txtModel.Text.Trim(), yil, fiyat, cmbSegment.SelectedItem.ToString(), "");
            if (ok) { MessageBox.Show("Yeni araç filoya eklendi! 🎉", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); FiloYukle(); }
            else MessageBox.Show("Ekleme başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliAracId < 1) { MessageBox.Show("Önce tablodan bir araç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            int yil; double fiyat;
            if (!FiloFormDogrula(out yil, out fiyat)) return;
            bool ok = DatabaseHelper.ArabaGuncelle(_seciliAracId, txtMarka.Text.Trim(), txtModel.Text.Trim(), yil, fiyat, cmbSegment.SelectedItem.ToString(), "");
            if (ok) { MessageBox.Show("Araç güncellendi! ✏️", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); FiloYukle(); }
            else MessageBox.Show("Güncelleme başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            if (_seciliAracId < 1) { MessageBox.Show("Önce tablodan bir araç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            DialogResult cevap = MessageBox.Show(txtMarka.Text + " " + txtModel.Text + " aracını filodan silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                if (DatabaseHelper.ArabaSil(_seciliAracId)) { MessageBox.Show("Araç filodan kaldırıldı. 🗑️", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); FiloYukle(); }
                else MessageBox.Show("Silme başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnBakimaAl_Click(object sender, EventArgs e)
        {
            if (_seciliAracId < 1)
            {
                MessageBox.Show("Önce tablodan bakıma alınacak aracı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sehir = cmbBakimSehir.SelectedItem.ToString();
            DialogResult cevap = MessageBox.Show(
                txtMarka.Text + " " + txtModel.Text + " aracını " + sehir + " şehrinde bakıma almak istiyor musunuz?\n\n" +
                "⚠️ Bu araç o şehirde müşterilere gösterilmeyecek!",
                "Bakıma Al", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                if (DatabaseHelper.AraciBakimaAl(_seciliAracId, sehir))
                {
                    MessageBox.Show("🔧 " + txtMarka.Text + " " + txtModel.Text + " → " + sehir + " şehrinde bakıma alındı!",
                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BakimDurumunuGuncelle();
                }
                else
                    MessageBox.Show("İşlem başarısız veya araç zaten bu şehirde bakımda.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBakimdanCikar_Click(object sender, EventArgs e)
        {
            if (_seciliAracId < 1)
            {
                MessageBox.Show("Önce tablodan aracı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sehir = cmbBakimSehir.SelectedItem.ToString();
            if (DatabaseHelper.AraciBakimdanCikar(_seciliAracId, sehir))
            {
                MessageBox.Show("✅ " + txtMarka.Text + " " + txtModel.Text + " → " + sehir + " şehrinde bakımdan çıkarıldı!",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BakimDurumunuGuncelle();
            }
            else
                MessageBox.Show("İşlem başarısız veya araç bu şehirde zaten bakımda değil.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void KiralamaYukle()
        {
            _tumKiralamalar = DatabaseHelper.TumKiralamalarDetayli();
            KiralamayiListele(_tumKiralamalar);
        }

        private void KiralamayiListele(List<KiralamaDetayModel> liste)
        {
            lvKiralamalar.Items.Clear();
            foreach (KiralamaDetayModel k in liste)
            {
                string durum;
                if (k.ToplamFiyat == -1) durum = "❌ İptal";
                else if (k.BitisTarihi >= DateTime.Today) durum = "✅ Aktif";
                else durum = "⏹ Bitti";

                string tutarStr = k.ToplamFiyat == -1 ? "İptal" : k.ToplamFiyat.ToString("N0") + " ₺";

                ListViewItem item = new ListViewItem(k.Id.ToString());
                item.SubItems.Add(k.MusteriBilgi);
                item.SubItems.Add(k.ArabaBilgi);
                item.SubItems.Add(k.Sehir);
                item.SubItems.Add(k.BaslangicTarihi.ToString("dd.MM.yyyy"));
                item.SubItems.Add(k.BitisTarihi.ToString("dd.MM.yyyy"));
                item.SubItems.Add(tutarStr);
                item.SubItems.Add(string.IsNullOrEmpty(k.KuponAdi) ? "—" : k.KuponAdi);
                item.SubItems.Add(durum);
                item.Tag = k;

                if (k.ToplamFiyat == -1) item.BackColor = Color.FromArgb(255, 235, 235);
                else if (k.BitisTarihi >= DateTime.Today) item.BackColor = Color.FromArgb(232, 255, 240);

                lvKiralamalar.Items.Add(item);
            }
        }

        
        private void btnKiralamaIptal_Click(object sender, EventArgs e)
        {
            if (lvKiralamalar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen iptal edilecek kiralamayı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            KiralamaDetayModel k = (KiralamaDetayModel)lvKiralamalar.SelectedItems[0].Tag;

            if (k.ToplamFiyat == -1)
            {
                MessageBox.Show("Bu kiralama zaten iptal edilmiş.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult cevap = MessageBox.Show(
                "Bu kiralamayı iptal etmek istediğinize emin misiniz?\n\n" +
                "Müşteri: " + k.MusteriBilgi + "\n" +
                "Araç: " + k.ArabaBilgi + "\n" +
                "Şehir: " + k.Sehir + "\n" +
                "Tutar: " + k.ToplamFiyat.ToString("N0") + " ₺",
                "Kiralama İptal Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                if (DatabaseHelper.KiralamayiIptalEt(k.Id))
                {
                    MessageBox.Show("Kiralama iptal edildi! ❌", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KiralamaYukle();
                }
                else
                    MessageBox.Show("İptal işlemi başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKiralamaAra_Enter(object sender, EventArgs e)
        {
            if (txtKiralamaAra.ForeColor == Color.Gray) { txtKiralamaAra.Text = ""; txtKiralamaAra.ForeColor = Color.FromArgb(22, 35, 52); }
        }

        private void txtKiralamaAra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKiralamaAra.Text)) { txtKiralamaAra.Text = "🔍  TC veya Müşteri Adı ile Ara..."; txtKiralamaAra.ForeColor = Color.Gray; }
        }

        private void txtKiralamaAra_TextChanged(object sender, EventArgs e)
        {
            if (txtKiralamaAra.ForeColor == Color.Gray || _tumKiralamalar == null) return;
            string filtre = txtKiralamaAra.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filtre)) { KiralamayiListele(_tumKiralamalar); return; }

            List<KiralamaDetayModel> filtrelenmis = new List<KiralamaDetayModel>();
            foreach (KiralamaDetayModel k in _tumKiralamalar)
            {
                if (k.MusteriBilgi.ToLower().Contains(filtre) || k.ArabaBilgi.ToLower().Contains(filtre) || k.Sehir.ToLower().Contains(filtre))
                    filtrelenmis.Add(k);
            }
            KiralamayiListele(filtrelenmis);
        }

        
        private void YorumlarYukle()
        {
            lvYorumlar.Items.Clear();
            try
            {
                List<YorumDetayModel> yorumlar = DatabaseHelper.TumYorumlariGetir();
                if (yorumlar.Count == 0)
                {
                    ListViewItem bos = new ListViewItem("—"); bos.SubItems.Add("—"); bos.SubItems.Add("—"); bos.SubItems.Add("—"); bos.SubItems.Add("Henüz yorum yapılmamış"); bos.ForeColor = Color.Gray;
                    lvYorumlar.Items.Add(bos); return;
                }
                foreach (YorumDetayModel y in yorumlar)
                {
                    string yildiz = "";
                    for (int i = 0; i < y.Puan; i++) yildiz += "★";
                    for (int i = y.Puan; i < 5; i++) yildiz += "☆";

                    ListViewItem item = new ListViewItem(y.Id.ToString());
                    item.SubItems.Add(y.MusteriBilgi);
                    item.SubItems.Add(y.ArabaBilgi);
                    item.SubItems.Add(yildiz + "  (" + y.Puan + "/5)");
                    item.SubItems.Add(y.YorumMetni ?? "");
                    item.Tag = y;

                    if (y.Puan <= 2) item.BackColor = Color.FromArgb(255, 235, 235);
                    else if (y.Puan >= 4) item.BackColor = Color.FromArgb(235, 255, 240);
                    lvYorumlar.Items.Add(item);
                }
            }
            catch (Exception)
            {
                ListViewItem hata = new ListViewItem("—"); hata.SubItems.Add("—"); hata.SubItems.Add("—"); hata.SubItems.Add("—"); hata.SubItems.Add("Yorum sistemi henüz aktif değil"); hata.ForeColor = Color.Gray;
                lvYorumlar.Items.Add(hata);
            }
        }

        private void btnYorumSil_Click(object sender, EventArgs e)
        {
            if (lvYorumlar.SelectedItems.Count == 0 || lvYorumlar.SelectedItems[0].Tag == null)
            { MessageBox.Show("Lütfen silinecek yorumu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            YorumDetayModel y = (YorumDetayModel)lvYorumlar.SelectedItems[0].Tag;
            DialogResult cevap = MessageBox.Show("Bu yorumu silmek istediğinize emin misiniz?\n\nMüşteri: " + y.MusteriBilgi + "\nYorum: \"" + y.YorumMetni + "\"", "Yorum Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                if (DatabaseHelper.YorumSil(y.Id)) { MessageBox.Show("Yorum silindi. 🗑️", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); YorumlarYukle(); }
                else MessageBox.Show("Silme başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}