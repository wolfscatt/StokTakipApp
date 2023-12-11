# Stok Takip App
### Entities Klasörü 
---
* Veritabanında bulunan tabloları eşitlemek istediğimiz classların bulunduğu temel klasördür.
* Abstract ve Concrete olarak 2 klasör altında tutulmaktadır.
  * **Abstract** : Soyut sınıfların, interfacelerin bulunduğu klasördür.
  * **Concrete** : Somut sınıfların bulunduğu klasördür.
    
#

### DataAccess Klasörü 
---
* İçerisinde Data Access Layer dediğimiz katmanı bulunduran ve veritabanı ile iletişimi sağlayan kodların yazdığı **DAL** isimli klasör bulunmaktadır.
* Buradada tekrar kodlarımızı **Abstract** ve **Concrete** olmak üzere 2 klasörde tuttuk.
  * **Abstract**, içerisinde bir tane genel **CRUD** işlemlerinin bulunduğu bir interface var ve bir tanede tabloya özel **CRUD** işlemlerini yazmak istediğimiz bir interface vardır.
  * **Concrete**, içerisinde ise **Abstract** içerisinde yazdığımız **CRUD** işlemlerini implemente ettiğimiz **BaseRepository** classımız var. Veritabanı ile bağlantı sağlayıp **Entity** klasörlerinde bulunan sınıflarımız ile tablolarımızı eşleştirdiğimiz **Context** nesnemiz vardır.

#

### Business Klasörü 
---
* Genel iş kodlarımızın bulunduğu klasördür. Yani **DAL** Katmanında çektiğimiz verileri kullandığımız katmandır.
* Bir tane servis interface'imiz ve bu interface'i uygulayan (implemente eden) bir somut classımız vardır.
