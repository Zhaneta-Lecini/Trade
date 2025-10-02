using System.Buffers;

namespace App;

class Item 
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

}

