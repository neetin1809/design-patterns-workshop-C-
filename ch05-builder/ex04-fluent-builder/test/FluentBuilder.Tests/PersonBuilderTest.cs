using Microsoft.VisualStudio.TestTools.UnitTesting;
using  Personbuilder;

namespace PersonBuilder.Tests
{
    [TestClass]
    public class PersonBuilderTest
    {
        private Personbuilder.PersonBuilder personbuilder;

        private Person person;

        [TestInitialize]
        public void Intialize()
        {
            personbuilder = new Personbuilder.PersonBuilder();
        
}

        [TestMethod]
        public void Default_Test_For_Person()
        {
            //When
            person = personbuilder.build();

            //expected
            string details = "Name: No Name\n"
                        + "Title: No Title\n"
                        + "Age: 28\n"
                        + "Salary: 25000";

            //result
            Assert.AreEqual(details, person.ToString());
        }


        [TestMethod]
        public void Name_Test_For_Person()
        {
            //Given
            person = personbuilder.withName("Neetin")
                                  .build();

            //expected
            string details = "Name: Neetin\n"
                        + "Title: No Title\n"
                        + "Age: 28\n"
                        + "Salary: 25000";

            //result
            Assert.AreEqual(details, person.ToString());
        }

        [TestMethod]
        public void Name_With_Title_Test_For_Person()
        {
            //Given
            person = personbuilder.withName("Neetin")
                        .withTitle("Module Lead")
                        .build();
            
            //expected
            string details = "Name: Neetin\n"
                        + "Title: Module Lead\n"
                        + "Age: 28\n"
                        + "Salary: 25000";

            //result
            Assert.AreEqual(details, person.ToString());
        }


        [TestMethod]
        public void Full_Details_Test_For_Person()
        {
            //Given
            personbuilder.withName("Neetin");
            personbuilder.withTitle("Module Lead");
            personbuilder.withAge(28);
            personbuilder.withSalary(25000);

            //when
            person = personbuilder.build();

            //expected
            string details = "Name: Neetin\n"
                        + "Title: Module Lead\n"
                        + "Age: 28\n"
                        + "Salary: 25000";

            //result
            Assert.AreEqual(details, person.ToString());
        }
    }
}
