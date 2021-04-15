Razor Pages.

Skapande utav Razor Pages
Om vi skapar Razor Pages så skapar vi en .cshtml fil och cshtml.cs fil. 
.cshtml = front-end kod.
cshtml.cs = back-end kod.
Scaffoldar vi med CRUD så får vi färdig-genererad kod som Creat/Edit/Delete/Detials/Index. Innehåller både .cshtml/cshtml.cs filer, med front-end och back-end.

Syntaxen för Razor Pages använder vi C# syntax. Vill vi koda front-end med C# syntax går det också bra, noterbart att vi måste implemnetera ett: @ innan vi börjar koda.


MVC

modeller och data
Skapa rena modellklasser och binder dom enkelt till din egna databas. Definiera deklarativt valideringsregler med C#-attribut som tillämpas på klienten och servern.

controller
enkel route förfrågningar till kontrolleråtgärder, implementerade som vanliga C # -metoder. Data från begäran sökväg, frågesträng och begäran kropp är automatiskt bundna till metodparametrar.

view
Visningar som är specifika för en styrenhet skapas i vyer. Presentation utav CSHTML koden.

ASP.NET

startup.cs = Startup-klassen konfigurerar tjänster och appens begäran i pipelinen.

wwwroot = Som standard behandlas wwwroot-mappen i ASP.NET Core-projektet som en webbrotmapp. Statiska filer kan lagras i valfri mapp under webbrot och nås med en relativ sökväg till roten.

