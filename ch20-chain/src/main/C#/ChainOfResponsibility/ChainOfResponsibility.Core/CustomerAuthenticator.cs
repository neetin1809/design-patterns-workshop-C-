using System.Linq;

namespace ChainOfResponsibility.Core
{
    public class CustomerAuthenticator : AbstractAuthenticator
    {
        public string[] customerList = new string[]
        {
            "customer1@gmail.com", "customer2@rediff.com"
        };

        public override Response authenticate(Request request)
        {
            if(customerList.Any( x => x == request.userName))
            {
                Response response = new Response();
                response.setResult("SUCCESS");
                response.setMessage("Customer Login Successful..");
                return response;
            }
            return base.authenticate(request);
        }
    }
}
