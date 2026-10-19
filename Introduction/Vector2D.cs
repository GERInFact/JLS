namespace Introduction;

class Vector2D
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"({this.X}, {this.Y})";
    }
}