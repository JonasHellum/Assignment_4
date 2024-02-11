using Assignment_4.Interfaces;

namespace Assignment_4.Furnitures;

public class Sofa: Product, IAssemblable, ILivingRoom, IBedroom
{
    public override float Price()
    {
        return 300; 
    }

    public override String GetShelf()
    {
        return "Shelf 6";
    }

    public override String Description()
    {
        return "This is a white medium sized sofa.";
    }
    
    public String Assemble()
    {
        return "Comes in 2 parts, take the long part and click it into the smaller part and done.";
    }
    
    public String LivingRoom()
    {
        return "This sofa can be used in the living room.";
    }

    public String Bedroom()
    {
        return "This sofa can be used in a bedroom.";
    }
}