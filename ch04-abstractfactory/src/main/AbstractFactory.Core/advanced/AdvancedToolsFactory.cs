namespace AbstractFactory.Core.advanced
{
    public class AdvancedToolsFactory : IUIToolsFactory
    {
        public IMenuList createMenuList(string type)
        {
            return new AdvancedMenuList();
        }

        public IShape createShape(string type)
        {
            return new AdvancedShape();
        }

        public IToolButton createToolButton(string type)
        {
            return new AdvancedToolButton();
        }
    }
}
