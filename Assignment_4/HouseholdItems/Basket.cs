using Assignment_4.Interfaces;

namespace Assignment_4.HouseholdItems;

public class Basket: Product, IKitchen, IBedroom
{
    public override float Price()
    {
        return 5;
    }

    public override String GetShelf()
    {
        return "Shelf 5";
    }

    public override String Description()
    {
        return "This is a small black basket.";
    }
    
    public String Kitchen()
    {
        return "This basket can be used in a kitchen.";
    }
    
    public String Bedroom()
    {
        return "This basket can be used in a bedroom.";
    }
}