using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SUAL_AracKiralama
{
    public partial class Form1 : Form
    {
        private string seciliRol = "Admin";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                DatabaseHelper.Baslat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı başlatılamadı:\n" + ex.Message,
                                "DB Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            lblSualBaslik.Parent = pnlArkaplan;
            lblSistemAdi.Parent = pnlArkaplan;
            lblSlogan.Parent = pnlArkaplan;

            
            YenidenDuzenle();

            
            pnlKart.BringToFront();

            
            RolButonlariniGuncelle();
        }

        
      
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Minimized) return;
            YenidenDuzenle();
            pnlKart.BringToFront();
        }

        
        private void YenidenDuzenle()
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            if (w < 100 || h < 100) return;

            try
            {
                Bitmap yeniArkaplan = ArkaplanGorseliOlustur(w, h);
                Image eskiGorsel = pnlArkaplan.BackgroundImage;
                pnlArkaplan.BackgroundImage = yeniArkaplan;
                if (eskiGorsel != null) eskiGorsel.Dispose();
            }
            catch (Exception) { }

            
            int kartW = 388;
            int kartH = 476;

            int kartX = (int)(w * 0.547);
            int kartY = (h - kartH) / 2;

            
            if (kartX + kartW > w - 8) kartX = w - kartW - 8;
            if (kartX < w / 2) kartX = w / 2;
            if (kartY < 8) kartY = 8;

            pnlKart.Location = new Point(kartX, kartY);
            
            int solX = 42;
            int lblGeni = kartX - solX - 20; 
            if (lblGeni < 200) lblGeni = 200;

            lblSualBaslik.Location = new Point(solX, (int)(h * 0.208));
            lblSualBaslik.Size = new Size(lblGeni, 94);

            lblSistemAdi.Location = new Point(solX, (int)(h * 0.392));
            lblSistemAdi.Size = new Size(lblGeni, 108);

            lblSlogan.Location = new Point(solX, (int)(h * 0.615));
            lblSlogan.Size = new Size(Math.Min(lblGeni, 345), 64);

            pnlArkaplan.Invalidate();
        }


        private Bitmap ArkaplanGorseliOlustur(int genislik, int yukseklik)
        {
            Bitmap sonuc = new Bitmap(genislik, yukseklik, PixelFormat.Format32bppArgb);

            using (Graphics g = Graphics.FromImage(sonuc))
            {
                Rectangle alan = new Rectangle(0, 0, genislik, yukseklik);

                using (LinearGradientBrush zemin = new LinearGradientBrush(
                    alan,
                    Color.FromArgb(8, 12, 22),
                    Color.FromArgb(28, 46, 74),
                    LinearGradientMode.ForwardDiagonal))
                {
                    g.FillRectangle(zemin, alan);
                }

                using (LinearGradientBrush kararti = new LinearGradientBrush(
                    alan,
                    Color.FromArgb(190, 8, 12, 22),
                    Color.FromArgb(40, 8, 12, 22),
                    LinearGradientMode.Horizontal))
                {
                    g.FillRectangle(kararti, alan);
                }
            }

            return sonuc;
        }

        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string girdi = txtKullaniciAdi.Text.Trim(); 
            string sifre = txtSifre.Text;

            if (girdi == "Kullanıcı Adı" || girdi == "") girdi = "";
            if (sifre == "Şifre" || sifre == "") sifre = "";

            if (string.IsNullOrEmpty(girdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen alanları eksiksiz doldurunuz.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (seciliRol == "Admin")
            {
                if (girdi == "admin" && sifre == "1234")
                {
                    MessageBox.Show("Yönetici Girişi Başarılı! 🎉",
                                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminForm adminForm = new AdminForm();
                    adminForm.FormClosed += delegate (object sndr, FormClosedEventArgs fce)
                    {
                        this.Show();
                    };
                    this.Hide();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı yönetici bilgileri", "Hata",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
                if (sifre.Length < 1)
                {
                    MessageBox.Show("Şifre boş olamaz.", "Uyarı",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                MusteriForm musteriForm = new MusteriForm(girdi);
                musteriForm.FormClosed += delegate (object sndr, FormClosedEventArgs fce)
                {
                    this.Show(); 
                };
                this.Hide();
                musteriForm.Show();
            }
        }

        
        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chkSifreGoster.Checked ? '\0' : '*';
        }

        
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            seciliRol = "Admin";
            RolButonlariniGuncelle();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            seciliRol = "Musteri";
            RolButonlariniGuncelle();
        }

        private void RolButonlariniGuncelle()
        {
            Color aktifArka = Color.FromArgb(41, 128, 185);
            Color pasifArka = Color.FromArgb(30, 48, 72);
            Color aktifYazi = Color.White;
            Color pasifYazi = Color.FromArgb(155, 178, 205);

            if (seciliRol == "Admin")
            {
                btnAdmin.BackColor = aktifArka; btnAdmin.ForeColor = aktifYazi;
                btnMusteri.BackColor = pasifArka; btnMusteri.ForeColor = pasifYazi;
            }
            else
            {
                btnMusteri.BackColor = aktifArka; btnMusteri.ForeColor = aktifYazi;
                btnAdmin.BackColor = pasifArka; btnAdmin.ForeColor = pasifYazi;
            }
        }

        
        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanıcı Adı")
            {
                txtKullaniciAdi.Text = "";
                txtKullaniciAdi.ForeColor = Color.FromArgb(22, 35, 52);
            }
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                txtKullaniciAdi.Text = "Kullanıcı Adı";
                txtKullaniciAdi.ForeColor = Color.FromArgb(160, 168, 180);
            }
        }

        
        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Text = "";
                txtSifre.ForeColor = Color.FromArgb(22, 35, 52);
                txtSifre.PasswordChar = '*';
            }
        }   

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                txtSifre.Text = "Şifre";
                txtSifre.ForeColor = Color.FromArgb(160, 168, 180);
                txtSifre.PasswordChar = '\0';
            }
        }
    }
}