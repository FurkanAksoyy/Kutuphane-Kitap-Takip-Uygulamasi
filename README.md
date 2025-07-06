# Kütüphane Kitap Takip Uygulaması

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-blue)](https://dotnet.microsoft.com/download/dotnet-framework)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-red)](https://www.microsoft.com/sql-server)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop-green)](https://docs.microsoft.com/dotnet/desktop/winforms)

Kütüphane işlemlerini yönetmek için geliştirilmiş masaüstü uygulaması. Kitap katalogları, üye yönetimi ve rezervasyon takibi özellikleri içerir.

## 📋 İçindekiler

- [Özellikler](#özellikler)
- [Sistem Gereksinimleri](#sistem-gereksinimleri)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Ekran Görüntüleri](#ekran-görüntüleri)
- [İletişim](#iletişim)

## ✨ Özellikler

### 👨‍💼 Yönetici Özellikleri
- Kitap ekleme, düzenleme ve silme
- Üye listesini görüntüleme ve yönetme
- Tüm rezervasyonları takip etme
- Sistem yönetimi

### 👥 Üye Özellikleri
- Kitap arama ve listeleme
- Kitap rezervasyonu (maksimum 3 kitap)
- Kişisel rezervasyon takibi
- Süresi geçen rezervasyonlar için uyarı

## 💻 Sistem Gereksinimleri

- **İşletim Sistemi**: Windows 10/11
- **Geliştirme Ortamı**: Visual Studio 2019 veya üzeri
- **Framework**: .NET Framework 4.7.2
- **Veritabanı**: SQL Server (Express ya da tam sürüm)
- **RAM**: 4GB minimum
- **Depolama**: 500MB boş alan

## 🚀 Kurulum

### 1. Ön Gereksinimler
- Visual Studio 2019 veya üzeri kurulu olmalı
- SQL Server Express veya tam sürüm kurulu olmalı
- SQL Server Management Studio (SSMS) önerilir

### 2. Veritabanını Geri Yükleme (.bak)

1. **SSMS'yi açın** ve sunucuya bağlanın
2. **Databases** üzerinde sağ tık → **Restore Database...**
3. **Source** → **Device** → **[...]** → **Add**
4. **LibraryDB.bak** dosyasını seçin
5. **Destination Database** adını **"LibraryDB"** olarak bırakın
6. **OK**'e basın; restore işlemi tamamlanacaktır

### 3. Projeyi Çalıştırma

1. **Visual Studio'yu açın**
2. **File** → **Open** → **Project/Solution**
3. **`Library_Kitap_Takip_Uygulaması.sln`** dosyasını seçin
4. Çözümü derleyin (**Build** → **Build Solution**)
5. Çalıştırmak için **F5** tuşuna basın

## 👤 Örnek Kullanıcı Bilgileri

### Admin Hesabı
- **Kullanıcı Adı**: `FurkanAks`
- **Şifre**: `furkan123`
- **Yetki**: Tam erişim

### Üye Hesabı
- **Kullanıcı Adı**: `EmreOlc`
- **Şifre**: `emre123`
- **Yetki**: Kitap rezervasyonu

## 📖 Kullanım

### Giriş Yapma
1. Uygulama açıldığında giriş ekranında yukarıdaki kullanıcı bilgileriyle oturum açın

### Yönetici Paneli
1. **"Books"** sekmesi:
   - Kitap ekleyin/güncelleyin/silin
   - Kitap detaylarını düzenleyin

2. **"Members"** sekmesi:
   - Üye listesini görüntüleyin
   - Üye bilgilerini yönetin

3. **"Reservations"** sekmesi:
   - Tüm rezervasyonları görüntüleyin
   - Süresi geçen rezervasyonları takip edin

### Üye Paneli
1. **Kitap Arama ve Listeleme**:
   - Mevcut kitapları görüntüleyin
   - Arama yaparak istediğiniz kitabı bulun

2. **Rezervasyon Yapma**:
   - Seçili kitabı **"Reserve"** butonuyla rezerve edin
   - En fazla 3 rezervasyon yapabilirsiniz

3. **Rezervasyon Takibi**:
   - Alt kısımdaki listede kendi rezervasyonlarınızı izleyin
   - Süresi geçmişse kırmızı renkle vurgulanır

## 🗄 Veritabanı Yapısı

- **Books**: Kitap bilgileri (ISBN, başlık, yazar, tür)
- **Members**: Üye bilgileri ve hesap detayları
- **Reservations**: Rezervasyon kayıtları
- **Users**: Kullanıcı giriş bilgileri

## 🛠 Sorun Giderme

### Yaygın Sorunlar

1. **Veritabanı Bağlantı Hatası**
   - SQL Server servisinin çalıştığından emin olun
   - Bağlantı dizesini kontrol edin

2. **Giriş Yapamama**
   - Verilen test hesaplarını kullanın
   - Veritabanının doğru yüklendiğinden emin olun

3. **Build Hataları**
   - NuGet paketlerini geri yükleyin
   - .NET Framework 4.7.2'nin kurulu olduğunu kontrol edin

## 📞 İletişim

**Sorularınız için**: furkanaksoy178@gmail.com

### Destek
- **E-posta**: furkanaksoy178@gmail.com  
- **Yanıt Süresi**: 24-48 saat içinde
- **Çalışma Saatleri**: Pazartesi-Cuma, 09:00-18:00

## 📄 Lisans

Bu proje MIT Lisansı altında lisanslanmıştır.
