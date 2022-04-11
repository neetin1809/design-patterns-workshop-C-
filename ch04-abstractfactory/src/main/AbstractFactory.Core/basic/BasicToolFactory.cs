namespace AbstractFactory.Core.basic
{
    public class BasicToolFactory : IUIToolsFactory
    {
        public IMenuList createMenuList(string type) => new BasicMenuList();

        public IShape createShape(string type) => new BasicShape();

        public IToolButton createToolButton(string type) => new BasicToolButton();
    }
}
