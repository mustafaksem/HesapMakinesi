# Awesome Calculator App and Note Taking App
Bu, çok amaçlı bir Windows Form uygulamasıdır. İçinde şu özellikleri barındırır:

- Basit Hesap Makinesi
- Uzunluk Dönüştürücü
- Veri Hesaplayıcı
- Tarih Hesaplayıcı
- Not alma uygulaması

## Ekran Görüntüleri
<img src="HesapMakinesi/image/HesapMakinesi.PNG" width = "250" height="350"> <img src="HesapMakinesi/image/TarihHesaplayici.PNG" width = "250" height="350">

<img src="HesapMakinesi/image/UzunlukHesaplayici.PNG" width = "250" height="350"> <img src="HesapMakinesi/image/VeriHesaplayici.PNG" width = "250" height="350">


## Özellikler

### Basit Hesap Makinesi

- Toplama, çıkarma, çarpma, bölme gibi temel matematiksel işlemlerin yanı sıra mod alma, faktöriyel hesabı, yüzde hesabı, üs hesabı vb işlemleri destekler.
- Temizleme ve geri alma özellikleri.

### Uzunluk Dönüştürücü

- Farklı uzunluk birimleri arasında dönüşüm yapma imkanı.
- Milimetreden kilometreye, inch'ten metreye birçok birimi destekler.

### Veri Hesaplayıcı

- Veri dönüşümü için kullanılır.
- Byte, kilobyte, megabyte gibi birimler arasında dönüşüm yapabilir.

### Tarih Hesaplayıcı

- İki tarih arasındaki farkı hesaplamak için kullanılır.
- Gün, saat, dakika cinsinden farkı gösterir.
  
### Not alma uygulaması 
Bu uygulama basit bir not alım ve yönetim uygulamasıdır. İşlevleri şu şekildedir:
1.	Yeni Not Ekleme (btnNew_Click): Kullanıcı bu butona tıklayarak yeni bir not ekleyebilir. Bu durumda "Başlık" ve "Mesajlar" alanları temizlenir.
2.	Notu Kaydetme (btnSave_Click): Kullanıcı "Başlık" ve "Mesajlar" alanlarına metin girdikten sonra bu butona tıklayarak notu kaydedebilir. Eğer başlık veya mesaj alanları boşsa bir uyarı mesajı gösterilir.
3.	Notları Görüntüleme (btnRead_Click): Kullanıcı DataGridView'de bir nota tıklayarak bu butona tıklayarak seçili notu görüntüleyebilir. Eğer not seçilmemişse bir uyarı mesajı gösterilir.
4.	Notu Silme (btnDelete_Click): Kullanıcı DataGridView'de bir nota tıklayarak bu butona tıklayarak seçili notu silebilir. Eğer not seçilmemişse bir uyarı mesajı gösterilir.
Notlar, DataTable kullanılarak saklanır ve DataGridView üzerinden kullanıcıya gösterilir. Bu şekilde, kullanıcı notları ekleyebilir, görüntüleyebilir ve silebilir. Eğer başlık veya mesaj alanları boşsa veya not seçilmemişse uygun uyarı mesajları gösterilir.

