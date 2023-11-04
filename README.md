
# ReDoMusicTeam2
ReDoMusic .NET ile oluşturduğumuz, eklenen enstrümanları sipariş edip yorumlayabileceğimiz bir projedir.
ReDoMusic repomuzda takımız ile hazırladığımız içerisinde kullanıcıları ekleyebilmek, silmek ve kullanıcı listesini görmek amacıyla oluşturduğumuz Customer sınıfları, enstrümanları siparişe eklemek, görmek için Instrument sınıfı oluşturduk ve enstrümanların modelini belirtebileceğimiz brand sınıfını aktardık. Ürünlerin oluşturulacağı, oluşturulan ürünün sipariş edilmesi, yorum eklenebileceği Product ve Order sınıflarını ekledik.

Entities klasörünün altına eklediğimiz Customer'ın içerisine Guid ile aldığımız ad, soyad, email, adres'i ekleyip, CostumerController sınıfı açtık Http Get/Set' i kullanarak yapmak istediğimiz kontrolleri ekledik, views kısmında AddCustomer, Delete, Index'i ekledik ve görünüşünü düzenledik.

Instruman markasını belirtmek için entities’e Brand klasörü oluşturup, guid ıd, üretim tarihi, adını, açıklamasını ve adresini ekledik. BrandControllerın içinde cshtml üzerinde eklemek istediklerimizi yazdık ve views - Brand’in içerisine model ekleme, silme ve Index kısınlarını yaptık.

Ürünleri sipariş edebilmek için OrderController ekleyip, oluşturulan enstrümanlardan sipariş edilebilmesini sağladık. Son olarak da kullanıcıların siparişi yorumlayabileceği ProductControllerı ekledik view kısmında hangi ürüne yorum ekleyebileceği ve beş puan üzerinden değerlendirip, yorum yapabileceğini oluşturduk.

Takım arkadaşlarımdan Şeyma projede customer, product, review controller, views entities ve instrument view kısımlarını oluşturdu. Sude, brand, order, product, review kısınlarına odaklandı. Tuğba, projenin oluşturması, customer controller, views, entities kısımlarını tamamladı (diğer takım arkadaşımız takım çalışmasına katılmadı).

Genel olarak birbirimizin yaptığı yenilikleri kontrollü bir şekilde ilerlettik ve sürekli iletişim halinde olduk. Karşılaştığımız sorunları birlikte çözmeye çalıştık, hata yerini belirlemek için videoları inceledik. Eğer çözüm bulamazsak, Hakan hocamıza danıştık.
