namespace ChainOfResponsibility.Core
{
    public interface IAuthenticator
    {
        IAuthenticator setNext(IAuthenticator authenticator);
        Response authenticate(Request request);
    }
}
