namespace Introduction;

class Item
{
    public string Name { get; set; }
    public float Price { get; set; }
    public bool IsInUse { get; set; }
    public Stats Stats { get; set; } = new();
}