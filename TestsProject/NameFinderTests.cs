using DyeAndDurham.Logic;
namespace TestsProject
{
    [TestClass]
    public class NameFinderTests
    {
        [TestMethod]
        public void TestOneName()
        {
            NameFinder finder = new NameFinder();

            List<string> firstNames = new List<string>();
            firstNames.Add("Timmy");
            firstNames.Add("Tucson");
            string surName = "Testington";
            Person person = new Person(firstNames, surName);

            List<string> names = new List<string>();
            names.Add("Timmy Tucson Testington");

            Assert.IsTrue(person.GetInfo().Equals(finder.GetNames(names).First().GetInfo()));
        }

        [TestMethod]
        public void TestTwoNames()
        {
            NameFinder finder = new NameFinder();

            List<string> firstNames = new List<string>();
            firstNames.Add("Timmy");
            firstNames.Add("Tucson");
            Person person = new Person(firstNames, "Testington");
            Person person2 = new Person(firstNames, "Tennison");


            List<string> names = new List<string>();
            names.Add("Timmy Tucson Testington");
            names.Add("Timmy Tucson Tennison");

            Assert.IsTrue(person.GetInfo().Equals(finder.GetNames(names)[0].GetInfo()) && person2.GetInfo().Equals(finder.GetNames(names)[1].GetInfo()));
        }
    }
}