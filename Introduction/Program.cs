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

        const int STARTING_POS_X = 0;
        const int STARTING_POS_Y = 0;

        int[] mapBounds = new int[4] { -100, 100, -100, 100 };

        // player creation
        string playerName;
        int playerHealth;
        int playerStrength;
        int playerMana;
        int[] playerPosition2D = new int[2] { STARTING_POS_X, STARTING_POS_Y };

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

        // Movement 
        // Instruct the player who to move
        Console.WriteLine("Use w,a,s,d for movement to go north, west, south or east");
        
        // Get player input
        var movementInput = Console.ReadLine().ToLower();
        
        // Determine what to do based in player input
        switch (movementInput)
        {
            case "w": // move north
                playerPosition2D[1]++;
                break;
            case "a": // move west
                playerPosition2D[0]--;
                break;
            case "s": // move south
                playerPosition2D[1]--;
                break;
            case "d": // move east
                playerPosition2D[0]++;
                break;
            default: // If no valid selection, instruct player to choose valid input.
                Console.WriteLine("Invalid input. Movement not possible. Use keys as instructed!");
                break;
        }
        
        // Keep player within the map area
        if(playerPosition2D[0] > mapBounds[1]) // player outside X max
            playerPosition2D[0] = mapBounds[1];
        else if(playerPosition2D[0] < mapBounds[0]) // player outside X min
            playerPosition2D[0] = mapBounds[0];
        if(playerPosition2D[1] > mapBounds[3]) // player outside Y max
            playerPosition2D[1] = mapBounds[3];
        else if(playerPosition2D[1] < mapBounds[2]) // player outside Y min
            playerPosition2D[1] = mapBounds[2];
        

        // print players new location with x and y on 2D Map
        Console.WriteLine($"{playerName}, your are not at position ({playerPosition2D[0]}, {playerPosition2D[1]})");

        // TODO:
        // player equipment
        // combat with npc
        // reward system
    }
}