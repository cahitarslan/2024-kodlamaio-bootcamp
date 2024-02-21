# [2024 - kodlama.io - Bootcamp](https://www.kodlama.io/p/yazilim-gelistirici-yetistirme-kampi-2024-1)  
Bootcamp süresi boyunca verilen ödevler Task1, Task2... şeklinde klasörlenerek bu repo içerisinde paylaşılacaktır. 
## Task1
#### MaskeTakip
Temel C# bilgileri verilmiştir (Değişkenler, şart blokları, döngüler, fonksiyonlar; class, interface kavramları).
Katmanlı mimari ile abstraction, dependency injection gibi kavramların tanımları ve örnekleri bulunur.
Bir dış SOAP servisin sisteme adapte edilmesi örneği yer alır.
- Projeler:
    - **Workaround:** Kavramların ve temellerin anlatıldığı ve örneklendiği test alanı.
    - **Entities:** Person entity'sinin bulunduğu katman.
    - **Business:** İş kurallarının bulunduğu katman.
    - **Adapters:** Mernis sisteminin adapter pattern'ı kullanılarak entegre edildiği katman.

## Task2
### Task2.1 - C# Dersleri
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
