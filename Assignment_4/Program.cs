using Assignment_4.Furnitures;
using Assignment_4.HouseholdItems;
using Assignment_4.Interfaces;

namespace Assignment_4;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = [];
        products.Add(new Bookshelf());
        products.Add(new Child_s_Bunk_Bed());
        products.Add(new Desk());
        products.Add(new Sofa());
        products.Add(new Basket());
        products.Add(new Carpet());
        products.Add(new Cooking_pot());
        products.Add(new Desk_lamp());
        
        foreach (Product product in products)
        {
            Console.WriteLine($"\n{product.Description()}");
            Console.WriteLine($"Price is: {product.Price()}");
            Console.WriteLine($"Location: {product.GetShelf()}");
            
            if (product is IAssemblable)
            {
                Console.WriteLine($"Assembly instructions: {((IAssemblable)product).Assemble()}");
            }
            if (product is IBedroom)
            {
                Console.WriteLine(((IBedroom)product).Bedroom());
            }
            if (product is ILivingRoom)
            {
                Console.WriteLine(((ILivingRoom)product).LivingRoom());
            }
            if (product is IOffice)
            {
                Console.WriteLine(((IOffice)product).Office());
            }
            if (product is IKitchen)
            {
                Console.WriteLine(((IKitchen)product).Kitchen());
            }
        }
    }
}