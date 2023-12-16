namespace Composite;

public class MenuItem : MenuComponent
{
    public bool IsVegan { get; private set; }

    public MenuItem(string name, bool isVegan)
        : base(name)
    {
        IsVegan = isVegan;
    }

    public override void Add(MenuComponent component)
    {
        throw new Exception("Блюдо нельзя добавить");
    }

    public override void Remove(MenuComponent component)
    {
        throw new Exception("Блюдо нельзя удалить");
    }
}