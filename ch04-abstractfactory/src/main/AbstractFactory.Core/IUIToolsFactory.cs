namespace AbstractFactory.Core
{
    public interface IUIToolsFactory
    {
        IToolButton createToolButton(string type);
        IShape createShape(string type);
        IMenuList createMenuList(string type);
    }
}
