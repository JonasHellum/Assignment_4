using Assignment_4.Interfaces;

namespace Assignment_4.HouseholdItems;

public class Carpet: Product, ILivingRoom, IOffice, IBedroom
{
    
    public override float Price()
    {
        return 100;
    }

    public override String GetShelf()
    {
        return "Shelf 2";
    }

    public override String Description()
    {
        return "A red medium sized carpet";
    }
    
    public String LivingRoom()
    {
        return "This carpet can be used in a living room.";
    }
    
    public String Office()
    {
        return "This carpet can be used in a office.";
    }
    
    public String Bedroom()
    {
        return "This carpet can be used in a bedroom.";
    }
}