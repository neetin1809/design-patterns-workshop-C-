namespace ChainOfResponsibility.Core
{
    public class Request
    {
        public string userName;
        public string password;

        public string getUserName() => userName;

        public string getPassword() => password;

        public void setPassword(string password) => this.password = password;

        public void setUserName(string userName) => this.userName = userName;
    }
}
