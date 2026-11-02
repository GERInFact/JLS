using System.Numerics;

namespace Learning;


public class Arena
{
    public int Seats { get; set; }
    public string Name { get; set; }
    
    // Acts like private but does allow initialization at object creation
    public Vector2 Position { get; init; }
    
    

    
    // Re-implementing default constructor
    public Arena()
    {
    }

    // Constructor with 1Parameter 
    public Arena(Vector2 position)
    {
        this.Position = position;
    }
    
}