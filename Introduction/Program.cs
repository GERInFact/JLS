using System.Numerics;
using Learning;

namespace Introduction;

class Program
{
    static void Main(string[] args)
    {
        // custom defined constructor carrying 1 parameter / argument -> enforced by design
        Arena southRivenDaleArena = new Arena(new Vector2(1, 2));

        // default constructor
        Arena northRivenDaleArena = new Arena();

        // Member Initialization via Property Initialization  
        Arena eastRivenDaleArena = new Arena { Position = new Vector2(1, 2), Seats = 122 };
    }
}