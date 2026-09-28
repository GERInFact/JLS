namespace Introduction;

class Entity2D
{
    #region State

    #region Public

    public string Name { get; set; }
    public int Health { get; set; }
    public int Strength { get; set; }
    public int Mana { get; set; }

    #endregion

    #region Private

    private Vector2D position = new();

    #endregion

    #endregion

    #region Behavior

    public void Move(Vector2D direction)
    {
        this.position.X += direction.X;
        this.position.Y += direction.Y;
    }

    #endregion
}