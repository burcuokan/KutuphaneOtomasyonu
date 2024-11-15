# KutuphaneOtomasyonu
Bu proje, bir kütüphane otomasyon sisteminin temel işlevlerini gerçekleştiren bir yazılım uygulamasıdır. Kullanıcılar, üyelik işlemleri yaparak kitapları yönetebilir, kitap ödünç alabilir ve iade edebilirler. Sistem C# dili ile geliştirilmiş olup, veritabanı yönetimi için SQL kullanılmıştır. Projede kullanılan temel işlevler şunlardır:

🔐 **Kullanıcı Girişi**

---------------------------------------------------------------------------------------------------------

• Sisteme giriş yapabilmek için E-mail ve şifre doğrulaması yapılır.

• Kullanıcı bilgileri veritabanında saklanır ve giriş yapılmadan diğer işlemler yapılamaz.

• Giriş işlemi başarılı olduğunda, kullanıcı ana menüye yönlendirilir.

• Üye kayıt işlemi yapılır.

📑 **Kitap Ekleme**

• Kitap adı, yazarı, türü, yayınevi, basım yılı, stok sayısı, açıklama gibi bilgiler eklenebilir.

📚 **Kitap Listeleme**

• Listeleme işlemi, kitapların adı,yazarı ve diğer önemli bilgileriyle yapılır.

• Kullancılar, kitapları belirli kriterlere göre sıralayabilir veya arama yaparak istedikleri kitaplara hızlıca ulaşabilirler.

👥 **Üye Listeleme**

• Kütüphaneye kayıtlı tüm üyeleri listeleyebilir.

• Üyelerin bilgileri (ad,soyad,tc vb.) veritabanından çekilerek, kolayca görüntülenebilir.

🔄📚 **Emanet Kitap Verme**

• Kütüphanedeki kitaplara üyelere ödünç verilebilir.

• Emanet kitap verme işlemi sırasında, üye bilgileri ve ödünç alınan kitaplar veritabanına kaydedilir.

• Bu işlemde, kitabın ödünç verilme tarihi ve teslim tarihi gibi bilgiler de sisteme dahil edilir.

• Kitap ödünç verildikten sonra, kitap adedi otomatik olarak güncellenir.

📚🔄 **Emanet Kitap İade**

• Kullanıcılar, emanet aldıkları kitapları iade edebilirler.

• Kitap iade edilirken, kitap teslim tarihi ve iade tarihi veritabanına kaydedilir.

• İade işlemi sonrası, kitap tekrar kütüphaneye eklenir ve mevcut adedi güncellenir.

📝 **Emanet Kitap Listeleme**

• Ödünç verilen kitaplar listelenebilir.

• Hangi kitapların gecikmeli olarak iade edilmediği bilgilerde bu listede görüntülenebilir.

**Kullanıcı Girişi**

![Ekran Alıntısı](https://github.com/user-attachments/assets/63c57139-b8c3-44da-8f4f-72024e8bcc24)

**Üye Kayıt**

![Ekran Alıntısı 1](https://github.com/user-attachments/assets/3be24ff8-1c75-4416-934e-02fa2ac7b7ba)

**Kütüphane Takip İşlemleri**

![Ekran Alıntısı 2](https://github.com/user-attachments/assets/12c532d7-793e-4fba-b24f-02e587a67ba5)

**Üye Listeleme**

![Ekran Alıntısı 3](https://github.com/user-attachments/assets/f03d5cf6-c1cd-42a4-8f94-c8c7dc2a3675)

**Kitap Ekleme**

![Ekran Alıntısı 4](https://github.com/user-attachments/assets/fabac1d9-03df-4014-92f8-20324e4d536d)

**Kitap Listeleme**

![Ekran Alıntısı 5](https://github.com/user-attachments/assets/1701968e-8059-45f3-95e1-07e3b788239f)

**Emanet Kitap Verme**

![Ekran Alıntısı 6](https://github.com/user-attachments/assets/d3227c7c-c2e8-4cf9-9f9c-1a0027075c0b)

**Emanet Kitap İade**

![Ekran Alıntısı 7](https://github.com/user-attachments/assets/022f09dd-9658-4004-b155-d147cfaf2da8)

**Emanet Kitap Listeleme**

![Ekran Alıntısı 8](https://github.com/user-attachments/assets/ba622e81-f563-4496-8fbb-82800043ba9f)
