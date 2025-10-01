namespace App;

class User
//vi bygger en konstrukt;
{
    public string UserName;
    public string Password;

    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }

    public bool TryLogin(string username, string password)
    {
        return username == UserName && password == Password;
    }

}