 namespace Facade_core
{
    //tag::source[]
    public class MarkUp
    {
        public string createMarkUp(string text)
        {
            HTMLElement html = new HTMLElement();
            BodyElement body = new BodyElement();
            PElement p = new PElement();
            TextElement textElement = new TextElement(text);
            p.add(textElement);
            body.add(p);
            html.add(body);
            return html.ToString();
        }
    }
}
//end::source[]
