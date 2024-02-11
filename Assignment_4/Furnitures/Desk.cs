using Assignment_4.Interfaces;

namespace Assignment_4.Furnitures;

public class Desk: Product, IAssemblable, IOffice
{
    public override float Price()
    {
        return 200;
    }

    public override String GetShelf()
    {
        return "Shelf 3";
    }

    public override String Description()
    {
        return "This is a medium sized oak desk.";
    }
    
    public String Assemble()
    {
        return "Screw the foot into the top.";
    }
    
    public String Office()
    {
        return "This desk can be used in a office.";
    }
    
}