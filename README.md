# DentalCare
Detta projekt är en enkel applikation för att hantera patientbokningar för en tandvårdsklinik.

## Installation
Skapa ett nytt konsolprojekt:
    *Använd Visual Studio för att skapa ett nytt konsolprojekt med namnet "DentalCare".

 Lägg till nödvändiga paket:
    *Installera Entity Framework Core och SQL Server-paketet via NuGet.

Skapa modeller:
    *Skapa en Patient-klass under en Models-mapp.

 Skapa en databaskontext:
    *Skapa en DentalCareContext-klass under en Data-mapp.
    *Konfigurera databaskontexten med rätt anslutningssträng.

Skapa databastabeller med EFC:
    *Använd dotnet ef migrations add InitialCreate för att skapa en ny migration.
    *Använd dotnet ef database update för att applicera migrationen och skapa databastabellerna.

Skapa CRUD-operationer:
Implementera funktioner för att lägga till, uppdatera, ta bort och hämta patientinformation från databasen.

Skapa en användargränssnitt:
    *Skapa en menydriven konsolgränssnitt för att interagera med applikationen.

Testa applikationen:
    *Kör applikationen och testa alla CRUD-operationer för att säkerställa att allt fungerar som förväntat.



