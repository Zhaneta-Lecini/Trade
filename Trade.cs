using System.Xml;

namespace App;
//jag ville att göra en Itemstransert mellan användare via mail


public class Trade // detta klass  Ska hantera marknadsfunktioner som att visa items, köpa items och flytta items mellan användare;
{
    private List<Item> _items; // Lista med alla items på marknaden;
   
    public Trade(List<Item> items) //public så den ska köras på de andra klasser eller main program;
    {
        _items = items;
    }


    public void ShowMarket() //om vi vill att metoden ska kunna köras från de andra klasse eller main program = public;
    {
        if (_items.Count == 0) //för att kolla om listen är tom; 
        {
            Console.WriteLine("Marknaden är tom.");// när finns inga items att visa;
        }

        else

        {
            Console.WriteLine("Items :");

            for (int i = 0; i < _items.Count; i++)//loppar igenom alla items tills från den första item till alla items count , hoppar +1;
            {
                Console.WriteLine($"{i + 1}. {_items[i]}");//skriver ut items via ToString;
            }
        }
    }
    // För att låta en inloggad användare köpa ;
    


    public void BuyItem(User buyer)//Public - behövs om man ska använda metoden utanför klassen och void - används om metoden inte behöver returnera ngt.
    {
        if (buyer == null) return;// Om ingen användare är inloggad då avsluta;

        ShowMarket();// Visa marknaden ;
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int choice)) // Kolla att input är ett tal
        {
            if (choice > 0 && choice <= _items.Count) // Kolla att valet är giltigt
            {
                Item selected = _items[choice - 1]; // Välj item

                if (selected.Owner == buyer) // Kolla att användaren inte köper sitt eget item
                {
                    Console.WriteLine("Du kan inte köpa ditt eget item!");
                    return;
                }

                selected.ChangeOwner(buyer);// Ändra ägare till köparen
                Console.WriteLine($"Du har köpt {selected.Name}!");
            }
            else
            {
                Console.WriteLine("Ogiltigt itemnummer.");// Om valet är utanför listan
            }
        }
        else
        {
            Console.WriteLine("Felaktig input.");// Om input inte är ett tal
        }
    }

    // Flytta item från en användare till en annan


    public void TransferItem(List<User> users) // Tar emot listan med alla användare
    {
        Console.WriteLine("Vilken item vill du sälja?");
        string itemName = Console.ReadLine() ?? "";

        // För att hitta item
        Item? itemToMove = null;
        for (int i = 0; i < _items.Count; i++)//använd foor loop index (for a Finite amount of time)to keep track of iteneration.
        { // Början på for-loopens kod block
            if (_items[i].Name.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                itemToMove = _items[i];
                break;
            }
        }

        if (itemToMove == null)
        {
            Console.WriteLine("Item finns inte.");
            return;
        }

        // Ny ägare
        Console.WriteLine("Ange email på nyt ägare:");
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

        if (newOwner == null) //if hitta e ny ägare, annars return;
        {
            Console.WriteLine("Användaren finns inte.");
            return;
        }

        //För att flytta item från användare som säljer (owner) till den andra som köper;
        itemToMove.ChangeOwner(newOwner);
        Console.WriteLine($"Item '{itemToMove.Name}' är nu ägt av {newOwner.UserName}!");
    }
}

    // köplogiken ligga, 
   
    // Fråga användaren vilken item han vill köpa
    //  Kontrollera att input är ett giltigt nummer
    // Se till att användaren inte köper sitt eget item !!! FIXA
    // Bytt ägare med ChangeOwner
    //  Bekräfta köpet........