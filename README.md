# Market Stok Takip Otomasyonu

## Proje Hakkında
Bu proje, bir marketin stok yönetimini kolaylaştırmak amacıyla geliştirilmiş bir otomasyon sistemidir. Kullanıcılar, yetkilerine bağlı olarak stok yönetimi ve kullanıcı işlemlerini gerçekleştirebilirler.

## Dosya İçeriği

**RAR İçeriği:**
- **1 - Stok Klasörü:** Projenin tamamını içerir. İçeriğinde şunlar bulunur:
  - Kaynak kodları
  - Görseller ve simgeler
  - `.sln` dosyası
  - Designer kodları
  - `veritabanı.mdb` (Konum: `bin >> debug >> App_data >> veritabanı.mdb`)

- **2 - Kaynak Kodları Klasörü:** Yalnızca arka planda çalışan kodları içerir. Bu klasör, projenin kodlarını daha rahat incelemek için eklenmiştir. Aynı dosyalar "Stok Klasörü" içinde de mevcuttur.

- **3 - Demir Market Exe'si:**
  - Projenin kurulum dosyasıdır.
  - Kurulum tamamlandığında, "Program Dosyaları (x86)" klasöründe "Demir Market" adlı bir klasör oluşturur.
  - Masaüstüne gelen "Demir Market" kısayolunu yönetici olarak çalıştırarak programı başlatabilirsiniz.

- **4 - `veritabanı.mdb` (Access Veritabanı)**
  - İçeriğinde üç tablo bulunur:
    - `Kayitlilar`
    - `Urunler`
    - `Kategori`

## Kullanım Kılavuzu

- **Giriş Ekranı:**
  - Kullanıcılar, veritabanındaki rollerine göre yönlendirilir.
  - **Admin girişi:** Kullanıcı adı: `a`, Şifre: `a`
  - **Personel girişi:** Kullanıcı adı: `b`, Şifre: `b`
  - Adminler, personelin erişebildiği tüm özelliklere ek olarak "Kullanıcı Yönetimi" menüsüne erişebilir.

### Özellikler
#### **Stok Yönetim Menüsü**
- **Stok Ekle:**
  - `Urunler` tablosuna yeni ürün ekleyebilirsiniz.
  - Yeni bir kategori eklemek için kategori kutucuğundaki `+` sembolüne tıklayabilirsiniz.
- **Stok Güncelle:**
  - Mevcut ürünlerin adet ve fiyat bilgilerini değiştirebilirsiniz.
- **Stok Sil:**
  - Ürünleri seçerek çöp kutusu simgesine tıklayıp silme işlemini onaylayarak stoktan kaldırabilirsiniz.

#### **Kullanıcı Yönetim Menüsü** (Yalnızca Admin)
- **Kullanıcı Ekle:** Yeni kullanıcı ekleyebilirsiniz (`Kayitlilar` tablosuna kaydedilir).
- **Kullanıcı Sil:** Mevcut kullanıcıları veritabanından silebilirsiniz.

#### **Stok Sayım Menüsü**
- Seçili ürünün stok doluluk oranını görsel bir progress bar aracılığıyla takip edebilirsiniz.

---

Bu proje hakkında daha fazla bilgi veya katkı sağlamak için lütfen [GitHub sayfamızdan](#) bizimle iletişime geçin!

