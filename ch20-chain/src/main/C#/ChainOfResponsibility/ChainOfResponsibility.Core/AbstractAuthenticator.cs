namespace ChainOfResponsibility.Core
{
    public abstract class AbstractAuthenticator : IAuthenticator
    {
        private IAuthenticator nextAuthenticator;

        public virtual Response authenticate(Request request)
        {
            if(nextAuthenticator != null)
            {
                return nextAuthenticator.authenticate(request);
            }
            return null;
        }

        public IAuthenticator setNext(IAuthenticator authenticator)
        {
            this.nextAuthenticator = authenticator;
            return this.nextAuthenticator;
        }
    }
}
