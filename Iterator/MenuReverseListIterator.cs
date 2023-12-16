using Composite;

namespace Iterator;

public class MenuReverseListIterator : IIterator<MenuItem>
{
    private List<MenuItem> _menuItems;
    private int _current;
    
    public MenuReverseListIterator(List<MenuItem> menuItems)
    {
        _menuItems = menuItems;
        _current = menuItems.Count - 1;
    }
    
    public bool HasNext()
    {
        return _current >= 0;
    }
    
    public MenuItem Next()
    {
        if (HasNext())
        {
            return _menuItems[_current--];
        }
        else
        {
            throw new InvalidOperationException("Блюд больше нет");
        }
    }

}