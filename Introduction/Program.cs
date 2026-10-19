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

        player.Attack(orcania);
        Console.WriteLine($"{greatAxe.Name} of {player.Name} attacks {orcania.Name}");
        Console.WriteLine(
            $"{orcania.Name} has lost {Math.Abs(player.Weapon.Stats.HealthModifier)} health and {Math.Abs(player.Weapon.Stats.ManaModifier)} mana");
        Console.WriteLine(
            $"{orcania.Name} has {orcania.Stats.HealthModifier} remaining health and {orcania.Stats.ManaModifier} mana");
    }
}