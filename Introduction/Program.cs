namespace Introduction;

class Program
{
    static void Main(string[] args)
    {
        const int HEALTH_MAX_CAP = 100;
        const int HEALTH_MIN_CAP = 10;
        const int HEALTH_DEFAULT = 80;

        const int STRENGTH_MAX_CAP = 20;
        const int STRENGTH_MIN_CAP = 5;
        const int STRENGTH_DEFAULT = 8;

        const int MANA_MAX_CAP = 23;
        const int MANA_MIN_CAP = 5;
        const int MANA_DEFAULT = 8;

        // player creation
        string playerName;
        int playerHealth;
        int playerStrength;
        int playerMana;

        // Print text to console
        Console.WriteLine("Welcome to the World of Magic Treasures!");
        Console.WriteLine("Enter your name: ");

        // Get text input from console window and store in player name
        playerName = Console.ReadLine();
        
        // Read in all stats and split stats into an array of texts to convert
        Console.WriteLine($"{playerName}, enter your health, strength and mana");
        var playerStatsAsText = Console.ReadLine().Split(",");
        playerHealth = int.Parse(playerStatsAsText[0].Trim());
        playerStrength = int.Parse(playerStatsAsText[1].Trim());
        playerMana = int.Parse(playerStatsAsText[2].Trim());


        if (playerHealth > HEALTH_MAX_CAP || playerHealth <= HEALTH_MIN_CAP)
            playerHealth = HEALTH_DEFAULT;
        if (playerStrength > STRENGTH_MAX_CAP || playerStrength <= STRENGTH_MIN_CAP)
            playerStrength = STRENGTH_DEFAULT;
        if (playerMana > MANA_MAX_CAP || playerMana <= MANA_MIN_CAP)
            playerMana = MANA_DEFAULT;

        // Print out saved player data and print to console.
        Console.WriteLine(
            $"Your character has been created successfully. {playerName}, Health: {playerHealth}, Strength: {playerStrength}, Mana: {playerMana}");

        // TODO:
        // player movement 
        // player equipment
        // combat with npc
        // reward system
    }
}