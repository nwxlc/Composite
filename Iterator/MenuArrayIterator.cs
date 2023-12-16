using Composite;

namespace Iterator;

public class MenuArrayIterator : IIterator<MenuItem>
{
    private MenuItem[] _menuItems;
    private int _current;
    
    public MenuArrayIterator(MenuItem[] menuItems)
    {
        _menuItems = menuItems;
        _current = 0;
    }
    
    public bool HasNext()
    {
        return _current < _menuItems.Length;
    }
    
    public MenuItem Next()
    {
        if (HasNext())
        {
            return _menuItems[_current++];
        }
        else
        {
            throw new InvalidOperationException("Блюд больше нет");
        }
    }
}