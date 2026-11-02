namespace Learning;

public class GameManager
{
    // Create accessor for GM obj
    public static GameManager Instance => (gm  != null ? gm : gm = new GameManager());

    public string CurrentLevel { get; set; }
    
    // Create GM container only available object is stored in.
    private static GameManager gm;
    
    // Hide constructor so no other script is able to create an object of this class from outside
    private GameManager() {}
    
    
}