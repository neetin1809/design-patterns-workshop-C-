using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Core
{
    public  class Application
    {
        private readonly IUIToolsFactory toolsFactory;
        private readonly IToolButton toolButton;
        private readonly IShape shape;
        private readonly IMenuList menuList;

        public Application(IUIToolsFactory uitoolsFactory)
        {
            this.toolsFactory = uitoolsFactory;
            this.toolButton = toolsFactory.createToolButton("TOOL_1");
            this.shape = toolsFactory.createShape("CIRCLE");
            this.menuList = toolsFactory.createMenuList("FileMenu");
        }

        public IShape getShape() => this.shape;

        public IToolButton getToolButton() => this.toolButton;

        public IMenuList getMenuList() => this.menuList;
    }
}
