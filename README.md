# Trade 
Trade projekt
Readme text


Detta program är ett enkelt trading-system där användare kan registrera sig, logga in, lägga upp items på marknaden, se andras items och flytta items mellan användare. Programmet använder objektorientering med tre huvudklasser: "User", "Item" och "Trade".

Projektstruktur

Program.cs — Huvudapplikationens logik och menysystem

Klasser/
User.cs — Användarmodell och autentisering
Item.cs — Objektmodell
Trade.cs — Handelsmodell och status


Krav:

Steg 1: Klona projektet

Öppna din terminal eller kommandoprompt och kör följande kommando för att klona ditt repository till din lokala maskin:

git clone https://github.com/Zhaneta-Lecini/Trade.git

Navigera sedan till projektmappen:
cd Trade 

Steg 2: Bygg och kör projektet

För att bygga och köra projektet behöver du ha .NET SDK 9 eller senare installerat.

-Återställ eventuella beroenden:
dotnet restore

-Bygg projektet:
dotnet build

-Kör applikationen:
dotnet run

teg 3: Testa funktionaliteten

När applikationen körs bör du se huvudmenyn i terminalen. Här kan du:
-Skapa nya användare
-Logga in
-Lägga till och lista items på marknaden
-Sök efter items
-Logga ut

Följ skärmmenyn för att skapa konto, logga in, lägga till objekt logg ut, lägg till nya items eller avsluta
För att navigera använd menysiffrorna..



------Trading Market-----------

Ett konsolprogram i C# där användare kan:

--Skapa konto och logga in 
-- Lägga upp sina saker (items)  
--Se vad andra säljer
--Skicka trade request
--Acceptera eller neka trades
--Data sparas automatiskt i JSON-filer (users.json, items.json)

Jag använde klasser (User, Item, Trade, TradeRequest) och listor för att hantera logiken.


I min kod fungerar redan:

1-skapa konto = (case 4 i main Program.cs);
2-logga in = (case 5 i main);
3-logga ut = (case 6 i main);
4-Visa alla items/ marknanden = (market.ShowMarket());
5-Sök item = (case 3 när ej inloggat och case 2 när inloggat);
6-lägga till item = ( case 3 när inloggat); 
7-köpa item = (market.BuyItem(active_user));
8-Andra ägare mellan användare(transfer) = (Trade.TransferItem finns ,  men inte andropat i menyn);

Men jag saknar:

9-Trade requests (begäran om att byta/köpa)
10-Automatisk spara/ladda (autosave + autoload)

Trade requests:
Just nu köper användaren direkt ett item. För att lägga till requests kan vi skapa en lista med TradeRequest. När någon vill köpa ett item, skapas ett request istället. Ägaren kan sedan acceptera eller neka.

Persistent storage:
Vi kan använda JSON för att spara items och users till filer. När programmet startar, läses filerna och allt är kvar precis som innan programmet stängdes.

Flytta item via mail:
Den logiken finns redan i TransferItem, men jag behöver lägga till ett menyval i program.cs så användare kan använda den.


FileHandler.cs — Hanterar all JSON-persistens (datainläsning och sparning). 
trading_system.csproj — Projektfil. 