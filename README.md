# arac_kiralama_otomasyonu
![image](https://user-images.githubusercontent.com/72393571/176912829-774559b6-0d38-40c4-b206-e727391a21a6.png)
Kullanıcı, müşteri, araç, sözleşme, satış, araç markalarını ve araç modellerini tutan 7 adet tablomuz bulunmaktadır.
•	kullanici tablosunda kullanıcı, şifre ve yetki bilgileri varchar tipinde saklanmaktadır.

•	musteri tablosunda musteri_id primary key’dir ve int tipinde saklanmaktadır. musteri_adi, musteri_soyadi, sehir, adres ve telefon bilgileri varchar tipinde saklanmaktadır. musteri_yas bilgisi ise int tipinde saklanmaktadır.

•	arac_markalari tablosunda marka_adi primary key’dir ve veri tipi varchar’dır.

•	arac_modelleri tablosunda model_id primary key’dir ve int veri tipinde saklanmaktadır.marka_adi, arac_markalari tablosu ile bağlantı sağlayan foreing key’dir ve veri tipi varchar’dır. model bilgisi ise varchar veri tipi ile saklanmaktadır.

•	arac tablosunda arac_plaka primary key’dir ve veri tipi varchar’dır. model_id, arac_modelleri tablosu ile bağlantı sağlayan foreign key’dir ve veri tipi int’tir. yil, kilometre ve renk bilgileri varchar veri tipi ile saklanmaktadır. fiyat ve kiralama_bedeli  bilgileri ise money veri tipi ile saklanmaktadır.

•	satis tablosunda satis_id primary key’dir ve int tipinde saklanmaktadır. musteri_id, musteri tablosu ile bağlantı sağlayan foreign key’dir ve veri tipi int’tir. marka, model ve renk bilgileri varchar veri tipi ile saklanmaktadır. fiyat bilgisi money veri tipi ile saklanmaktadır.

•	sozlesme tablosunda sozlesme_id primary key’dir ve int tipinde saklanmaktadır. musteri_id, musteri tablosu ile bağlantı sağlayan foreign key’dir ve veri tipi int’tir. Aynı şekilde arac_plaka, arac tablosu ile bağlantı sağlayan foreign key’dir ve veri tipi varchar’dır. gun_sayisi bilgisi int veri tipi ile, ucret bilgisi ise money veri tipinde saklanmaktadır.

•	id içeren kolonların tamamında IDENTITY kullanılarak otomatik atanma sağlanmıştır.

![image](https://user-images.githubusercontent.com/72393571/176913136-5ef8f9c1-f302-4d33-8dd9-5bbe8839b4cf.png)

![image](https://user-images.githubusercontent.com/72393571/176913180-6902286d-fd83-4059-9bcf-f8a7cdd4dced.png)

![image](https://user-images.githubusercontent.com/72393571/176913228-d72623cf-6609-47d0-a0d0-a45e4827a809.png)

![image](https://user-images.githubusercontent.com/72393571/176913279-1185ec07-0998-4a38-91c2-862fd325925c.png)

