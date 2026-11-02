using Learning;

namespace Introduction;

class Program
{
    static void Main(string[] args)
    {
        // First reference to GM Instance
        var gm = GameManager.Instance;
        gm.CurrentLevel = "Intro";

        // References the same GM object
        var gm2 = GameManager.Instance;
        gm2.CurrentLevel = "Main Menu";

        // Still the same GM object that is being accessed.
        Console.WriteLine(GameManager.Instance.CurrentLevel);
    }
}