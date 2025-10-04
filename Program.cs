using System.ComponentModel;
using App;
using Microsoft.VisualBasic;

//user lista,(har vält en lista för att det är inte med en fixed size, som t.ex array)//för att läga till i listan.
//Skapar en lista av användare (users). Här sparar jag alla User-objekt som finns i systemet.
List<User> users = new List<User>();
User MyUser = new User("Anna@hotmail.com", "J456n"); //Här skapar jag två användare (MyUser och MyUser2) med e-post och lösenord. 
User MyUser2 = new User("Inna@hotmail.com", "123456");
users.Add(MyUser); //Sedan lägger jag till dem i listan users.
users.Add(MyUser2);
        

//   Skapar en lista med items (name, description, owner)
List <Item> items = new List<Item>();
items.Add(new Item("Stol", "Black", MyUser)); //items.Add(new Item("name/skor", "black/descrip", owner));
items.Add(new Item("Bord", "White", MyUser2));//Varje item har en Owner, som är ett User-objekt.

Trade market = new Trade(items); //här skapade jag Trade-objekt som ska hantera kÖp/sälj

User? active_user = null; 
bool running = true;

while (running) //Så länge running är true kommer while-loopen att fortsätta köra programmet.
{
    if (active_user == null)//användaren är inte aktiv, då visas menun med 6 val
    {
        Console.WriteLine("1. WELCOME TO TRADING MARKET");
        Console.WriteLine("2. Visa alla items");
        Console.WriteLine("3. Sök");
        Console.WriteLine("4. Skapa konto ");
        Console.WriteLine("5. Logga in");
        Console.WriteLine("6. Avsluta (q)");

        string input = Console.ReadLine() ?? "";

        switch (input) //jag vill att användaren ska hopa i menun och hanterar alla case 
        {
            case "1": //Treadings market öpnas  om användaren skriver in "1" i menyn=kör följande kod.
            case "2": //Treadings market öpnas  om användaren skriver in "2" i menyn=kör följande kod.
                market.ShowMarket();
                break;

            case "3"://sök, //Treadings market öpnas//om användaren skriver in "3" i menyn=kör följande kod.
                Console.Write("Sök item: ");//vi scriver ut en prompt som säger så;// users kan scriva in texten;ReadLine,eftersom texten ska stanna kvar på samma rad som input
                string search = Console.ReadLine() ?? ""; //Om user trycker Enter utan att skriva något då sätt search till en tom sträng "" istället.
                foreach (var item in items) //den här loopen går genom alla items i itemslistan
                {
                    if (item.Name.Contains(search, StringComparison.OrdinalIgnoreCase)) // här jag kollar items name"stol"/StringComparison.OrdinalIgnoreCase, gör att sökningen ignorerar stora och små bokstäver.
                    {
                        Console.WriteLine(item);//Om if är sant, alltså om itemets namn innehåller söksträngen, skrivs itemet ut.

                    }
                }
                break;// annash avsluta detta case och gå tillbaka till menu


            case "4"://skapa ny konto//om användaren skriver in "4" i menyn=kör följande kod.
                Console.Write("Ange username: ");
                string newEmail = Console.ReadLine() ?? "";

                Console.Write("Ange password: ");
                string newPassword = Console.ReadLine() ?? "";

                users.Add(new User(newEmail, newPassword));//Sedan skapas en ny användare och läggs till i listan (users.Add(...)).
                Console.WriteLine("Konto skapat!");
                break;


            case "5": //logga in //om användaren skriver in "5" i menyn=kör följande kod.
                Console.Write("Please enter your email: ");
                string userName = Console.ReadLine() ?? "";

                Console.Write("Please enter your password: ");
                string userPassword = Console.ReadLine() ?? "";


                foreach (User user in users) //vi kollar om användaren redan finns
                {
                    if (user.UserName == userName && user.Password == userPassword)
                    {
                        active_user = user;
                        Console.WriteLine("Successfull Login!"); //if användnamn och pass matchar med de som vi har i User class då han har access 

                        break;
                    }
                }

                if (active_user == null) //if detta matchar inte:
                    Console.WriteLine("Fel email eller pasword. ");//if användnamn och pass matchar med de som vi har i User class då han har access annash visav menun igen, med 6 val

                break;

            case "6": //om användaren skriver in "6" i menyn=kör följande kod.
                running = false;  // avslutas.

                break;

            default://om ingen stämer
                Console.WriteLine("Fel, försök igen");
                break;
        }
    }
    else  //MENU för de Inlåggad användare :)
    {
        Console.WriteLine("1. Visa trading market");
        Console.WriteLine("2. Sök");
        Console.WriteLine("3. Lägg upp nytt item ");
        Console.WriteLine("4. Lista alla items");
        Console.WriteLine("5. Köp");
        Console.WriteLine("6. Logga ut");

        string? input = Console.ReadLine() ?? "";
        switch (input)
        {
            case "1": //Treadings market öpnas, om användaren skriver in "1" i menyn = kör följande kod.
            case "4":

                market.ShowMarket();
                break;

            case "2": //Sök
                Console.Write("Sök item efter namn");
                string search = Console.ReadLine() ?? "";
                foreach (var item in items)
                {
                    if (item.Name.Contains(search, StringComparison.OrdinalIgnoreCase)) // här jag kollar items name"stol"/StringComparison.OrdinalIgnoreCase, gör att sökningen ignorerar stora och små bokstäver.
                    {
                        Console.WriteLine(item);
                    }
                }
                break;

            case "3": //LÄGG UPP NYTT ITEM //När en användare är inloggad kan skapa nya items som kopplas till sitt konto
                Console.WriteLine("Ange item namn");//user ska se texten och skriva in namnet på en ny item;
                string name = Console.ReadLine() ?? ""; //här tar vi in den som user har skrivit;

                Console.WriteLine("Ange item description");//user ska ge description på en ny item;
                string description = Console.ReadLine() ?? "";// spara den items beskrivningen på variabeln;

                if (active_user != null)
                {
                    items.Add(new Item(name, description, active_user)); // Add ny item fron den inloggad user
                    Console.WriteLine("Tillagt!");
                }
                break;

            case "5": //KÖP ITEM //om användaren skriver in "5" i menyn = kör följande kod.
                if (active_user != null)
                {
                    market.BuyItem(active_user);//BuyItem = är en metod i Trade som hanterar logiken för att köpa ett item från marknaden.
                    //den inloggade användaren försöker köpa ett item.
                }
                else
                {
                    Console.WriteLine("Du måste vara inloggad!");
                }

                break; //Avslutar detta case och hoppar ut ur switch-satsen.

            case "6": //om användaren skriver in "6" i menyn = kör följande kod.
                active_user = null;
                Console.WriteLine("Du är nu loggat ut");
                break;

            default://om ingen stämer
                Console.WriteLine("Fel, försök igen");
                break;
        }

    }
}
Console.WriteLine("Program avslutas");
Console.WriteLine("Thank you come again..");


//Vi ska kolla in om användaren finns:-
//Vi ska be användaren välja vem som ska trade och vad.  
 
    //menu
    // Console.WriteLine("Kategorier");
    // Console.WriteLine("annonser");
    // Console.WriteLine("meddelande");
    // Console.WriteLine("Bevakningar");
    // string h = Console.ReadLine();
    // Console.WriteLine("Detta skrev vi in: " + h);
    






