//tag::source[]
namespace Anticorruption_core
{
    public class User
    {
        string name;

        public User(string name)
        {
            this.name = name;
        }

        public string getName() => name;
    }
}
//tag::end[]