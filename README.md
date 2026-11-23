# SUAL Araç Kiralama Sistemi

**Ders:** Görsel Programlama
**Platform:** Windows Forms (.NET Framework 4.7.2)
**Veritabanı:** SQLite
**IDE:** Visual Studio 2022

## İçindekiler

1. [Proje Hakkında](#proje-hakkında)
2. [Gereksinimler](#gereksinimler)
3. [Projeyi Çalıştırma](#projeyi-çalıştırma)
4. [Kullanıcı Rolleri ve Giriş](#kullanıcı-rolleri-ve-giriş)
5. [Müşteri Paneli Kullanımı](#müşteri-paneli-kullanımı)
6. [Yönetici (Admin) Paneli Kullanımı](#yönetici-admin-paneli-kullanımı)
7. [Veritabanı Yapısı](#veritabanı-yapısı)
8. [Proje Dosya Yapısı](#proje-dosya-yapısı)
9. [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
10. [Öne Çıkan Özellikler](#öne-çıkan-özellikler)

## Proje Hakkında

**SUAL Araç Kiralama**, gerçek bir araç kiralama şirketinin ihtiyaçlarını karşılayacak şekilde tasarlanmış, iki katmanlı (müşteri + yönetici) bir masaüstü uygulamasıdır.

Müşteriler TC Kimlik numarasıyla sisteme giriş yaparak 81 ilden araç kiralayabilir, kupon kullanabilir ve araçları puanlayabilir. Yönetici ise canlı dashboard, filo yönetimi, bakım sistemi, kiralama takibi ve yorum moderasyonu gibi kapsamlı araçlara sahiptir.

Veritabanı olarak SQLite kullanılmaktadır; uygulama ilk çalıştığında veritabanı dosyasını ve tabloları otomatik olarak oluşturur, herhangi bir kurulum gerektirmez.

## Gereksinimler

| Gereksinim | Açıklama |
|---|---|
| İşletim Sistemi | Windows 10 / 11 |
| IDE | Visual Studio 2022 (Community Edition yeterli) |
| .NET Framework | 4.7.2 veya üstü |
| NuGet Paketi | `System.Data.SQLite` (proje açıldığında otomatik yüklenir) |

## Projeyi Çalıştırma

1. Depoyu klonlayın:
   ```
   git clone <repo-url>
   ```
2. `SUAL_AracKiralama/SUAL_AracKiralama.sln` dosyasına çift tıklayarak Visual Studio'da açın.
3. NuGet paketlerini geri yükleyin (normalde otomatik yüklenir):
   - Üst menüden → Araçlar → NuGet Paket Yöneticisi → Paket Yöneticisi Konsolu
   - Konsolda şunu yazın: `Update-Package -reinstall`
   - Veya Solution Explorer → Projeye sağ tık → NuGet Paketlerini Yönet → `System.Data.SQLite` paketinin yüklü olduğunu kontrol edin.
4. Çalıştırın:
   - Klavyeden **F5** tuşuna basın veya üst menüdeki **Start** butonuna tıklayın.
   - Uygulama ilk açılışta `SUAL_Kiralama.db` dosyasını ve 24 adet örnek aracı otomatik olarak oluşturur.

## Kullanıcı Rolleri ve Giriş

| Rol | Giriş Bilgileri | Açıklama |
|---|---|---|
| Yönetici (Admin) | Kullanıcı Adı: `admin` | Tam yetkili yönetici paneline erişim |
| Müşteri | Herhangi bir kullanıcı adı girin | Müşteri paneline yönlendirilir |

- Giriş ekranında kullanıcı adı ve şifre girilir.
- `admin` kullanıcı adı girildiğinde → Yönetici Paneli açılır.
- Başka herhangi bir kullanıcı adı girildiğinde → Müşteri Paneli açılır.
- Müşteri panelinde ek olarak TC Kimlik doğrulaması yapılır.

## Müşteri Paneli Kullanımı

### Giriş / Kayıt

Müşteri paneli açıldığında ortada bir TC Kimlik Doğrulama kutusu çıkar:

- **Mevcut Müşteri:** 11 haneli TC Kimlik numarasını girerek **TC ile Giriş Yap** butonuna tıklayın.
- **Yeni Müşteri:** **Yeni Kayıt Oluştur** linkine tıklayıp Ad, Soyad ve TC bilgilerini girerek sisteme kayıt olun.

### Araç Arama ve Kiralama

Giriş yaptıktan sonra Kiralama ekranı açılır:

1. Sol filtreleme panelinden:
   - Şehir seçin (81 il listelenir, varsayılan: İstanbul)
   - Başlangıç Tarihi seçin
   - Bitiş Tarihi seçin
   - Segment filtresi seçin (Ekonomi, Orta, SUV, Premium, Tümü)
   - **Araç Ara** butonuna tıklayın
2. Sağda araç kartları listelenir:
   - Her kart araç görseli, marka/model, yıl, segment, puan ve fiyat bilgisi içerir
   - Bakımdaki araçlar gri kartla ve "BAKIMDA" etiketi ile gösterilir (kiralanamaz)
   - Müsait araçlar renkli kartla gösterilir ve **Kirala** butonuyla kiralanabilir
3. Kiralama onay penceresi:
   - Araç bilgileri ve toplam tutar gösterilir
   - Kupon kodu seçilebilir (ALIM20, COMU2026, SUDE30)
   - Kupon seçildiğinde indirimli fiyat canlı olarak güncellenir
   - **Ödemeyi Yap ve Kirala** butonu ile kiralama tamamlanır

> **Önemli:** Bir araç kiralandığında, o tarih aralığında tüm şehirlerde listeden otomatik olarak kaldırılır (tekrarlı kiralama engellenir).

### Kiralamalarım

Sağ üst köşedeki **Kiralamalarım** butonuna tıklayarak:

- Geçmiş ve aktif kiralamalarınızı görüntüleyebilirsiniz
- Aktif kiralamalara sağ tık ile **Kiralamayı İptal Et** seçeneğini kullanabilirsiniz
- Süresi bitmiş kiralamalara sağ tık ile **Yorum Yap / Puan Ver** yapabilirsiniz (1-5 yıldız)

## Yönetici (Admin) Paneli Kullanımı

Admin paneli sol taraftaki sidebar menüsü ile 4 ana bölümden oluşur:

### Dashboard (Özet Raporlar)

| Kart | Açıklama |
|---|---|
| Şirket Toplam Cirosu | Tüm kiralamaların toplam geliri (₺) |
| Aktif Kiralama | Şu an devam eden kiralama sayısı |
| Toplam Müşteri | Sisteme kayıtlı müşteri sayısı |
| Kupon İstatistikleri | Kupon kullanım oranları |

### Filo Yönetimi

**Sol taraf — Araç Tablosu:**
- Filodaki tüm araçlar listelenir (ID, Marka, Model, Yıl, Fiyat, Segment)
- Segmentlere göre satırlar renklendirilir (Mor = Premium, Yeşil = SUV, Mavi = Orta, Beyaz = Ekonomi)
- Bir satıra tıklayarak aracı seçin

**Sağ taraf — Araç Ekle/Düzenle Paneli:**

| İşlem | Açıklama |
|---|---|
| Yeni Araç Ekle | Marka, Model, Yıl, Fiyat, Segment girerek filoya yeni araç ekler |
| Seçili Aracı Güncelle | Tablodan seçilen aracın bilgilerini günceller |
| Seçili Aracı Sil | Tablodan seçilen aracı filodan kaldırır |

**Bakım Yönetimi:**
1. Tablodan bir araç seçin
2. Şehir açılır listesinden bakım yapılacak şehri seçin
3. **Bu Şehirde Bakıma Al** → Araç o şehirde müşterilere "Bakımda" olarak gösterilir
4. **Bu Şehirde Bakımdan Çıkar** → Araç tekrar kiralanabilir hale gelir
5. Alt kısımda seçili aracın hangi şehirlerde bakımda olduğu gösterilir

> **Not:** Bakım sistemi şehir bazlıdır. Bir araç İstanbul'da bakımdayken Ankara'da kiralanabilir.

### Kiralama Takibi

- Tüm kiralamaların detaylı listesi (Müşteri, Araç, Şehir, Tarihler, Tutar, Kupon, Durum)
- Arama kutusu ile TC, müşteri adı veya araç adına göre filtreleme
- Durum renkleri: Yeşil = Aktif | Kırmızı = İptal Edilmiş
- **Seçili Kiralamayı İptal Et** butonu ile yönetici herhangi bir kiralamayı iptal edebilir

### Yorum & Şikayet Paneli

- Müşterilerin araçlara yaptığı tüm yorumlar listelenir
- Yıldız puanları gösterilir (★★★★★ formatında)
- Düşük puanlı yorumlar kırmızı, yüksek puanlılar yeşil arka planla vurgulanır
- **Seçili Yorumu Sil** butonu ile uygunsuz yorumlar silinebilir

## Veritabanı Yapısı

Uygulama çalıştırıldığında veritabanı dosyası EXE ile aynı klasörde oluşturulur: `SUAL_AracKiralama/bin/Debug/SUAL_Kiralama.db`

`DB Browser for SQLite` (ücretsiz, [sqlitebrowser.org](https://sqlitebrowser.org/dl/)) ile veritabanını inceleyebilirsiniz.

### Musteriler

| Sütun | Tip | Açıklama |
|---|---|---|
| Id | INTEGER (PK) | Otomatik artan benzersiz kimlik |
| KullaniciAdi | TEXT (UNIQUE) | Sistem kullanıcı adı |
| Ad | TEXT | Müşteri adı |
| Soyad | TEXT | Müşteri soyadı |
| TcKimlik | TEXT (UNIQUE) | 11 haneli TC Kimlik numarası |
| KayitTarihi | TEXT | Kayıt tarihi (otomatik) |

### Arabalar

| Sütun | Tip | Açıklama |
|---|---|---|
| Id | INTEGER (PK) | Otomatik artan benzersiz kimlik |
| Marka | TEXT | Araç markası (ör: Renault) |
| Model | TEXT | Araç modeli (ör: Clio) |
| Yil | INTEGER | Üretim yılı |
| GunlukFiyat | REAL | Günlük kiralama ücreti (₺) |
| Segment | TEXT | Ekonomi / Orta / SUV / Premium |
| GorselAdi | TEXT | Resources klasöründeki görsel dosya adı |

### Kiralamalar

| Sütun | Tip | Açıklama |
|---|---|---|
| Id | INTEGER (PK) | Otomatik artan benzersiz kimlik |
| MusteriId | INTEGER (FK) | Kiralayan müşterinin ID'si |
| ArabaId | INTEGER (FK) | Kiralanan aracın ID'si |
| Sehir | TEXT | Kiralama şehri |
| BaslangicTarihi | TEXT | Kiralama başlangıç tarihi (YYYY-MM-DD) |
| BitisTarihi | TEXT | Kiralama bitiş tarihi (YYYY-MM-DD) |
| ToplamFiyat | REAL | Toplam ücret (₺), iptal edilmişse `-1` |
| KuponAdi | TEXT | Kullanılan kupon kodu (varsa) |
| KayitTarihi | TEXT | Kayıt tarihi (otomatik) |

### Yorumlar

| Sütun | Tip | Açıklama |
|---|---|---|
| Id | INTEGER (PK) | Otomatik artan benzersiz kimlik |
| ArabaId | INTEGER (FK) | Yorumlanan aracın ID'si |
| MusteriId | INTEGER (FK) | Yorumu yapan müşterinin ID'si |
| Puan | INTEGER | 1-5 arası yıldız puanı |
| YorumMetni | TEXT | Müşterinin yazdığı yorum |

### BakimdakiAraclar

| Sütun | Tip | Açıklama |
|---|---|---|
| Id | INTEGER (PK) | Otomatik artan benzersiz kimlik |
| ArabaId | INTEGER (FK) | Bakımdaki aracın ID'si |
| Sehir | TEXT | Aracın bakımda olduğu şehir |

> **Not:** `ArabaId` + `Sehir` birleşimi UNIQUE'dir — aynı araç aynı şehirde birden fazla kez bakıma alınamaz.

## Proje Dosya Yapısı

```
SuAl/
├── README.md                        ← Bu dosya
├── README.pdf                       ← Orijinal proje dokümantasyonu
└── SUAL_AracKiralama/
    ├── SUAL_AracKiralama.sln        ← Visual Studio Solution dosyası
    └── SUAL_AracKiralama/
        ├── Program.cs               ← Uygulama giriş noktası
        ├── DatabaseHelper.cs        ← Veritabanı işlemleri (tüm SQL sorguları)
        ├── Form1.cs                 ← Giriş ekranı (Login)
        ├── Form1.Designer.cs        ← Giriş ekranı tasarımı
        ├── MusteriForm.cs           ← Müşteri paneli (arama, kiralama, yorum)
        ├── MusteriForm.Designer.cs  ← Müşteri paneli tasarımı
        ├── AdminForm.cs             ← Yönetici paneli (dashboard, filo, bakım)
        ├── AdminForm.Designer.cs    ← Yönetici paneli tasarımı
        ├── Properties/              ← Proje meta bilgileri, ayarlar, kaynaklar
        └── Resources/               ← Araç görselleri (27 adet .jpg)
```

## Kullanılan Teknolojiler

| Teknoloji | Kullanım Amacı |
|---|---|
| C# (.NET Framework 4.7.2) | Ana programlama dili |
| Windows Forms (WinForms) | Masaüstü arayüz geliştirme |
| SQLite | Hafif, dosya tabanlı ilişkisel veritabanı |
| System.Data.SQLite | C# ile SQLite arasındaki köprü (NuGet paketi) |
| GDI+ | Giriş ekranındaki özel grafik çizimleri |
| Visual Studio 2022 | Geliştirme ortamı |

## Öne Çıkan Özellikler

**Akıllı Tekrarlı Kiralama Engeli** — Bir araç kiralandığında, o tarih aralığında hiçbir müşteri tarafından, hiçbir şehirde tekrar kiralanamaz. SQL'deki tarih çakışma algoritması bunu otomatik olarak engeller.

**Şehir Bazlı Bakım Sistemi** — Yönetici bir aracı belirli bir şehirde bakıma alabilir. Araç sadece o şehirde "Bakımda" olarak görünür, diğer şehirlerde kiralanmaya devam eder.

**Kupon / Kampanya Sistemi** — Kiralama sırasında kupon kodu seçilebilir, indirimli fiyat canlı olarak hesaplanır (ALIM20 → %20, COMU2026 → %20, SUDE30 → %30 indirim).

**Gerçek Araç Görselleri** — Her araç için `Resources` klasöründe gerçek görseller bulunur, kartlarda otomatik olarak yüklenir.

**Puan ve Yorum Sistemi** — Müşteriler süresi biten kiralamalara 1-5 yıldız puan ve yorum verebilir; araç kartlarında ortalama puan canlı olarak gösterilir.

**Canlı Dashboard** — Yönetici anında toplam ciro, aktif kiralama sayısı, müşteri sayısı ve kupon istatistiklerini görüntüleyebilir.

**Gelişmiş Arama** — Kiralama takibinde TC numarası, müşteri adı veya araç markası ile anlık filtreleme yapılabilir.
