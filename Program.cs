using System.ComponentModel;
using App;

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
items.Add(new Item("Bord", "White", MyUser2));



User? active_user = null; // jag har skapat en variabel active_user som håller koll på vem som är inloggad.
                        //null betyder att ingen användare är inloggad ännu.

bool running = true; //Så länge running är true kommer while-loopen att fortsätta köra programmet.
while (running)
{
    if (active_user == null) //användaren är inte aktiv, då visas menun med 6 val
    {
        Console.WriteLine("1.Welcome to trading market");
        Console.WriteLine("2.Menu");
        Console.WriteLine("3.sök");
        Console.WriteLine("4.skapa konto");
        Console.WriteLine("5.logga in");
        Console.WriteLine("6.Enter 'q' to exit");

        string input = Console.ReadLine();

        switch (input) //jag vill att användaren ska hopa i menun och hanterar alla case 
        {
            case "4"://skapa ny konto
                Console.Write("Ange username: ");
                string newEmail = Console.ReadLine();

                Console.Write("Ange password: ");
                string newPassword = Console.ReadLine();

                users.Add(new User(newEmail, newPassword));//Sedan skapas en ny användare och läggs till i listan (users.Add(...)).
                Console.WriteLine("Konto skapat!");
                break;


            case "5": //loga in
                Console.Write("Please enter your email: ");
                string userName = Console.ReadLine();

                Console.Write("Please enter your password: ");
                string userPassword = Console.ReadLine();

                

                foreach (User user in users) //vi kollar om användaren redan finns
                {
                    if (user.UserName == userName && user.Password == userPassword)
                    {
                        active_user = user;
                        Console.WriteLine("Successfull Login!"); //if användnamn och pass matchar med de som vi har i User class då han har access annash visav menun igen, med 6 val
                    }
                }
                break;

            case "6":
                running = false;  // avslutas.

                break;

                default://om ingen stämer
                Console.WriteLine("Fel, försök igen");
                break;
        }

    }

    if (active_user != null) //if användare är inte null:är inloggat, visas en ny meny för inloggade användare.
    {
        Console.WriteLine("Welcome to trading market");
        Console.WriteLine("menu");
        Console.WriteLine("sök");
        Console.WriteLine("1. Add item to market");
        Console.WriteLine("2. List all items on market");
    }

    

    // else if (active_user == user) //?????????
    // {
    //     Console.WriteLine("Ange username: ");//we will declare a string variable named inputanvändname
    //     string inputanvändname = Console.ReadLine() ?? ""; //user ska skriva lösenord

    //     Console.WriteLine("Ange password: ");// we will desplay detta
    //     string inputlösenord = Console.ReadLine() ?? ""; //user ska skriva lösenord
    // }
    // foreach (User user in users)
    // {
    //     if (user.TryLogin(UserName, Password))
    //     {
    //         active_user = user;
    //         break;
    //     }
    // }
}
//?? hur ska jag hoppa in att log in eller skapa contot? med swich, case 1,case 2...bla bla


//Vi ska kolla in om användaren finns:-
//Vi ska be användaren välja vem som ska trade och vad.   




Console.WriteLine("Thank you come again..");
        //menu
    // Console.WriteLine("Kategorier");
    // Console.WriteLine("annonser");
    // Console.WriteLine("meddelande");
    // Console.WriteLine("Bevakningar");
    // string h = Console.ReadLine();
    // Console.WriteLine("Detta skrev vi in: " + h);
    






