using Composite;

namespace Iterator;

public class MenuVeganIterator : IIterator<MenuItem>
{
    private List<MenuItem> _menuItems;
    private int _current;
    
    public MenuVeganIterator(List<MenuItem> menuItems)
    {
        _menuItems = menuItems;
        _current = 0;
    }
    
    public bool HasNext()
    {
        while (_current < _menuItems.Count && !_menuItems[_current].IsVegan)
        {
            _current++;
        }
        return _current <= _menuItems.Count;
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