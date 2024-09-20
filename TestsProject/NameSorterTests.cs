using DyeAndDurham.Logic;
namespace TestsProject
{
    [TestClass]
    public class NameSorterTests
    {
        [TestMethod]
        public void TestUnsorted()
        {
            NameSorter sorter = new NameSorter();

            List<string> firstNames = new List<string>();
            firstNames.Add("Timmy");
            firstNames.Add("Tucson");
            
            Person person = new Person(firstNames, "Testington");
            Person person2 = new Person(firstNames, "Anderson");

            List<Person> people = new List<Person>();
            people.Add(person);
            people.Add(person2);

            Assert.IsTrue(sorter.SortPeople(people)[0].GetInfo().Equals(person2.GetInfo()));
        }

        [TestMethod]
        public void TestSorted()
        {
            NameSorter sorter = new NameSorter();

            List<string> firstNames = new List<string>();
            firstNames.Add("Timmy");
            firstNames.Add("Tucson");

            Person person = new Person(firstNames, "Testington");
            Person person2 = new Person(firstNames, "Anderson");

            List<Person> people = new List<Person>();
            people.Add(person2);
            people.Add(person);

            Assert.IsTrue(sorter.SortPeople(people)[0].GetInfo().Equals(person2.GetInfo()));
        }
    }
}