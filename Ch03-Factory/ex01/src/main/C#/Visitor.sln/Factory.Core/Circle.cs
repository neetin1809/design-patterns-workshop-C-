using System;

namespace Factory.Core
{
    public class Circle: IShape
    {
        public string getName() => $"Circle";
    }

    public class Rectangle : IShape
    {
        public string getName() => $"Rectangle";
    }
}
