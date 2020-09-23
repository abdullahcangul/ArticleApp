# Article App

Makale uygulaması Asp.net core WebAPI kullanılarak geliştirilmiştir. Temel olarak makale, kategory ve yorum alanlarından oluşmaktadır.

## Kurulum

Uygulamayı database olarak Mssql kullanılmaktadır.
- Uygulamayı açınız
- appsettings.json a uygun connection stringi giriniz. Defaut connection string aşagıdaki gibidir
- Package Manager Console gidiniz
- consola <b>"update-database"</b> yazın  ve enter'a basınız
Uygulama kullanıma hazır

 Ayrıca uygulama başlangıçta database oluşturup yine bu database fake data eklemektedir.

Default connection string

```
"ConnectionStrings": {
    "ArticleDatabase": "Server=(localdb)\\mssqllocaldb;Database=ArticleDB;Trusted_Connection=True;"
  }
  
```

## Kullanılan teknolojiler ve yapılar:

- .Net Core Framework
- ASP.NET Web API
- Mssql veritabanı
- Entity Framework ORM 
- Repository Pattern
- N-Tier Mimari
- Swagger
- In-Mermory Cache
- Git/Github

## Daha önce kullanılan teknolojiler

- Proje: Online sınav sistemini barındıran dersane uygulaması(Asp.net Core,Entity framework,Flutter)->geliştirmesi devam ediyor
- Proje: Print Content Management CMS Uygulaması(Asp.Net Mvc,Entity Framework,)
- Proje: Proje Destek Sistemi Uygulaması(Asp.net Mvc,Entity Framework,Angular,Android)
- Proje: Fuzzy logic kullanarak ısıtıcı kontrol uygulaması (Asp.net Mvc)
- Proje: KDS sitemleri kullanarak en iyi yatırım yerini bulun uygulama (Asp.net Mvc)
- Proje: Yemek Sitesi/Blog (Asp.net Mvc,Entity Framework)

## Daha geniş vaktim olsaydı projeye eklenecekler
-Authorization 


## License
[MIT](https://choosealicense.com/licenses/mit/)
