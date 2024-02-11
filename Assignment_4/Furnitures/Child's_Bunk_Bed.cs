using Assignment_4.Interfaces;

namespace Assignment_4.Furnitures;

public class Child_s_Bunk_Bed: Product, IAssemblable, IBedroom
{
    public override float Price()
    {
        return 400; 
    }

    public override String GetShelf()
    {
        return "Shelf 7";
    }

    public override String Description()
    {
        return "This is a pink child's bunk bed.";
    }
    
    public String Assemble()
    {
        return "Throw the sides on the bottom, roll out the planks ontop and done.";
    }
    
    public String Bedroom()
    {
        return "This bed can be used in a child's bedroom.";
    }
}