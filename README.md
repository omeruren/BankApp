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

Ekran Görüntüleri



<img width="815" height="580" alt="Ekran görüntüsü 2025-07-15 102230" src="https://github.com/user-attachments/assets/3c88daed-d8d2-4e40-876e-1977cf237efc" />

<img width="641" height="529" alt="Ekran görüntüsü 2025-07-15 102253" src="https://github.com/user-attachments/assets/eb2cfb4e-52c0-412f-a0d2-45106255299e" />

<img width="1335" height="930" alt="Ekran görüntüsü 2025-07-15 102317" src="https://github.com/user-attachments/assets/d11325bf-cd09-49e0-b543-3c7bb2f31c0a" />

<img width="1223" height="546" alt="Ekran görüntüsü 2025-07-15 102407" src="https://github.com/user-attachments/assets/e6ed703c-f1b5-4573-a4e3-480a22e92bb8" />

<img width="624" height="564" alt="Ekran görüntüsü 2025-07-15 102442" src="https://github.com/user-attachments/assets/f0160200-dcd6-4300-953c-84a4c0fcafec" />

<img width="1129" height="600" alt="Ekran görüntüsü 2025-07-15 102539" src="https://github.com/user-attachments/assets/b9f269c8-0749-4128-9f1a-b2bc8963d6e3" />

<img width="963" height="584" alt="Ekran görüntüsü 2025-07-15 102521" src="https://github.com/user-attachments/assets/335842bb-a2ef-4f68-98ba-12e4223b9f62" />


