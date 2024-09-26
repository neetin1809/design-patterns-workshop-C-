namespace Personbuilder
{
    public class PersonBuilder
    {
        string name;
        string title;
        private int age;
        double salary;

        public PersonBuilder()
        {
            name = "No Name";
            title = "No Title";
            age = 28;
            salary=25000; 
        }

        
        public PersonBuilder withName(string name)
        {
            this.name = name;
            return this;
        }

        public PersonBuilder withTitle(string title)
        {
            this.title = title;
            return this;
        }

        public PersonBuilder withAge(int age)
        {
            this.age = age;
            return this;
        }

        public PersonBuilder withSalary(double salary)
        {
            this.salary = salary;
            return this;
        }

        public Person build()
        {
            return new Person(name, title, age, salary);
        }
    }
}
