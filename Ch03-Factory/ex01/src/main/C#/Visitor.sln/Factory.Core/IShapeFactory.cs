namespace Factory.Core
{
    public interface IShapeFactory
    {
        IShape create(string type);
    }
}
