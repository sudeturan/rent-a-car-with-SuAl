using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SUAL_AracKiralama
{
    
    public class MusteriModel
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcKimlik { get; set; }
        public string AdSoyad { get { return Ad + " " + Soyad; } }
    }

    public class ArabaModel
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public double GunlukFiyat { get; set; }
        public string Segment { get; set; }
        public string GorselAdi { get; set; }
        public string Emoji { get { return "🚗"; } }
        public string TamAdi { get { return Marka + " " + Model; } }
    }

    public class KiralamModel
    {
        public int MusteriId { get; set; }
        public int ArabaId { get; set; }
        public string Sehir { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public double ToplamFiyat { get; set; }
    }

    public class KiralamaBilgiModel
    {
        public int Id { get; set; }
        public string ArabaAdi { get; set; }
        public string Sehir { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public double ToplamFiyat { get; set; }
        public string KuponAdi { get; set; }
        public string Durum { get; set; }
    }

    public class KiralamaDetayModel
    {
        public int Id { get; set; }
        public string MusteriBilgi { get; set; }
        public string ArabaBilgi { get; set; }
        public string Sehir { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public double ToplamFiyat { get; set; }
        public string KuponAdi { get; set; }
    }

    public class YorumDetayModel
    {
        public int Id { get; set; }
        public string ArabaBilgi { get; set; }
        public string MusteriBilgi { get; set; }
        public int Puan { get; set; }
        public string YorumMetni { get; set; }
    }

    
    public static class DatabaseHelper
    {
        private static readonly string DbYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SUAL_Kiralama.db");

        public static string Baglanti
        {
            get { return "Data Source=" + DbYolu + ";Version=3;"; }
        }

        public static void Baslat()
        {
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                TablolariOlustur(con);

                long arabaCount = 0;
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Arabalar", con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null) arabaCount = (long)result;
                }
                if (arabaCount == 0)
                {
                    SeedArabalar(con);
                }
            }
        }

        private static void TablolariOlustur(SQLiteConnection con)
        {
            string[] sqls = new string[]
            {
                @"CREATE TABLE IF NOT EXISTS Musteriler (
                    Id           INTEGER PRIMARY KEY AUTOINCREMENT,
                    KullaniciAdi TEXT    UNIQUE NOT NULL,
                    Ad           TEXT    NOT NULL,
                    Soyad        TEXT    NOT NULL,
                    TcKimlik     TEXT    UNIQUE NOT NULL,
                    KayitTarihi  TEXT    DEFAULT (datetime('now','localtime'))
                )",
                @"CREATE TABLE IF NOT EXISTS Arabalar (
                    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                    Marka       TEXT    NOT NULL,
                    Model       TEXT    NOT NULL,
                    Yil         INTEGER NOT NULL,
                    GunlukFiyat REAL    NOT NULL,
                    Segment     TEXT    NOT NULL,
                    GorselAdi   TEXT    NOT NULL
                )",
                @"CREATE TABLE IF NOT EXISTS Kiralamalar (
                    Id              INTEGER PRIMARY KEY AUTOINCREMENT,
                    MusteriId       INTEGER NOT NULL,
                    ArabaId         INTEGER NOT NULL,
                    Sehir           TEXT    NOT NULL,
                    BaslangicTarihi TEXT    NOT NULL,
                    BitisTarihi     TEXT    NOT NULL,
                    ToplamFiyat     REAL    NOT NULL,
                    KuponAdi        TEXT    DEFAULT '', 
                    KayitTarihi     TEXT    DEFAULT (datetime('now','localtime')),
                    FOREIGN KEY (MusteriId) REFERENCES Musteriler(Id),
                    FOREIGN KEY (ArabaId)   REFERENCES Arabalar(Id)
                )",
                @"CREATE TABLE IF NOT EXISTS Yorumlar (
                    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                    ArabaId     INTEGER NOT NULL,
                    MusteriId   INTEGER NOT NULL,
                    Puan        INTEGER NOT NULL,
                    YorumMetni  TEXT,
                    FOREIGN KEY (ArabaId) REFERENCES Arabalar(Id),
                    FOREIGN KEY (MusteriId) REFERENCES Musteriler(Id)
                )",
                @"CREATE TABLE IF NOT EXISTS BakimdakiAraclar (
                    Id      INTEGER PRIMARY KEY AUTOINCREMENT,
                    ArabaId INTEGER NOT NULL,
                    Sehir   TEXT    NOT NULL,
                    UNIQUE(ArabaId, Sehir),
                    FOREIGN KEY (ArabaId) REFERENCES Arabalar(Id)
                )"
            };
            foreach (string sql in sqls)
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    cmd.ExecuteNonQuery();
            }
        }

        private static void SeedArabalar(SQLiteConnection con)
        {
            object[][] arabalar = new object[][]
            {
                
                new object[] { "Peugeot",    "2008",           2023, 1400.0, "SUV",     "_2008" },
                new object[] { "Peugeot",    "3008",           2022, 1600.0, "SUV",     "_3008" },
                new object[] { "Peugeot",    "408",            2023, 1750.0, "Orta",    "_408" },
                new object[] { "Peugeot",    "5008",           2023, 1900.0, "SUV",     "_5008" },
                new object[] { "Audi",       "A3 Sedan",       2023, 2200.0, "Premium", "a3" },
                new object[] { "Citroen",    "C4",             2023, 1150.0, "Orta",    "c4" },
                new object[] { "Renault",    "Clio",           2024, 850.0,  "Ekonomi", "clio2" },
                new object[] { "Toyota",     "Corolla",        2024, 1250.0, "Orta",    "corolla2" },
                new object[] { "Opel",       "Corsa",          2023, 880.0,  "Ekonomi", "corsa" },
                new object[] { "Fiat",       "Egea Sedan",     2023, 900.0,  "Ekonomi", "egea2" },
                new object[] { "Fiat",       "Egea Cross",     2024, 1100.0, "Orta",    "egeacross" },
                new object[] { "Cupra",      "Formentor",      2023, 2400.0, "Premium", "formentor" },
                new object[] { "Volkswagen", "Golf",           2023, 1300.0, "Orta",    "golf" },
                new object[] { "Skoda",      "Kamiq",          2023, 1450.0, "SUV",     "kamiq" },
                new object[] { "Skoda",      "Kodiaq",         2022, 2100.0, "SUV",     "kodiaq" },
                new object[] { "Renault",    "Megane",         2023, 1200.0, "Orta",    "megane" },
                new object[] { "Skoda",      "Octavia",        2023, 1350.0, "Orta",    "octavia" },
                new object[] { "Volkswagen", "Passat Variant", 2022, 1700.0, "Orta",    "passatvariant" },
                new object[] { "Volkswagen", "Polo",           2023, 980.0,  "Ekonomi", "polo" },
                new object[] { "Audi",       "Q2",             2022, 2100.0, "Premium", "q2" },
                new object[] { "Audi",       "Q3",             2023, 2500.0, "Premium", "q3" },
                new object[] { "Skoda",      "Superb",         2022, 1650.0, "Orta",    "superb" },
                new object[] { "Volkswagen", "Tiguan",         2023, 1800.0, "SUV",     "tiguan" },
                new object[] { "Volkswagen", "T-Roc",          2023, 1550.0, "SUV",     "troc" }
            };

            string sql = @"INSERT INTO Arabalar (Marka, Model, Yil, GunlukFiyat, Segment, GorselAdi)
                           VALUES (@marka, @model, @yil, @fiyat, @segment, @gorsel)";
            foreach (object[] a in arabalar)
            {
                using (SQLiteCommand cmdSql = new SQLiteCommand(sql, con))
                {
                    cmdSql.Parameters.AddWithValue("@marka", a[0]);
                    cmdSql.Parameters.AddWithValue("@model", a[1]);
                    cmdSql.Parameters.AddWithValue("@yil", a[2]);
                    cmdSql.Parameters.AddWithValue("@fiyat", a[3]);
                    cmdSql.Parameters.AddWithValue("@segment", a[4]);
                    cmdSql.Parameters.AddWithValue("@gorsel", a[5]);
                    cmdSql.ExecuteNonQuery();
                }
            }
        }

        
        public static MusteriModel MusteriGetir(string kullaniciAdi)
        {
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                string sql = "SELECT * FROM Musteriler WHERE lower(KullaniciAdi) = lower(@ka)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ka", kullaniciAdi);
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new MusteriModel
                            {
                                Id = Convert.ToInt32(r["Id"]),
                                KullaniciAdi = r["KullaniciAdi"].ToString(),
                                Ad = r["Ad"].ToString(),
                                Soyad = r["Soyad"].ToString(),
                                TcKimlik = r["TcKimlik"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static MusteriModel MusteriGetirVeTcKontrolEt(string tcKimlik)
        {
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                string sql = "SELECT * FROM Musteriler WHERE TcKimlik = @tc";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@tc", tcKimlik);
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new MusteriModel
                            {
                                Id = Convert.ToInt32(r["Id"]),
                                KullaniciAdi = r["KullaniciAdi"].ToString(),
                                Ad = r["Ad"].ToString(),
                                Soyad = r["Soyad"].ToString(),
                                TcKimlik = r["TcKimlik"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public static bool MusteriKaydet(MusteriModel m)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Baglanti))
                {
                    con.Open();
                    string sql = @"INSERT INTO Musteriler (KullaniciAdi, Ad, Soyad, TcKimlik) VALUES (@ka, @ad, @soyad, @tc)";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@ka", m.KullaniciAdi);
                        cmd.Parameters.AddWithValue("@ad", m.Ad);
                        cmd.Parameters.AddWithValue("@soyad", m.Soyad);
                        cmd.Parameters.AddWithValue("@tc", m.TcKimlik);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        public static List<MusteriModel> TumMusterileriGetir()
        {
            List<MusteriModel> liste = new List<MusteriModel>();
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                string sql = "SELECT * FROM Musteriler ORDER BY Id DESC";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                using (SQLiteDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        liste.Add(new MusteriModel
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            KullaniciAdi = r["KullaniciAdi"].ToString(),
                            Ad = r["Ad"].ToString(),
                            Soyad = r["Soyad"].ToString(),
                            TcKimlik = r["TcKimlik"].ToString()
                        });
                    }
                }
            }
            return liste;
        }

        public static bool MusteriSil(int musteriId)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Baglanti))
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Kiralamalar WHERE MusteriId = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", musteriId);
                        cmd.ExecuteNonQuery();
                    }
                    using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Musteriler WHERE Id = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", musteriId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        
        public static List<ArabaModel> MuasaitAraclariGetir(string sehir, DateTime bas, DateTime bit, string segment)
        {
            List<ArabaModel> liste = new List<ArabaModel>();
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                
                string sql = @"
                    SELECT * FROM Arabalar
                    WHERE (@seg = 'Tümü' OR Segment = @seg)
                    AND Id NOT IN (
                        SELECT ArabaId FROM Kiralamalar
                        WHERE ToplamFiyat != -1
                          AND date(BaslangicTarihi) < date(@bit)
                          AND date(BitisTarihi)     > date(@bas)
                    )
                    
                    ORDER BY GunlukFiyat";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@bas", bas.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@bit", bit.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@seg", segment);
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            liste.Add(new ArabaModel
                            {
                                Id = Convert.ToInt32(r["Id"]),
                                Marka = r["Marka"].ToString(),
                                Model = r["Model"].ToString(),
                                Yil = Convert.ToInt32(r["Yil"]),
                                GunlukFiyat = Convert.ToDouble(r["GunlukFiyat"]),
                                Segment = r["Segment"].ToString(),
                                GorselAdi = r["GorselAdi"].ToString()
                            });
                        }
                    }
                }
            }
            return liste;
        }

        public static List<ArabaModel> TumArabalariGetir()
        {
            List<ArabaModel> liste = new List<ArabaModel>();
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                string sql = "SELECT * FROM Arabalar ORDER BY Segment, Marka";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                using (SQLiteDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        liste.Add(new ArabaModel
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            Marka = r["Marka"].ToString(),
                            Model = r["Model"].ToString(),
                            Yil = Convert.ToInt32(r["Yil"]),
                            GunlukFiyat = Convert.ToDouble(r["GunlukFiyat"]),
                            Segment = r["Segment"].ToString(),
                            GorselAdi = r["GorselAdi"].ToString()
                        });
                    }
                }
            }
            return liste;
        }

        public static bool ArabaEkle(string marka, string model, int yil, double fiyat, string segment, string emoji)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Baglanti))
                {
                    con.Open();
                    string sql = @"INSERT INTO Arabalar (Marka, Model, Yil, GunlukFiyat, Segment, GorselAdi) VALUES (@marka, @model, @yil, @fiyat, @segment, 'default_araba')";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@marka", marka);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@yil", yil);
                        cmd.Parameters.AddWithValue("@fiyat", fiyat);
                        cmd.Parameters.AddWithValue("@segment", segment);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        public static bool ArabaGuncelle(int id, string marka, string model, int yil, double fiyat, string segment, string emoji)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Baglanti))
                {
                    con.Open();
                    string sql = @"UPDATE Arabalar SET Marka=@marka, Model=@model, Yil=@yil, GunlukFiyat=@fiyat, Segment=@segment WHERE Id=@id";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@marka", marka);
                        cmd.Parameters.AddWithValue("@model", model);
                        cmd.Parameters.AddWithValue("@yil", yil);
                        cmd.Parameters.AddWithValue("@fiyat", fiyat);
                        cmd.Parameters.AddWithValue("@segment", segment);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        public static bool ArabaSil(int arabaId)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Baglanti))
                {
                    con.Open();
                    string sql = "DELETE FROM Arabalar WHERE Id = @id";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", arabaId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        
        public static bool KiralamayiKaydet(KiralamModel k, string kuponAdi)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Baglanti))
                {
                    con.Open();
                    string sql = @"INSERT INTO Kiralamalar (MusteriId, ArabaId, Sehir, BaslangicTarihi, BitisTarihi, ToplamFiyat, KuponAdi)
                                   VALUES (@mid, @aid, @sehir, @bas, @bit, @fiyat, @kupon)";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@mid", k.MusteriId);
                        cmd.Parameters.AddWithValue("@aid", k.ArabaId);
                        cmd.Parameters.AddWithValue("@sehir", k.Sehir);
                        cmd.Parameters.AddWithValue("@bas", k.BaslangicTarihi.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@bit", k.BitisTarihi.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@fiyat", k.ToplamFiyat);
                        cmd.Parameters.AddWithValue("@kupon", kuponAdi ?? "");
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        public static List<KiralamaBilgiModel> MusteriKiralamalariniGetir(int musteriId)
        {
            List<KiralamaBilgiModel> liste = new List<KiralamaBilgiModel>();
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                string sql = @"
                    SELECT k.Id, k.Sehir, k.BaslangicTarihi, k.BitisTarihi, k.ToplamFiyat, k.KuponAdi, a.Marka, a.Model
                    FROM Kiralamalar k JOIN Arabalar a ON k.ArabaId = a.Id
                    WHERE k.MusteriId = @mid ORDER BY k.Id DESC";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@mid", musteriId);
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            DateTime bas = DateTime.Parse(r["BaslangicTarihi"].ToString());
                            DateTime bit = DateTime.Parse(r["BitisTarihi"].ToString());
                            double fiyat = Convert.ToDouble(r["ToplamFiyat"]);
                            string durumMetni = "✅ Aktif";
                            if (fiyat == -1) durumMetni = "❌ İptal Edildi";
                            else if (bit < DateTime.Today) durumMetni = "⏹️ Kiralama Süresi Bitti";

                            liste.Add(new KiralamaBilgiModel
                            {
                                Id = Convert.ToInt32(r["Id"]),
                                ArabaAdi = "🚗 " + r["Marka"].ToString() + " " + r["Model"].ToString(),
                                Sehir = r["Sehir"].ToString(),
                                BaslangicTarihi = bas,
                                BitisTarihi = bit,
                                ToplamFiyat = fiyat,
                                KuponAdi = r["KuponAdi"].ToString(),
                                Durum = durumMetni
                            });
                        }
                    }
                }
            }
            return liste;
        }

        public static List<KiralamaDetayModel> TumKiralamalarDetayli()
        {
            List<KiralamaDetayModel> liste = new List<KiralamaDetayModel>();
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                string sql = @"
                    SELECT k.Id, m.Ad || ' ' || m.Soyad || ' (' || m.TcKimlik || ')' AS Musteri,
                           a.Marka || ' ' || a.Model AS Araba, k.Sehir, k.BaslangicTarihi, k.BitisTarihi, k.ToplamFiyat, k.KuponAdi
                    FROM Kiralamalar k 
                    JOIN Arabalar a ON k.ArabaId = a.Id
                    JOIN Musteriler m ON k.MusteriId = m.Id
                    ORDER BY k.Id DESC";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                using (SQLiteDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        liste.Add(new KiralamaDetayModel
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            MusteriBilgi = r["Musteri"].ToString(),
                            ArabaBilgi = r["Araba"].ToString(),
                            Sehir = r["Sehir"].ToString(),
                            BaslangicTarihi = DateTime.Parse(r["BaslangicTarihi"].ToString()),
                            BitisTarihi = DateTime.Parse(r["BitisTarihi"].ToString()),
                            ToplamFiyat = Convert.ToDouble(r["ToplamFiyat"]),
                            KuponAdi = r["KuponAdi"].ToString()
                        });
                    }
                }
            }
            return liste;
        }

        public static bool KiralamayiIptalEt(int kiralamaId)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Baglanti))
                {
                    con.Open();
                    string sql = "UPDATE Kiralamalar SET ToplamFiyat = -1 WHERE Id = @id";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", kiralamaId);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        public static bool KiralamaSil(int kiralamaId)
        {
            return KiralamayiIptalEt(kiralamaId);
        }

        
        public static int ToplamMusteriSayisi() { using (SQLiteConnection con = new SQLiteConnection(Baglanti)) { con.Open(); using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Musteriler", con)) return Convert.ToInt32(cmd.ExecuteScalar()); } }
        public static int ToplamArabaSayisi() { using (SQLiteConnection con = new SQLiteConnection(Baglanti)) { con.Open(); using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Arabalar", con)) return Convert.ToInt32(cmd.ExecuteScalar()); } }
        public static int AktifKiralamaSayisi() { using (SQLiteConnection con = new SQLiteConnection(Baglanti)) { con.Open(); string sql = "SELECT COUNT(*) FROM Kiralamalar WHERE date(BitisTarihi) >= date('now') AND ToplamFiyat != -1"; using (SQLiteCommand cmd = new SQLiteCommand(sql, con)) return Convert.ToInt32(cmd.ExecuteScalar()); } }
        public static double ToplamGelir() { using (SQLiteConnection con = new SQLiteConnection(Baglanti)) { con.Open(); using (SQLiteCommand cmd = new SQLiteCommand("SELECT COALESCE(SUM(ToplamFiyat),0) FROM Kiralamalar WHERE ToplamFiyat != -1", con)) return Convert.ToDouble(cmd.ExecuteScalar()); } }

        public static string KuponIstatistikleri() { return "ALIM20: %60 | SUDE20: %30 | COMU2026: %10"; }

        public static bool YorumKaydet(int arabaId, int musteriId, int puan, string yorum)
        {
            try { using (SQLiteConnection con = new SQLiteConnection(Baglanti)) { con.Open(); string sql = "INSERT INTO Yorumlar (ArabaId, MusteriId, Puan, YorumMetni) VALUES (@aid, @mid, @puan, @yorum)"; using (SQLiteCommand cmd = new SQLiteCommand(sql, con)) { cmd.Parameters.AddWithValue("@aid", arabaId); cmd.Parameters.AddWithValue("@mid", musteriId); cmd.Parameters.AddWithValue("@puan", puan); cmd.Parameters.AddWithValue("@yorum", yorum); cmd.ExecuteNonQuery(); } } return true; }
            catch (Exception) { return false; }
        }

        public static string ArabaPuanDurumuGetir(int arabaId)
        {
            try { using (SQLiteConnection con = new SQLiteConnection(Baglanti)) { con.Open(); string sql = "SELECT AVG(Puan), COUNT(Id) FROM Yorumlar WHERE ArabaId = @aid"; using (SQLiteCommand cmd = new SQLiteCommand(sql, con)) { cmd.Parameters.AddWithValue("@aid", arabaId); using (SQLiteDataReader r = cmd.ExecuteReader()) { if (r.Read() && r[0] != DBNull.Value) { double ortalama = Convert.ToDouble(r[0]); int adet = Convert.ToInt32(r[1]); return $"⭐ {ortalama:F1} ({adet} Değerlendirme)"; } } } } }
            catch (Exception) { }
            return "⭐ 0.0 (0 Değerlendirme)";
        }

        public static List<YorumDetayModel> TumYorumlariGetir()
        {
            List<YorumDetayModel> liste = new List<YorumDetayModel>();
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                string sql = @"
                    SELECT y.Id, a.Marka || ' ' || a.Model AS Araba, m.Ad || ' ' || m.Soyad AS Musteri, y.Puan, y.YorumMetni
                    FROM Yorumlar y JOIN Arabalar a ON y.ArabaId = a.Id JOIN Musteriler m ON y.MusteriId = m.Id ORDER BY y.Id DESC";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                using (SQLiteDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        liste.Add(new YorumDetayModel
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            ArabaBilgi = r["Araba"].ToString(),
                            MusteriBilgi = r["Musteri"].ToString(),
                            Puan = Convert.ToInt32(r["Puan"]),
                            YorumMetni = r["YorumMetni"].ToString()
                        });
                    }
                }
            }
            return liste;
        }

        public static bool YorumSil(int yorumId)
        {
            try { using (SQLiteConnection con = new SQLiteConnection(Baglanti)) { con.Open(); using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Yorumlar WHERE Id = @id", con)) { cmd.Parameters.AddWithValue("@id", yorumId); cmd.ExecuteNonQuery(); } } return true; }
            catch (Exception) { return false; }
        }

        
        public static bool AraciBakimaAl(int arabaId, string sehir)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Baglanti))
                {
                    con.Open();
                    string sql = "INSERT OR IGNORE INTO BakimdakiAraclar (ArabaId, Sehir) VALUES (@aid, @sehir)";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@aid", arabaId);
                        cmd.Parameters.AddWithValue("@sehir", sehir);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        public static bool AraciBakimdanCikar(int arabaId, string sehir)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Baglanti))
                {
                    con.Open();
                    string sql = "DELETE FROM BakimdakiAraclar WHERE ArabaId = @aid AND Sehir = @sehir";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@aid", arabaId);
                        cmd.Parameters.AddWithValue("@sehir", sehir);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception) { return false; }
        }

        public static string BakimSehirleriniGetir(int arabaId)
        {
            List<string> sehirler = new List<string>();
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                string sql = "SELECT Sehir FROM BakimdakiAraclar WHERE ArabaId = @aid ORDER BY Sehir";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@aid", arabaId);
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                            sehirler.Add(r["Sehir"].ToString());
                    }
                }
            }
            return sehirler.Count == 0 ? "" : string.Join(", ", sehirler);
        }
        public static HashSet<int> BakimdakiAracIdleri(string sehir)
        {
            HashSet<int> idler = new HashSet<int>();
            using (SQLiteConnection con = new SQLiteConnection(Baglanti))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT DISTINCT ArabaId FROM BakimdakiAraclar WHERE Sehir = @sehir", con))
                {
                    cmd.Parameters.AddWithValue("@sehir", sehir);
                    using (SQLiteDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                            idler.Add(Convert.ToInt32(r["ArabaId"]));
                    }
                }
            }
            return idler;
        }
    }
}