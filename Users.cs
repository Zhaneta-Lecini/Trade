namespace App;

public class User // Rapresenterar en användare med email och lösenord
//vi bygger en konstrukt;
{
    public string UserName { get; private set; }// UserNmae är EMAIL på användaren/ public så vi kan läsa, men private set för säkerhet
    public string Password { get; private set; }// Password, public get men private set så man inte ändrar direkt utifrån;
    {

// Konstruktor som initierar User med email och password
    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }


// ToString-metod för att visa användarens namn när vi skriver ut User-objekt;
    public bool TryLogin(string username, string password)
    {
        return username == UserName && password == Password;
    }

}