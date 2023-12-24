# Projektets Namn

Beskrivning av projektet här.

---

## Innehållsförteckning

- [Beskrivning](#beskrivning)
- [Struktur](#struktur)
- [Modeller](#modeller)
- [Vyer](#vyer)
- [Kontroller](#kontroller)
- [Övrigt](#övrigt)
- [SQL Server Setup](#sql-server-setup)
- [Projektskapat och Verktygsinstallation](#projektskapat-och-verktygsinstallation)
- [Kör och Bygg Projekt](#kör-och-bygg-projekt)
- [Extensions för VS Code](#extensions-för-vs-code)

---

## Beskrivning

En kort beskrivning av projektet och dess syfte.

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

## SQL Server Setup
För att använda SQL Server som databas behöver följande paket och kommandon installeras:
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design 
dotnet add package Microsoft.EntityFrameworkCore.Tools

---

## För att skapa och applicera migreringar mot SQL Server används följande kommandon
dotnet ef migrations add initial
dotnet ef database update

---

## För att ta bort migreringar används kommandot
dotnet ef migrations remove

---

## Projektskapat och Verktygsinstallation För att skapa ett projekt och installera verktygen, använd följande kommandon
dotnet new webapi -minimal --name StudentPlatform.API
dotnet tool install --global dotnet-ef

---

## Kör och Bygg Projekt För att köra projektet
dotnet run
dotnet build

---

## Extensions för VS Code För att underlätta utvecklingen i Visual Studio Code rekommenderas att installera följande extensions:
NuGet Package Manager
C#
SQL Server
Live Share

---

Denna README.md inkluderar all information om projektets struktur, modeller, vyer, kontroller, övriga komponenter och instruktioner för att sätta upp SQL Server, migreringar, projekt skapande och körning, samt rekommenderade VS Code-extensions för en bättre utvecklingsmiljö. Du kan fylla i informationen med dina egna detaljer och specifikationer.




