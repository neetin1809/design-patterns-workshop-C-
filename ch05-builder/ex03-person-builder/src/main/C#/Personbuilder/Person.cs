using System.Text;

namespace Personbuilder
{
    public class Person
    {
        string name;
        string title;
        private int age;
        double salary;

        public Person(string name, string title, int age, double salary)
        {
            this.name = name;
            this.title = title;
            this.age = age;
            this.salary = salary;
        }

        public string getName => name;

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Name: ");
            builder.Append(name);
            builder.Append("\n");

            builder.Append("Title: ");
            builder.Append(title);
            builder.Append("\n");

            builder.Append("Age: ");
            builder.Append(age);
            builder.Append("\n");

            builder.Append("Salary: ");
            builder.Append(salary);

            return builder.ToString();
        }
    }
}
