namespace Introduction;


// Declare enum / multiple constant values
// Starts with 0 if not defined otherwise 
enum COLOR
{
    Red,
    Green,
    Blue
}

class Program
{
    static void Main(string[] args)
    {
        
        // set enum value
        COLOR raidColor = COLOR.Blue;

        
        // Repeat until program is terminated manually
        while (true)
        {
            // check current value
            switch (raidColor)
            {
                
                // if red or green print Nice to console
                case COLOR.Red:
                case COLOR.Green:
                    Console.WriteLine("Nice");
                    break;
                
                // if Blue print other stuff...
                case COLOR.Blue:
                    Console.WriteLine("This is really blue");
                    raidColor = COLOR.Red;
                    break;
            }
        }
      

        // TODO: Implement a text base game
        // Adventure, RPG, SteamPunk, Card Game, Pokémon, SciFi, Fantasy
        // Use Arrays, Multidimensional Arrays, Input, Output, Conditions, Loops

    }
}