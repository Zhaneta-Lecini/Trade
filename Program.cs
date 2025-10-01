using App;

//för att läga till i listan.//Skapar ny (objekt) User som heter "MyUser" och har string värden "Anna"..

List<User> users = new List<User>();
User MyUser = new User("Anna", "J456n");//"Skapa ny användare"
User MyUser2 = new User("Inna", "123456");
users.Add(MyUser);
users.Add(MyUser2);
        

      //   Skapar ny (objekt) User som heter "MyUser" och har string värden "Anna"..items.Add(MyItem);
List <Item> items = new List<Item>();
items.Add(new Item("Stol", "Black", MyUser)); //items.Add(new Item("name/skor", "black/descrip", owner));
items.Add(new Item("Bord", "White", MyUser2));



User? active_user = null;

bool running = true;
while (running)
{
    if (active_user == null) //användaren är inte aktiv
    {
        Console.WriteLine("Welcome to trading market");
        Console.WriteLine("menu");
        Console.WriteLine("sök");
        Console.WriteLine("1.skapa konto");
        Console.WriteLine("2.logga in");
        Console.WriteLine("Enter 'q' to exit");

        string input = Console.ReadLine();

        switch (input)
        {
            case "2":
                Console.Write("Please enter your email: ");
                string userName = Console.ReadLine();
                Console.Write("Please enter your password: ");
                string userPassword = Console.ReadLine();

                users.Add(new User(userName, userPassword));

                foreach (User user in users)
                {
                    if (user.UserName == userName && user.Password == userPassword)
                    {
                        active_user = user;
                        Console.WriteLine("Successfull Login!");
                    }
                }

                break;

            case "q":
                running = false;
                break;
        }

    }

    if (active_user != null)
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
    






