using System.Xml;

namespace App;
 //jag ville att göra en Itemstransert mellan användare via mail


public class Trade // Ska hantera marknadsfunktioner som att visa items, köpa items och flytta items mellan användare
{
    private List<Item> _items; // Lista med alla items på marknaden
    public Trade(List<Item> items)
    {
        _items = items;
    }
    public void ShowMarket()
    {
        if (_items.Count == 0) //för att kolla om listen är tom;
        {
            Console.WriteLine("Marknaden är tom.");// när finns inga items att visa;
        }
        else
        {
            Console.WriteLine("Items på marknaden:");
            for (int i = 0; i < _items.Count; i++)//loppar igenom alla items tills från den första item till alla items count , hoppar +1;
            {
                Console.WriteLine($"{i + 1}. {_items[i]}");//skriver ut items via ToString;
            }
        }
    }

    {
        Console.WriteLine("Vilket item vill du sälja?");
        string itemName = Console.ReadLine() ?? "";

        // För att hitta item
        Item? itemToMove = null;
        for (int i = 0; i < _items.Count; i++)//använd foor loop index (for a Finite amount of time)to keep track of iteneration.
        {
            if (_items[i].Name.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                itemToMove = _items[i];
                break;
            }
        }

        if (itemToMove == null)
        {
            Console.WriteLine("Itemet finns inte.");
            return;
        }

        // Ny ägare
        Console.WriteLine("Ange email på ny ägare:");
        string newEmail = Console.ReadLine() ?? "";

        User? newOwner = null;
        foreach (var user in Program.users) //måste ha users-listan åtkomlig här
        {
            if (user.UserName.Equals(newEmail, StringComparison.OrdinalIgnoreCase))
            {
                newOwner = user;
                break;
            }
        }

        if (newOwner == null)
        {
            Console.WriteLine("Användaren finns inte.");
            return;
        }

        // För att flytta item
        itemToMove.ChangeOwner(newOwner);
        Console.WriteLine($"Item '{itemToMove.Name}' är nu ägt av {newOwner.UserName}!");
    }
}