# 🎸 Crazy Musicians API 🎶

Crazy Musicians API, çılgın müzisyenleri yönetmek için eğlenceli ve hafif bir ASP.NET Core Web API projesidir. Bu API, CRUD işlemlerini (Oluşturma, Okuma, Güncelleme, Silme) destekler ve etkili yönlendirme (routing) ile doğrulama tekniklerini sergiler.

---
### Veriler
| ID | Ad | Meslek | Eğelenceli Özellik |
| --------------- | --------------- | --------------- | --------------- |
| 1 | Ahmet Çalgı | Ünlü Çalgı Çalar |  Her zaman yanlış nota çalar, ama çok eğlenceli | 
| 2 | Zeynep Melodi | Popüler Melodi Yazarı |  Şarkıları yanlış anlaşılır ama çok popüler |
| 3 | Cemil Akor | Çılgın Akorist | Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli |
| 4 | Fatma Nota | Sürpriz Nota Üreticisi |  Nota üretirken sürekli süprizler hazırlar |
| 5 | Hasan Ritim | Ritim Canavarı |  Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir | 
| 6 | Elif Armoni | Armoni Ustası |  Armonilerini bazen yanlış çalar, ama çok yaratıcıdır |
| 7 | Ali Perde | Perde Uygulayıcısı |  Her perdeyi farklı şekilde çalar, her zaman süprizlidir |
| 8 | Ayşe Rezonans | Rezosans Uzmanı |  Rezonans konusunda uzman, ama bazen çok gürültü çıkarır |
| 9 | Murat Ton | Tonlama Meraklısı |  Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç |
| 10| Selin Akor | Akor Sihirbazı |  Akorları değiştirdiğinde bazen sihirli bir hava yaratır |
## 🧩 Özellikler

- **CRUD İşlemleri**:
  - `GET` - Tüm müzisyenleri listeleyin veya isimle arama yapın.
  - `POST` - Yeni bir müzisyen ekleyin.
  - `PUT` - Var olan bir müzisyeni tamamen güncelleyin.
  - `PATCH` - Bir müzisyenin bilgilerini kısmen güncelleyin.
  - `DELETE` - Bir müzisyeni listeden kaldırın.
- **Routing (Yönlendirme)**:
  - Galactic Tour tarzı yönlendirme ile kolay ve esnek API erişimi.
- **Validation (Doğrulama)**:
  - Müzisyen verilerinin doğru bir şekilde girildiğinden emin olun (örneğin, isimler boş olamaz, yaş gerçekçi olmalıdır).
- **Arama İşlevselliği**:
  - `[FromQuery]` kullanarak isimle filtreleme yapabilirsiniz.


