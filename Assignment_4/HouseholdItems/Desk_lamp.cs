using Assignment_4.Interfaces;

namespace Assignment_4.HouseholdItems;

public class Desk_lamp: Product, IOffice, IBedroom
{
    
    public override float Price()
    {
        return 50;
    }

    public override String GetShelf()
    {
        return "Shelf 2";
    }

    public override String Description()
    {
        return "This is a white desk lamp."; 
    }
    
    public String Office()
    {
        return "This desk lamp can be used in a office";
    }

    public String Bedroom()
    {
        return "This desk lamp can be used in a bedroom";
    }
}