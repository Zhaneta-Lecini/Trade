namespace App;


public class User // Rapresenterar en användare med email och lösenord //public klass så det kan användas från andra klasser eller main Program;
//vi bygger en konstrukt;
{

    public string UserName { get; private set; }// UserNmae är EMAIL på användaren/ public så vi kan läsa, men private set för säkerhet
    public string Password { get; private set; }// Password, public get men private set så man inte ändrar direkt utifrån;


    // Konstruktor som initierar User med email och password
    public User(string userName, string password)// konstruktor som skapar ett nytt User-objekt.
                                                 //t.ex new User("Alex@hotmail.com", 1234247648)-skickas email och pass. hit
    {
        UserName = userName;
        Password = password;
    }


    // ToString-metod för att visa användarens namn när vi skriver ut User-objekt;
    public override string ToString() // när vi skriver ut ett User-objekt i Console.WriteLine(user)-visas user:Alex@hotmail.com.
    {
        return $"User":  { UserName}  "; 
    }   
}




//users är alla personer som kan handla.

//items är alla saker som finns att köpa/sälja.
//
//Varje Item vet vem som äger det, och det är alltid ett objekt från users.

//Trade-klassen använder _items för att göra handlingar (visa, byta ägare), men den behöver inte veta allt om users, bara vem som köper (User-objekt skickas som parameter).