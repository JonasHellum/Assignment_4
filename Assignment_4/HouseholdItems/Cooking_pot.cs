using Assignment_4.Interfaces;

namespace Assignment_4.HouseholdItems;

public class Cooking_pot: Product, IKitchen
{
    public override float Price()
    {
        return 20;
    }

    public override String GetShelf()
    {
        return "Shelf 4"; 
    }

    public override String Description()
    {
        return "This is a huge black cooking pot.";
    }
    
    public String Kitchen()
    {
        return "This cooking pot can be used in a kitchen.";
    }
}