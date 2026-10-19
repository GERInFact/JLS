namespace Introduction;

class Program
{
    static void Main(string[] args)
    {
        var greatAxe = new Weapon { Name = "Great Axe", Price = 112.3f };
        greatAxe.Stats.HealthModifier = -20;
        greatAxe.Stats.ManaModifier = -3;

        var player = new Entity2D
        {
            Name = "Roxxor",
            Position = new Vector2D { X = 0, Y = 0 },
            Weapon = greatAxe
        };

        var orcania = new Entity2D { Name = "Orcania", Position = new Vector2D { X = 3, Y = 2 } };
        orcania.Stats.HealthModifier = 100;

        var isGameRunning = true;
        while (isGameRunning)
        {
            Console.WriteLine("Use w,a,s,d for movement along the axis.");
            var chosenDirection = Console.ReadLine();
            switch (chosenDirection.ToLower())
            {
             case "w":
                 player.Move(y:1);
                 break;
             case "d":
                 player.Move(x:1);
                 break;
             case "s":
                 player.Move(y:-1);
                 break;
             case "a":
                 player.Move(x:-1);
                 break;
             case "q":
                 isGameRunning = false;
                 break;
            }

            Console.WriteLine($"{player.Name} is at {player.Position}.");
        }
    }
}