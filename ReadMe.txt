Kütüphane Kitap Takip Uygulaması 

1. Çalıştırma Gereksinimleri
   - Windows 10/11
   - Visual Studio 2019 veya üzeri (.NET Framework 4.7.2)
   - SQL Server (Express ya da tam sürüm)

2. Veritabanını Geri Yükleme (.bak)
   a. SSMS’yi açın ve sunucuya bağlanın.
   b. Databases üzerinde sağ tıklayın → Restore Database…
   c. Source → Device → […] → Add → LibraryDB.bak dosyasını seçin.
   d. Destination Database adını “LibraryDB” olarak bırakın.
   e. OK’e basın; restore işlemi tamamlanacaktır.

3. Projeyi Çalıştırma
   a. Visual Studio’yu açın.
   b. File → Open → Project/Solution → `Library_Kitap_Takip_Uygulaması.sln` dosyasını seçin.
   c. Çözümü derleyin (Build → Build Solution).
   d. Çalıştırmak için **F5** tuşuna basın.

4. Örnek Kullanıcı Bilgileri
   - **Admin**  
     Username: FurkanAks  
     Password: furkan123  

   - **Member**  
     Username: EmreOlc  
     Password: emre123  

5. Kullanım
   1. Giriş ekranında yukarıdaki kullanıcı bilgileriyle oturum açın.
   2. **Admin Panel** için:
      - “Books” sekmesinden kitap ekleyin/güncelleyin/siliniz.
      - “Members” sekmesinden üye listesini görüntüleyin.
      - “Reservations” sekmesinden tüm rezervasyonları görüntüleyin.
   3. **Member Panel** için:
      - Kitapları listeleyip arama yapın.
      - Seçili kitabı “Reserve” butonuyla rezerve edin (en fazla 3 rezervasyon).
      - Alt kısımdaki listede kendi rezervasyonlarınızı izleyin; süresi geçmişse kırmızı renkle vurgulanır.

6. İletişim
   - Sorularınız için: furkanaksoy178@gmail.com
