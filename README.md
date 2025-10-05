# Trade 
Trade projekt
Readme text


Detta program är ett enkelt trading-system där användare kan registrera sig, logga in, lägga upp items på marknaden, se andras items och flytta items mellan användare. Programmet använder objektorientering med tre huvudklasser: "User", "Item" och "Trade".


All kod är skriven med samma principer som vi har lärt oss i skolan. Till exempel:  
* Huvudprogrammet använder en listaför users och en lista för items, precis som vi gjorde i skolkodexempel. 

* Jag använder while-loopar och witch-case för menyer.  

* Metoder i klasserna ("User", "Item" och "Trade".) följer samma logik som vi övade på i skolan...



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
-skapa konto 
-logga in
-logga ut
-lägga till item
-köpa item
-visa items

Men jag saknar:
-Trade requests (begäran om att byta/köpa)
-Automatisk spara/ladda (autosave + autoload)











Projektstruktur

Program.cs — Huvudapplikationens logik och menysystem

Klasser/
User.cs — Användarmodell och autentisering
Item.cs — Objektmodell
Trade.cs — Handelsmodell och status

FileHandler.cs — Hanterar all JSON-persistens (datainläsning och sparning). ????????
trading_system.csproj — Projektfil. ????????