# [2024 - kodlama.io - Bootcamp](https://www.kodlama.io/p/yazilim-gelistirici-yetistirme-kampi-2024-1)  
![alt text](https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://cdn.filestackcontent.com/We86Zc3xQy6FUqhyBJJc)

Bootcamp süresi boyunca verilen ödevler Task1, Task2... şeklinde klasörlenerek bu repo içerisinde paylaşılacaktır. 
## [**Task1**](https://www.kodlama.io/courses/2440064/lectures/51846446)
### [*Task1.1 - 5 Saatlik C# Programlama Kampı*](https://www.youtube.com/watch?v=2EkMrrX9sYY&list=PLqG356ExoxZWfcrBP53Njxir4a-OgqRki&index=6)
Temel C# bilgileri verilmiştir (Değişkenler, şart blokları, döngüler, fonksiyonlar; class, interface kavramları).
Katmanlı mimari ile abstraction, dependency injection gibi kavramların tanımları ve örnekleri bulunur.
Bir dış SOAP servisin sisteme adapte edilmesi örneği yer alır.
- Projeler:
    - **Workaround:** Kavramların ve temellerin anlatıldığı ve örneklendiği test alanı.
    - **Entities:** Person entity'sinin bulunduğu katman.
    - **Business:** İş kurallarının bulunduğu katman.
    - **Adapters:** Mernis sisteminin adapter pattern'ı kullanılarak entegre edildiği katman.

## [**Task2**](https://www.kodlama.io/courses/2440064/lectures/52015232)
### [*Task2.1 - C# Dersleri*](https://www.youtube.com/watch?v=mPvUodG55yc&list=PLqG356ExoxZU5keiJwuHDpXqULLffwRYD&index=3)
C#'ın temel konuları console uygulamaları ve ek olarak genel özet için mini bir windows form recap uygulaması üzerinden anlatılmıştır. Her bir konu adıyla isimlendirilmiş bir proje altında işlenmiştir.
- Projeler
    - **TypesAndVariables:** Tamamı değer tiplerden oluşan (string hariç -her ne kadar referans tipli olsa da özel durumundan dolayı değer tip gibi davranır-) sayısal, metinsel veri tipleri ve enum veri tipi örneklerle açıklanmıştır. Sayısal tiplerin değer aralıkları da yer alır.
    - **Conditionals:** Şart blokları (if, else if, ternary operator, switch case yapıları) anlatılmıştır.
    - **Methods:** Parametreli, parametresiz, değer döndüren, değer döndürmeyen methodlar açıklanmıştır. Overloading kavramı, ref, out keywordleri, params keywordü kullanımları ve default parametreli methodlar anlatılmıştır.
    - **Arrays:** Diziler, çok boyutlu diziler, dizilere başlangıçta ve sonradan eleman ataması yapma ve döngüler ile ilişkilerinden bahsedilmiştir.
    - **Loops:** For, foreach, while, do while döngü yapıları açıklanmıştır.
    - **Strings:** Stringlerin bir char array'i olduğu örneklerle açıklanmıştır. Sıkça kullanılan stringler için arama ve manipülasyon methodları anlatılmıştır (Clone, EndsWith, StartsWith, IndexOf, LastIndexOf, Insert, Substring, ToLower, ToUpper, Replace, Remove, String.Format).
    - **Classes:** Class yapılarının bir veri tutucu ve method tutucu olduğu, gruplayıcı olarak kullanılabildiği açıklanmıştır. En temelden syntax yapısı ile OOP'nin olmazsa olmazı class konusuna bir giriş yapılmıştır. Property ve field kavramları, propertylerin açık kullanımı ve neden var olduğu (encapsulation kavramı) örnek üstünden anlatılmıştır.
    - **RecapDemo1:** WindowsForm projesi üstünden 8x8'lik bir dama tahtası simüle edilmiştir. Class, çoklu array, loop, conditional blok konularını barındıran bir örnek uygulama yapılmıştır.
    - **Interfaces:** Interfacelerin genel syntax yapısı ve bir referans tip ve class tutucu olarak genel kullanım durumları örnekler üzerinden anlatılmıştır.
    - **InterfacesDemo:** Konunun önemi açısından interfaceler için küçük bir demo yapılmıştır. Bir senaryo üzerinden yanlış kullanım ve ardından doğru kullanım uygulanarak (interface parçalanarak) SOLID prensiplerinin I'si interface segregation prensibi açıklanmıştır.
    - **Inheritance:** Class'ların başka class'lardan miras alması ve interfacele syntax bakımından benzerlikleri, aralarındaki farklar, inheritance kısıtları, kuralları örnekler üzerinden açıklanmıştır.
### [*Task2.2 - C# İyi Programcı Serisi*](https://www.youtube.com/watch?v=ruGBQ8BS_Co&list=PLqG356ExoxZXauNTWImDGmhSXEB7TBah-)
OOP için temel konular anlatılmıştır. Genel konu başlıkları şöyledir: Referans tipler, constructor yapısı, interface ve gerçek hayat uygulamaları, generic yapılar, thread multithreading ve asenkron programlama mantığı, Language Integrated Query(LINQ) yapısı ve kullanımı.
- Projeler
    - **ReferenceTypes:** Referans tiplerin gerçek hayat senaryolarında kullanılabilmesi için gerekli olan mantıksal tanımı örnekler üzerinden anlatılmıştır.
    - **Constructors:** Default constructor ve custom constructor kavramları ve tanımları örneklerle açıklanmıştır.
    - **Interfaces:** Interfacelerin syntax yapısının yanında neden kullanıma ihtiyaç duyulduğunun mantığı üzerine örnek senaryolar oluşturulmuş ve uygulanmıştır.
    - **Generics:** Generic class'ların nasıl oluşturulduğu List yapısının benzeri bir MyList classı üzerinden anlatılmış, arrayler kullanılarak dinamik bir veri yapısının bir bölümü oluşturularak örneklenmiştir. 
    - **ThreadingDemo1:** Thread, multithread kavramları ve çalışma mantığı bir WindowsForms uygulaması üzerinden anlatılmıştır. Asenkron programlamanın tek bir thread üstünden olabileceği gibi birden fazla thread(multithread) üzerinden de gerçekleştirilebileceği açıklanmıştır.
    - **LinqProject:** Veri tabanından liste formatında gelecek veriler simüle edilmiştir. Gelen bu verilerin nasıl filtreleneceği önce algoritmik olarak ardından linq kullanılarak örneklenmiş, bu esnada linqin delegateler üzerinden nasıl kullanılacağı açıklanmıştır.
### [*Task2.3 - Course, Category, Instructor Tabloları ve CRUD İşlemleri*](https://www.kodlama.io/courses/2440064/lectures/52015386)
![WebApi](https://github.com/cahitarslan/2024-kodlamaio-bootcamp/assets/96558672/d37988ef-5939-4f71-ba5c-47218e80b01e)

- Bu task n katmanlı mimari modeli kullanılarak yapıldı. Katmanlar Entity, DataAccess, Business class library projeleri ve Presentation katmanı olarak da WebApi projesidir.

- Code first yaklaşımı ile entityframework core kullanılarak tablolar, karşılık gelen kolonlar Entity katmanında ve tablolar arası ilişkiler DataAccess katmanında belirlendi. DbContext'ten inherit edilen KodlamaioContext configürasyonları ve mapping işlemleri yapıldı. Migration oluşturuldu ve veri tabanı ayağa kaldırıldı. Tablolar arasında one to many ilişkisi bulunmaktadır. İlişkiler ve kolonlar aşağıdaki görselde mevcuttur.
![Database Relations](https://github.com/cahitarslan/2024-kodlamaio-bootcamp/assets/96558672/e94b43c2-4750-4b9b-8e25-d0a07f5d1d49)

- DataAccess katmanında  abstract data access layer referansları ve entityframework core kullanıldığından Repository classları yazıldı.
![Entity&DataAcess](https://github.com/cahitarslan/2024-kodlamaio-bootcamp/assets/96558672/999e4c14-3549-417a-82df-451847e7b824)

- Business katmanında abstract servisler ve manager classları yazıldı. Method dönüşleri için result yapısı implemente edildi. Fluent validation implemente edildi. Magic string'ten kaçınmak için result ve fluent validation'dan dönen bilgi ve hata mesajları ayrı classlar içerisine toplandı. Dependency injection'ı tek bir yerden yönetebilmek adına IoC implemente edildi. 
![devenv_AZ4lKK71lS](https://github.com/cahitarslan/2024-kodlamaio-bootcamp/assets/96558672/933b4115-9a74-4062-ae27-d270413d4073)

- Son olarak WebApi katmanına her bir tablo için controller'lar eklendi. Entity'lerimizi dışarı açmamak adına Entity katmanında Dto nesneleri oluşturuldu. Auto Mapper implementasyonu yapıldı.  Otomatik binding map'leme işlemi için gerekli configürasyonlar MapProfile içerisinde oluşturuldu.


![devenv_llB38cFYhR](https://github.com/cahitarslan/2024-kodlamaio-bootcamp/assets/96558672/0b619b61-8d64-4c6d-a1af-6f5cfd76c2f4)

- Sistem şu an sorunsuz bir şekilde çalışıyor. Siz de repoyu clone'layarak test edebilir, kodları incleyebilirsiniz. Anlamadığınız bir hususda çekinmeden Github profilimdeki discord kullanıcı adım üzerinden bana ulaşabilirsiniz.
