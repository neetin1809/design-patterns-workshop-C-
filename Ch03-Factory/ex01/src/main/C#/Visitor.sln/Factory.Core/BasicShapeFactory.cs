using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Core
{
    public class BasicShapeFactory : IShapeFactory
    {
        public IShape create(string type)
        {
            if(type.Equals("circle", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            else if (type.Equals("rectangle", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }
            else
            {
                return null;
            }
        }
    }
}
