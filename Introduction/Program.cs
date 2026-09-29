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
        
        // run over all slots and add in corresponding item name
        for (var i = 0; i < itemCount; i++)
        {
            Console.WriteLine("Enter item name: ");
            itemNames[i] = Console.ReadLine();
        }

        // print all added items
        for (var i = 0; i < itemCount; i++)
            Console.WriteLine($"{itemNames[i]} added.");
    }
}