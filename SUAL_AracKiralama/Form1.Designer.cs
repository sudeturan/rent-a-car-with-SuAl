namespace SUAL_AracKiralama
{
    partial class Form1
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
            this.pnlArkaplan = new System.Windows.Forms.Panel();
            this.lblSualBaslik = new System.Windows.Forms.Label();
            this.lblSistemAdi = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.pnlKart = new System.Windows.Forms.Panel();
            this.lblEmoji = new System.Windows.Forms.Label();
            this.lblKullaniciGirisi = new System.Windows.Forms.Label();
            this.lblAltBaslik = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.chkSifreGoster = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pnlRol = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.lblDemo = new System.Windows.Forms.Label();

            this.pnlArkaplan.SuspendLayout();
            this.pnlKart.SuspendLayout();
            this.pnlRol.SuspendLayout();
            this.SuspendLayout();

            
            this.pnlArkaplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArkaplan.BackColor = System.Drawing.Color.FromArgb(12, 18, 30);
            this.pnlArkaplan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlArkaplan.Controls.Add(this.lblSualBaslik);
            this.pnlArkaplan.Controls.Add(this.lblSistemAdi);
            this.pnlArkaplan.Controls.Add(this.lblSlogan);
            this.pnlArkaplan.Name = "pnlArkaplan";
            this.pnlArkaplan.TabIndex = 0;

            
            this.lblSualBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblSualBaslik.Font = new System.Drawing.Font("Segoe UI", 60F,
                                               System.Drawing.FontStyle.Bold,
                                               System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSualBaslik.ForeColor = System.Drawing.Color.White;
            this.lblSualBaslik.Location = new System.Drawing.Point(42, 108);
            this.lblSualBaslik.Name = "lblSualBaslik";
            this.lblSualBaslik.Size = new System.Drawing.Size(380, 94);
            this.lblSualBaslik.TabIndex = 0;
            this.lblSualBaslik.Text = "SUAL";
            this.lblSualBaslik.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

            
            this.lblSistemAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblSistemAdi.Font = new System.Drawing.Font("Segoe UI", 24F,
                                              System.Drawing.FontStyle.Bold,
                                              System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSistemAdi.ForeColor = System.Drawing.Color.White;
            this.lblSistemAdi.Location = new System.Drawing.Point(42, 204);
            this.lblSistemAdi.Name = "lblSistemAdi";
            this.lblSistemAdi.Size = new System.Drawing.Size(370, 108);
            this.lblSistemAdi.TabIndex = 1;
            this.lblSistemAdi.Text = "Araç Kiralama\nSistemi";

            
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 10.5F,
                                           System.Drawing.FontStyle.Regular,
                                           System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(185, 200, 220);
            this.lblSlogan.Location = new System.Drawing.Point(42, 320);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(345, 64);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Güvenli, Hızlı ve Profesyonel\nFilo Yönetimi";

            
            this.pnlKart.BackColor = System.Drawing.Color.White;
            this.pnlKart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlKart.Controls.Add(this.lblEmoji);
            this.pnlKart.Controls.Add(this.lblKullaniciGirisi);
            this.pnlKart.Controls.Add(this.lblAltBaslik);
            this.pnlKart.Controls.Add(this.txtKullaniciAdi);
            this.pnlKart.Controls.Add(this.txtSifre);
            this.pnlKart.Controls.Add(this.chkSifreGoster);
            this.pnlKart.Controls.Add(this.btnGiris);
            this.pnlKart.Controls.Add(this.pnlRol);
            this.pnlKart.Controls.Add(this.lblDemo);
            this.pnlKart.Location = new System.Drawing.Point(492, 22);
            this.pnlKart.Name = "pnlKart";
            this.pnlKart.Size = new System.Drawing.Size(388, 476);
            this.pnlKart.TabIndex = 1;

            
            this.lblEmoji.BackColor = System.Drawing.Color.White;
            this.lblEmoji.Font = new System.Drawing.Font("Segoe UI Emoji", 26F,
                                          System.Drawing.FontStyle.Regular,
                                          System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmoji.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.lblEmoji.Location = new System.Drawing.Point(0, 12);
            this.lblEmoji.Name = "lblEmoji";
            this.lblEmoji.Size = new System.Drawing.Size(388, 54);
            this.lblEmoji.TabIndex = 0;
            this.lblEmoji.Text = "🔑🚗";
            this.lblEmoji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            this.lblKullaniciGirisi.BackColor = System.Drawing.Color.White;
            this.lblKullaniciGirisi.Font = new System.Drawing.Font("Segoe UI", 15F,
                                                    System.Drawing.FontStyle.Bold,
                                                    System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciGirisi.ForeColor = System.Drawing.Color.FromArgb(20, 30, 48);
            this.lblKullaniciGirisi.Location = new System.Drawing.Point(0, 68);
            this.lblKullaniciGirisi.Name = "lblKullaniciGirisi";
            this.lblKullaniciGirisi.Size = new System.Drawing.Size(388, 38);
            this.lblKullaniciGirisi.TabIndex = 1;
            this.lblKullaniciGirisi.Text = "Kullanıcı Girişi";
            this.lblKullaniciGirisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            this.lblAltBaslik.BackColor = System.Drawing.Color.White;
            this.lblAltBaslik.Font = new System.Drawing.Font("Segoe UI", 8.5F,
                                              System.Drawing.FontStyle.Regular,
                                              System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAltBaslik.ForeColor = System.Drawing.Color.FromArgb(118, 132, 150);
            this.lblAltBaslik.Location = new System.Drawing.Point(0, 107);
            this.lblAltBaslik.Name = "lblAltBaslik";
            this.lblAltBaslik.Size = new System.Drawing.Size(388, 22);
            this.lblAltBaslik.TabIndex = 2;
            this.lblAltBaslik.Text = "Yönetici veya Müşteri Paneline Erişin";
            this.lblAltBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(246, 249, 255);
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 10F,
                                                   System.Drawing.FontStyle.Regular,
                                                   System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(160, 168, 180);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(28, 148);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(332, 30);
            this.txtKullaniciAdi.TabIndex = 3;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            this.txtKullaniciAdi.Enter += new System.EventHandler(this.txtKullaniciAdi_Enter);
            this.txtKullaniciAdi.Leave += new System.EventHandler(this.txtKullaniciAdi_Leave);

            
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(246, 249, 255);
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 10F,
                                            System.Drawing.FontStyle.Regular,
                                            System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(160, 168, 180);
            this.txtSifre.Location = new System.Drawing.Point(28, 196);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(332, 30);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);

            
            this.chkSifreGoster.BackColor = System.Drawing.Color.White;
            this.chkSifreGoster.Font = new System.Drawing.Font("Segoe UI", 8.5F,
                                                           System.Drawing.FontStyle.Regular,
                                                           System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSifreGoster.ForeColor = System.Drawing.Color.FromArgb(95, 108, 125);
            this.chkSifreGoster.Location = new System.Drawing.Point(28, 242);
            this.chkSifreGoster.Name = "chkSifreGoster";
            this.chkSifreGoster.Size = new System.Drawing.Size(140, 22);
            this.chkSifreGoster.TabIndex = 5;
            this.chkSifreGoster.Text = "Şifreyi Göster";
            this.chkSifreGoster.UseVisualStyleBackColor = false;
            this.chkSifreGoster.CheckedChanged += new System.EventHandler(this.chkSifreGoster_CheckedChanged);

            
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 11F,
                                                                     System.Drawing.FontStyle.Bold,
                                                                     System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(28, 278);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(332, 45);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Sisteme Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);

            
            this.pnlRol.BackColor = System.Drawing.Color.FromArgb(20, 32, 50);
            this.pnlRol.Controls.Add(this.btnAdmin);
            this.pnlRol.Controls.Add(this.btnMusteri);
            this.pnlRol.Location = new System.Drawing.Point(0, 336);
            this.pnlRol.Name = "pnlRol";
            this.pnlRol.Size = new System.Drawing.Size(388, 108);
            this.pnlRol.TabIndex = 7;

            
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 9.5F,
                                                               System.Drawing.FontStyle.Bold,
                                                               System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.Location = new System.Drawing.Point(14, 33);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(170, 42);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);

            
            this.btnMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMusteri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.Font = new System.Drawing.Font("Segoe UI", 9.5F,
                                                                System.Drawing.FontStyle.Bold,
                                                                System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.Location = new System.Drawing.Point(204, 33);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(170, 42);
            this.btnMusteri.TabIndex = 1;
            this.btnMusteri.Text = "Müşteri";
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);

            
            this.lblDemo.BackColor = System.Drawing.Color.White;
            this.lblDemo.Font = new System.Drawing.Font("Segoe UI", 7.5F,
                                         System.Drawing.FontStyle.Regular,
                                         System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDemo.ForeColor = System.Drawing.Color.FromArgb(135, 148, 165);
            this.lblDemo.Location = new System.Drawing.Point(0, 454);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(388, 22);
            this.lblDemo.TabIndex = 8;
            this.lblDemo.Text = "Demo Girişi: admin  |  Şifre: 1234";
            this.lblDemo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(12, 18, 30);
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.MinimumSize = new System.Drawing.Size(780, 460);      
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable; 
            this.MaximizeBox = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F,
                                       System.Drawing.FontStyle.Regular,
                                       System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş — SUAL Araç Kiralama Sistemi";
            
            this.Controls.Add(this.pnlArkaplan);
            this.Controls.Add(this.pnlKart);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);

            this.pnlArkaplan.ResumeLayout(false);
            this.pnlKart.ResumeLayout(false);
            this.pnlKart.PerformLayout();
            this.pnlRol.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlArkaplan;
        private System.Windows.Forms.Label lblSualBaslik;
        private System.Windows.Forms.Label lblSistemAdi;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Panel pnlKart;
        private System.Windows.Forms.Label lblEmoji;
        private System.Windows.Forms.Label lblKullaniciGirisi;
        private System.Windows.Forms.Label lblAltBaslik;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.CheckBox chkSifreGoster;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Panel pnlRol;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Label lblDemo;
    }
}