namespace ChainOfResponsibility.Core
{
    public class Response
    {
        public string result;
        public string message;

        public string getResult() => result;

        public string getMessage() => message;

        public void setResult(string result) => this.result = result;

        public void setMessage(string message) => this.message = message;
    }
}
