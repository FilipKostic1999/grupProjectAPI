# GroupProjectAPI

---

## Innehållsförteckning

- [Beskrivning](#beskrivning)
- [Struktur](#struktur)
- [Modeller](#modeller)
- [Vyer](#vyer)
- [Kontroller](#kontroller)
- [Övrigt](#övrigt)

---

## Beskrivning

Det här projektet är en ASP.NET Core-applikation strukturerad enligt MVC-arkitekturen (Model-View-Controller). 
Det inkluderar modeller för bilar, kunder och företag med tillhörande vyer och kontroller för att hantera dessa dataobjekt. 
Projektet använder Entity Framework Core för databasåtkomst och innehåller även SQL Server-instruktioner för migreringar och projektinstallation. 

---

## Struktur

Det här projektet är strukturerat enligt MVC (Model-View-Controller) i ASP.NET Core. Det innebär att koden är uppdelad i olika delar för att separera logik och presentation.

---

## Modeller

### Car.cs
- Representerar ett bilobjekt med attribut som ID, Make, Model, Type, Created, CreatedBy, Modified, ModifiedBy.
- Använder attribut som `Required` och `Key` för validering och primärnyckel.

### Customer.cs
- Representerar ett kundobjekt med attribut som ID, FirstName, LastName, Email, Cell, Created, CreatedBy, Modified, ModifiedBy.
- Använder attribut som `Required` och `Key` för validering och primärnyckel.

### Company.cs
- Representerar ett företagsobjekt med attribut som ID, Name, Activity, Email, Address.
- Innehåller attribut som `Required` och `Key` för validering och primärnyckel.

### Creat.cs
- Innehåller gemensamma attribut för skapande och ändring av entiteter, som Created, CreatedBy, Modified, ModifiedBy.

### Error.cs
- Innehåller en struktur för att representera felmeddelanden med fält som status och message.

---

## Vyer

### Car/Create.cshtml
- En vy för att skapa en ny bil med formulärfält som är bundna till `Car`-modellen.
- Använder ASP.NET Core tag-helpers och Razor-syntax för att skapa formuläret.

### Customer/Index.cshtml
- En vy som visar en lista över kunder.
- Kan innehålla ett HTML-table för att visa kundinformation.

### Company/Details.cshtml
- En vy som visar detaljer om ett specifikt företag.
- Använder HTML och Razor-syntax för att visa företagsinformation.

---

## Kontroller

### CarsController.cs
- Innehåller HTTP-metoder för att hantera bilobjekt: skapa, visa, redigera, radera.

### CustomersController.cs
- Innehåller metoder för att hantera kundobjekt: lista, visa detaljer, skapa, redigera, radera.

### CompaniesController.cs
- Har metoder för att hantera företagsobjekt: lista, visa detaljer, skapa, redigera, radera.

---

## Övrigt

### CCCContext.cs
- En DbContext-klass för att skapa och hantera databasrelationer för modellerna.
   
---

## Projektskapat och Verktygsinstallation För att skapa ett projekt och installera verktygen, använd följande kommandon
- dotnet new webapi -minimal --name
- dotnet tool install --global dotnet-ef

---

## Kör och Bygg Projekt För att köra projektet
- dotnet run
- dotnet build

---

## Extensions för VS Code För att underlätta utvecklingen i Visual Studio Code rekommenderas att installera följande extensions:
- NuGet Package Manager
- C#
- SQL Server
- Live Share




