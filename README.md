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
1-skapa konto = (case 4 i main Program.cs);
2-logga in = (case 5 i main);
3-logga ut = (case 6 i main);
4-Visa alla items/ marknanden = (market.ShowMarket());
5-Sök item = (case 3 när ej inloggat och case 2 när inloggat);
6-lägga till item = ( case 3 när inloggat); 
7-köpa item = (market.BuyItem(active_user));
8-Andra ägare mellan användare(transfer) = (Trade.TransferItem finns ,  men inte andropat i menyn);

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