Modeller (Models):
Car.cs
Representerar ett bilobjekt med egenskaper som ID, Make, Model, Type, Created, CreatedBy, Modified, ModifiedBy.
Innehåller attribut som Required och Key för validering och primärnyckel.
Customer.cs
Representerar ett kundobjekt med egenskaper som ID, FirstName, LastName, Email, Cell, Created, CreatedBy, Modified, ModifiedBy.
Använder attribut som Required och Key för validering och primärnyckel.
Company.cs
Representerar ett företagsobjekt med egenskaper som ID, Name, Activity, Email, Address.
Innehåller attribut som Required och Key för validering och primärnyckel.
Creat.cs
Innehåller gemensamma attribut för skapande och ändring av entiteter, som Created, CreatedBy, Modified, ModifiedBy.
Error.cs
Innehåller en struktur för att representera felmeddelanden med fält som status och message.
Vy (Views):
Car/Create.cshtml
En vy för att skapa en ny bil med formulärfält som är bundna till Car-modellen.
Använder ASP.NET Core tag-helpers och Razor-syntax för att skapa formuläret.
Customer/Index.cshtml
En vy som visar en lista över kunder.
Kan innehålla ett HTML-table för att visa kundinformation.
Company/Details.cshtml
En vy som visar detaljer om ett specifikt företag.
Använder HTML och Razor-syntax för att visa företagsinformation.
Kontroller (Controllers):
CarsController.cs
Innehåller HTTP-metoder för att hantera bilobjekt: skapa, visa, redigera, radera.
CustomersController.cs
Innehåller metoder för att hantera kundobjekt: lista, visa detaljer, skapa, redigera, radera.
CompaniesController.cs
Har metoder för att hantera företagsobjekt: lista, visa detaljer, skapa, redigera, radera.
Övrigt:
CCCContext.cs
En DbContext-klass för att skapa och hantera databasrelationer för modellerna.
Detta representerar en typisk struktur för ett MVC-projekt i ASP.NET Core, där modellerna representerar data, vyerna visar data till användaren och kontrollerna hanterar affärslogik och styr flödet av applikationen.
