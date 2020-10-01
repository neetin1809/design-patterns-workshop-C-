namespace Composite_Library
{
    public class TextElement : HTMLElement
    {
        public TextElement(string text) : base(text)
        {
        }

        public override string ToString()
        {
            return this.tagName;
        }
    }
}
