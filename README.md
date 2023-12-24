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
- En vy för att skapa en ny bil med formulärfält bundna till `Car`-modellen.
- Använder ASP.NET Core tag-helpers och Razor-syntax för formuläret.

### Customer/Index.cshtml
- En vy som visar en lista över kunder.
- Innehåller eventuellt ett HTML-table för kundinformation.

### Company/Details.cshtml
- En vy som visar detaljer om ett specifikt företag.
- Använder HTML och Razor-syntax för att visa företagsinformation.

---

## Kontroller

### CarsController.cs
- Innehåller HTTP-metoder för att hantera bilobjekt: skapa, visa, redigera, radera.

### CustomersController.cs
- Metoder för att hantera kundobjekt: lista, visa detaljer, skapa, redigera, radera.

### CompaniesController.cs
- Metoder för att hantera företagsobjekt: lista, visa detaljer, skapa, redigera, radera.

---

## Övrigt

### CCCContext.cs
- En DbContext-klass för att skapa och hantera databasrelationer för modellerna.

Detta är en strukturerad översikt över projektet, inklusive dess struktur och de olika delarna som ingår.
