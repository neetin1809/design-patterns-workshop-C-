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

        public void setName(string name)
        {
            this.name = name;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public Person build()
        {
            return new Person(name, title, age, salary);
        }
    }
}
