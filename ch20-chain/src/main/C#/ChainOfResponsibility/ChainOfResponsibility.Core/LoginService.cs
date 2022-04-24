namespace ChainOfResponsibility.Core
{
    public class LoginService
    {
        private IAuthenticator authenticator;

        public LoginService(IAuthenticator authenticator)
        {
            this.authenticator = authenticator;
        }

        public Response login(string userName, string password)
        {
            Request response = new Request();
            response.setUserName(userName);
            response.setPassword(password);
            return authenticator.authenticate(response);
        }
    }
}
