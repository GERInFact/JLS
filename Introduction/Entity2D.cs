namespace Introduction;

class Entity2D
{
    public string Name { get; set; }
    public Stats Stats { get; set; } = new();
    public Weapon Weapon { get; set; }
    public Vector2D Position { get; set; }

    public void Attack(Entity2D target)
    {
        if (target == null) return;
        
        this.Weapon.ModifyStats(target.Stats);
    }
}