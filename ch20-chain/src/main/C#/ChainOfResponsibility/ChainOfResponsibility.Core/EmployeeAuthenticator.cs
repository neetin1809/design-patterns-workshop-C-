using System.Linq;

namespace ChainOfResponsibility.Core
{
    public class EmployeeAuthenticator : AbstractAuthenticator
    {
        public string[] employeeList = new string[]
        {
            "employee1@company.com", "employee2@company.com"
        };

        public override Response authenticate(Request request)
        {
            if (employeeList.Any(x => x == request.userName))
            {
                Response response = new Response();
                response.setResult("SUCCESS");
                response.setMessage("Employee Login Successful..");
                return response;
            }
            return base.authenticate(request);
        }
    }
}
