using Assignment_4.Interfaces;

namespace Assignment_4.Furnitures;

public class Bookshelf: Product, IAssemblable, IBedroom, ILivingRoom, IOffice, IKitchen
{
    public override float Price()
    {
        return 400;
    }
    
    public override String GetShelf()
    {
        return "Shelf 40";
    }

    public override String Description()
    {
        return "A big brown bookshelf";
    }
    
    public String Assemble()
    {
        return "Stick the sides pieces on the pieces at the bottom, then throw the top on ontop and it's done ish.";
    }
    
    public String Bedroom()
    {
        return "This bookshelf can be used in a bedroom.";
    }
    
    public String LivingRoom()
    {
        return "This bookshelf can be used in a living room.";
    }
    
    public String Office()
    {
        return "This bookshelf can be used in an office.";
    }
    
    public String Kitchen()
    {
        return "This bookshelf can be used in a kitchen.";
    }
}