using App;

// Användare
// Resurser, Dolda baserade på roll
// Logga in
// Logga ut
// Skapa en användare om man är en Admin
// Se listan
// 
// a user-browse, accept, deny request.

/*The following features need to be implemented:

A user needs to be able to register an account
A user needs to be able to log out.
A user needs to be able to log in.
A user needs to be able to upload information about the item they wish to trade.
A user needs to be able to browse a list of other users items.
A user needs to be able to request a trade for other users items.
A user needs to be able to browse trade requests.
A user needs to be able to accept a trade request.
A user needs to be able to deny a trade request.
A user needs to be able to browse completed requests.
*/
List <User> users = new List<User>();
List <Item> items = new List<Item>();

//för att läga till i listan.//Skapar ny (objekt) User som heter "MyUser" och har string värden "Anna"..

User MyUser = new User("Anna", "J456n");//"Skapa ny användare"
User MyUser2 = new User("Inna", "123456");
Item MyItem = new Item("skor", "blu");
Item MyItem2 = new Item2("mobil", "iphone");

//Skapar ny (objekt) User som heter "MyUser" och har string värden "Anna"..

items.Add(new Item(MyItem.Name, MyItem.Description)); //items.Add(new Item("name/skor", "black/descrip"));
items.Add(new Item(MyItem2.Name, MyItem2.Description));
users.Add(new User(MyUser.UserName, MyUser.Password));
user.Add(new User(MyUser2.Username, MyUser2.Pasword));

Console.WriteLine("Ange användarnamn: ");//we will declare a string variable named användnameA
string användname = Console.ReadLine();

Console.WriteLine("Ange lösenord: ");// we will desplay text+användnameA
string lösenord = Console.ReadLine();



/*
Visa "Skapa ny användare"
 
Fråga: "Ange användarnamn:"
Läs in och spara användarnamn
 
Fråga: "Ange lösenord:"
Läs in och spara lösenord
 
Skapa ny användare med användarnamn + lösenord
Lägg till användaren i users-listan
 
Visa "Användare skapad!"
*/


//menu
Console.WriteLine("Kategorier");
Console.WriteLine("annonser");
Console.WriteLine("meddelande");
Console.WriteLine("Bevakningar");
string h = Console.ReadLine();
Console.WriteLine("Detta skrev vi in: " + h);





