using CrazyMusicians.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusicians.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        private static readonly List<Musician> musicians = new List<Musician>()
        {
            new Musician { Id = 1, Name = "Ahmet Çalgı", Profession = "Ünlü Çalgı Çalar", FunFeature = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
            new Musician { Id = 2, Name = "Zeynep Melodi", Profession = "Popüler Melodi Yazarı", FunFeature = "Şarkıları yanlış anlaşılır ama çok popüler" },
            new Musician { Id = 3, Name = "Cemil Akor", Profession = "Çılgın Akorist", FunFeature = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
            new Musician { Id = 4, Name = "Fatma Nota", Profession = "Sürpriz Nota Üreticisi", FunFeature = "Nota üretirken sürekli sürprizler hazırlar" },
            new Musician { Id = 5, Name = "Hasan Ritim", Profession = "Ritim Canavarı", FunFeature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
            new Musician { Id = 6, Name = "Elif Armoni", Profession = "Armoni Ustası", FunFeature= "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
            new Musician { Id = 7, Name = "Ali Perde", Profession = "Perde Uygulayıcı", FunFeature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
            new Musician { Id = 8, Name = "Ayşe Rezonans", Profession = "Rezonans Uzmanı", FunFeature = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
            new Musician { Id = 9, Name = "Murat Ton", Profession = "Tonlama Meraklısı", FunFeature = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç" },
            new Musician { Id = 10,Name = "Selin Akor", Profession = "Akor Sihirbazı", FunFeature= "Akorları değiştirdiğinde bazen sihirli bir hava yaratır" },
        };
        // GET : api/Musicians
        [HttpGet]
        public ActionResult<IEnumerable<Musician>> Get() // Tüm müzisyenleri getirir
        {
            return Ok(musicians); // Müzisyenlerin listesini 200 Ok ile döndürür
        }

        // GET: api/Musicians/5 
        [HttpGet("{id:int}")] // Belirli bir Id ile müzisyeni almak için 
        public ActionResult<Musician> Get(int id) // Id'ye göre bir müzisyeni döndürür
        {
            var musician = musicians.FirstOrDefault(x => x.Id == id); // Id'ye göre müzisyeni bulur
            if (musician == null) // Eğer müzisyeni bulamazsa
            {
                return NotFound(); // 404 not found döndürür
            }
            return Ok(musician); // Bulunan müzisyenleri 200 Ok ile döndürür
        }
        // POST: api/Musicians
        [HttpPost]
        public ActionResult<Musician> Post([FromBody] Musician musician) // yeni bir müzisyen ekler
        {
            musician.Id = musicians.Max(x => x.Id) + 1; // Yeni ID oluştur
            musicians.Add(musician); // yeni müzisyeni listeye ekler
            return CreatedAtAction(nameof(Get), new { id = musician.Id }, musician); // 201 Created ile döndür

        }
        // PUT: api/Musicians/5
        [HttpPut("{id}")]
        // Belirli bir ID ile müzisyenleri güncellemek için HTTP PUT isteği
        public IActionResult Put(int id, [FromBody] Musician updatedMusician) // Güncellenmiş müzisyeni alır
        {
            var musician = musicians.FirstOrDefault(x => x.Id == id); // Id'ye göre müzisyeni bulur
            if (musician == null) // Eğer müzisyeni bulamazsa 
            {
                return NotFound(); // 404 not found döndürür

            }
            // müzisyenin bilgilerini günceller
            musician.Name = updatedMusician.Name;
            musician.Profession = updatedMusician.Profession;
            musician.FunFeature = updatedMusician.FunFeature;
            return NoContent(); // 204 no content döndürür
        }
        // DELETE : api/Musicians/5
        [HttpDelete("{id}")] // Belirli bir Id ile müzisyenleri silmek için HTTP Delete isteği
        public IActionResult Delete(int id) // silinecek müzisyenin Id'sini alır.
        {
            var musicial = musicians.FirstOrDefault(x=>x.Id == id); // Id'ye göre müzisyeni bulur
            if (musicial == null) // Eğer müzisyeni bulamazsa
            {
                return NotFound(); // 404 not found döndürür
            }
            musicians.Remove(musicial); // Müzisyeni listeden siler
            return NoContent(); // 204 no content döndürür
        }

        // HTTP GET isteği için bir endpoint tanımlar. "search" yoluna gelen istekleri karşılar.
        [HttpGet("search")]
        public IActionResult Search([FromQuery] string query)
        {
            // Kullanıcıdan alınan 'query' parametresinin boş veya sadece boşluk karakterlerinden oluşup oluşmadığını kontrol eder.
            // Eğer 'query' boşsa, istemciye 400 Bad Request yanıtı döner.
            if (string.IsNullOrWhiteSpace(query))
            {
                return BadRequest(); // Hatalı istek durumunda istemciye uygun bir hata mesajı döner.
            }

            // 'musicians' listesindeki müzisyenleri filtreler. 
            // 'Where' metodu, 'query' parametresinin müzisyenin ismi içinde geçip geçmediğini kontrol eder.
            // 'Contains' metodu, 'query' değerinin müzisyenin isminin içinde olup olmadığını kontrol eder.
            // Sonuç olarak, eşleşen müzisyenlerin listesini alır ve 'ToList()' ile bir listeye dönüştürür.
            var musician = musicians.Where(x => x.Name.Contains(query)).ToList();

            // Filtrelenmiş müzisyen listesini 200 OK yanıtı ile istemciye döner.
            return Ok(musician);

        }
    }
}
