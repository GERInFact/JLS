namespace Introduction;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter # of items to add: ");
        
        // define array size
        var itemCount = int.Parse(Console.ReadLine());
        
        // create array with entered size
        var itemNames = new string[itemCount];
        var itemStrength = new int[itemCount];
        var itemDurability = new int[itemCount];
        
        // run over all slots and add in corresponding item name
        for (var i = 0; i < itemCount; i++)
        {
            Console.WriteLine("Enter item name: ");
            itemNames[i] = Console.ReadLine();
            
            Console.WriteLine("Enter item strength: ");
            itemStrength[i] = int.Parse(Console.ReadLine());
        }

        // print all added items
        for (var i = 0; i < itemCount; i++)
        {
            Console.WriteLine($"{itemNames[i]} added.");
            Console.WriteLine($"{itemStrength[i]} str.");
            
        }
        
        // TODO: 
        // Extend the code so items can be declared with their respective stats (strength, weight, durability, price, id)
    }
}