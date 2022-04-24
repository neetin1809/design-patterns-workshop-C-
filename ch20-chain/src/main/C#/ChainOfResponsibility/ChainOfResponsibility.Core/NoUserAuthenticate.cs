namespace ChainOfResponsibility.Core
{
    public class NoUserAuthenticate : AbstractAuthenticator
    {
        public override Response authenticate(Request request)
        {
            Response response = new Response();
            response.setResult("FAILURE");
            response.setMessage("No user Found..");
            return response;
        }
    }
}
