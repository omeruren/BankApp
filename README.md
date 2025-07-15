🏦 RensBank Uygulaması
Bu proje, C# Windows Forms kullanılarak geliştirilmiş gerçekçi bir bankacılık uygulamasıdır. Uygulama, kullanıcıların hesap oluşturmasına, giriş yapmasına, bakiye görüntülemesine, para yatırıp çekmesine, havale yapmasına ve işlem geçmişini görüntülemesine olanak tanır.

🚀 Özellikler

• ✅ Kullanıcı kayıt ve giriş sistemi (SHA256 ile şifreleme)

• ✅ Hesap oluşturma (benzersiz hesap no)

• ✅ Para yatırma / çekme işlemleri

• ✅ Havale (başka hesaba transfer)

• ✅ İşlem geçmişi ve filtreleme (tarih, işlem türü)

• ✅ Dekont çıktısı (PDF ve yazıcı destekli)

• ✅ Yönetici (Admin) paneli:

  • Toplam bakiye, kullanıcı, hesap istatistikleri

  • Günlük işlem grafiği

  • İşlem türlerine göre analiz


🧩 Kullanılan Teknolojiler
• C# Windows Forms (.NET Framework)

• Microsoft SQL Server

• ADO.NET (SqlConnection, SqlCommand)

• System.Drawing & Printing (çıktı alma)

• iTextSharp (PDF üretimi)

🛠️ Kurulum Talimatları

1. Bu repository’i indir veya klonla:
  git clone https://github.com/kullaniciadiniz/RensBank.git

2. Visual Studio ile RensBank.sln dosyasını aç.
  
3. Veritabanını kur:
   SQL Server Management Studio (SSMS) ile giriş yap.
   /Database klasöründeki Init.sql dosyasını çalıştır:
   Yeni bir veritabanı oluşturur.
   Gerekli tablolar ve örnek veriler eklenir.

4. Bağlantı ayarını yap:
    Connection.cs veya App.config dosyasındaki bağlantı cümlesini kendine göre güncelle:

örnek:
    string connStr = "Data Source=.;Initial Catalog=RensBank;Integrated Security=True";
    
Uygulamayı başlat:
    Giriş formundan kullanıcı kaydı oluşturup tüm özellikleri test edebilirsin.






  
