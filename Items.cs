using System.Buffers;

namespace App;

public class Item //Rapresenterar ett item (objekt), kopplat till en ägare(User);
//vi bygger en konstrukt;

// Hur kan programmet access eller update thouse value from outside the class ??
//"Used -get-set properties, which is a variable inside a class" 
// I need (get) to show items in the market and (set) to let users add or change items and to change the owner when someone buys the items;
{  
bash: it: command not found

    public string Name { get; set; } //name är public som kan läsas och ändras
    public string Description { get; set; } //description är public
    public User Owner { get; set; } //owner = ägaren , private set så man inte ändrar direkt utifrån;

// Vi bygger ett konstruktor för att skapa en ny Item med namn, deskription och ägaren;
    public Item(string name, string description, User owner)
    {
        Name = name;
        Description = description;
        Owner = owner;
    }
 // Metod för att ändra ägare av item, public så alla kan kalla denna metod.
    public void ChangeOwner(User newOwner)
    {
        Owner = newOwner;
    }
    public override string ToString() // To Sting metod för att visa items namn, description och owner när viskriver
    {
        return $"{Name} - {Description} (Ägare: {Owner.UserName})"; // Här visar vi Name, Description och Owner istället för bara "App.Item"..t.ex Stol - Black (Ägare: Anna@hotmail.com)
        //ToString() används för att bestämma hur ett objekt visas som text.
        // override = betyder att vi ersätter standard-beteendet från object-klassen. 
    }

}

