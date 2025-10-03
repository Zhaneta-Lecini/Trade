using System.Buffers;

namespace App;

public class Item
//vi bygger en konstrukt;
{
    public string Name;
    public string Description;
    public User Owner;

    public Item(string name, string description, User owner)
    {
        Name = name;
        Description = description;
        Owner = owner;
    }

    public void ChangeOwner(User newOwner)
    {
        Owner = newOwner;
    }
    public override string ToString()
    {
        return ${Name} - {Description} (Ägare: {Owner.UserName});
    }

}

